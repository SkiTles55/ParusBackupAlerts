using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using Cassia;
using System.Net;
using System.Net.Mail;

namespace ParusBackupAdmin
{
    public partial class BackupWindow : Form
    {
        public BackupWindow()
        {
            InitializeComponent();
        }

        private int _uptoFileCount;
        private int _totalFileCount;
        bool stoped = false;
        Stopwatch stopWatch;
        string datefolder;

        private int FolderContentsCount(string path)
        {
            int result = Directory.GetFiles(path).Length;
            string[] subFolders = Directory.GetDirectories(path);
            foreach (string subFolder in subFolders)
                result += FolderContentsCount(subFolder);
            return result;
        }

        private void ProcessFileMethod(object sender, ScanEventArgs args)
        {
            _uptoFileCount++;
            int percentCompleted = _uptoFileCount * 100 / _totalFileCount;
            TimeSpan ts = stopWatch.Elapsed;
            string fileName = args.Name;
            if (stoped) args.ContinueRunning = false;
            BeginInvoke((Action)(() =>
            {
                ZipProgress.Value = percentCompleted;
                ProgressLabel.Text = "Текущая операция: архивация файла " + fileName;
                Program.secondsleft = (ts.TotalSeconds / _uptoFileCount) * (_totalFileCount - _uptoFileCount);
                timeLabel.Text = "Примерно осталось: " + TimeSpan.FromSeconds(Program.secondsleft).ToString(@"mm\:ss");
            }));
        }

        private void BackupWindow_Activated(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy) backgroundWorker1.RunWorkerAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите отменить создание бэкапа?", "Отмена операции", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    backgroundWorker1.CancelAsync();
                    stoped = true;
                    LogOutput.AppendText(Environment.NewLine + "Создание бэкапа отменено");
                    if (!Program.FinishedBackups.Contains(Program.backupTime)) Program.FinishedBackups.Add(Program.backupTime);
                    if (Properties.Settings.Default.bWautoclose) Close();
                }
            }
            else Close();
        }

        private void AutoClose_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.bWautoclose = AutoClose.Checked;
            Properties.Settings.Default.Save();
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            stoped = false;
            BeginInvoke((Action)(() =>
            {
                LogOutput.AppendText("Проверка пользователей...");
            }));
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                Dictionary<string, List<ITerminalServicesProcess>> users = new Dictionary<string, List<ITerminalServicesProcess>>();
                server.Open();
                foreach (var session in server.GetSessions())
                {
                    List<ITerminalServicesProcess> pr = new List<ITerminalServicesProcess>();
                    var processes = session.GetProcesses();
                    foreach (var l in processes)
                        if (Program.IsParus(l))
                            pr.Add(l);
                    if (pr.Count > 0) users.Add(session.UserName, pr);
                }
                if (users.Count > 0)
                {
                    string text = String.Empty;
                    foreach (var u in users)
                    {
                        if (String.IsNullOrEmpty(text)) text = u.Key;
                        else text += Environment.NewLine + u.Key;
                    }
                    var result = AutoClosingMessageBox.Show(text, "Закрыть все активные соединения?", 60000, MessageBoxButtons.YesNo, DialogResult.Yes);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var u in users)
                        {
                            foreach (var proc in u.Value)
                                proc.Kill();
                        }
                        BeginInvoke((Action)(() =>
                        {
                            LogOutput.AppendText(Environment.NewLine + "Закрытые пользователи:" + Environment.NewLine + text);

                        }));
                    }
                }
            }
            _totalFileCount = 0;
            foreach (var path in Program.dirs)
                _totalFileCount += FolderContentsCount(path);
            BeginInvoke((Action)(() =>
            {
                LogOutput.AppendText(Environment.NewLine + "Создание бэкапа базы данных Parus " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                LogOutput.AppendText(Environment.NewLine + "Общее количество папок: " + Program.dirs.Count);
                LogOutput.AppendText(Environment.NewLine + "Общее количество файлов: " + _totalFileCount);

            }));
            FastZipEvents events = new FastZipEvents();
            ZipStrings.CodePage = 866;
            events.ProcessFile = ProcessFileMethod;
            FastZip fastZip = new FastZip(events)
            {
                CreateEmptyDirectories = true
            };
            datefolder = "ParusBackup " + DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
            if (!Directory.Exists(Properties.Settings.Default.savepath + "\\" + datefolder))
                Directory.CreateDirectory(Properties.Settings.Default.savepath + "\\" + datefolder);
            foreach (var path in Program.dirs)
            {
                try
                {
                    var dp = path.Split('\\');
                    string zipFileName = Properties.Settings.Default.savepath + "\\" + datefolder + "\\" + ((dp.Count() >= 2) ? dp[dp.Count() - 2] + "." + dp[dp.Count() - 1] : dp.Last()) + ".zip";
                    fastZip.CreateZip(zipFileName, path, true, "");
                    BeginInvoke((Action)(() =>
                    {
                        LogOutput.AppendText(Environment.NewLine + "Выполнена архивация папки " + path);
                    }));
                }
                catch (Exception ex)
                {
                    BeginInvoke((Action)(() =>
                    {
                        LogOutput.AppendText(Environment.NewLine + "Ошибка архивации папки " + path + ": " + ex.Message);
                    }));
                }
            }
            stopWatch.Stop();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            if (e.Cancelled)
                LogOutput.AppendText(Environment.NewLine + "Архивация базы данных отменена пользователем.");
            else if (e.Error != null)
                LogOutput.AppendText(Environment.NewLine + "При архивация базы данных произошла ошибка: " + e.Error.Message);
            else
                LogOutput.AppendText(Environment.NewLine + "Архивация базы данных завершена. Затрачено времени:" + elapsedTime);
            ProgressLabel.Text = "Архивация базы данных завершена";
            if (Properties.Settings.Default.emailnotify && !String.IsNullOrEmpty(Properties.Settings.Default.emaillogin) && !String.IsNullOrEmpty(Properties.Settings.Default.emailpass))
            {
                foreach (var email in Program.emails)
                {
                    try { SendEmail("Архивация базы данных завершена" + Environment.NewLine + "Лог:" + Environment.NewLine + LogOutput.Text, email); }
                    catch (Exception ex) { LogOutput.AppendText(Environment.NewLine + $"Ошибка отправка оповещения на адрес {email}: " + ex.Message); }
                }
            }
            if (!Program.FinishedBackups.Contains(Program.backupTime)) Program.FinishedBackups.Add(Program.backupTime);
            TextWriter writer = new StreamWriter(Properties.Settings.Default.savepath + "\\" + datefolder + "\\Log.txt");
            writer.Write(LogOutput.Text);
            writer.Close();
            CancelB.Text = "Закрыть";
            if (Properties.Settings.Default.bWautoclose) Close();
        }

        private void SendEmail(string text, string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(Properties.Settings.Default.emaillogin, "Парус Бэкапы");
            mail.To.Add(email);
            mail.Subject = "Бэкап базы Парус";
            mail.Body = text;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(Properties.Settings.Default.emaillogin, Properties.Settings.Default.emailpass);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
