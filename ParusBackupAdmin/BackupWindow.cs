using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using System.Threading;

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
        private Thread t;

        private void TestFastZipCreate()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();           
            _totalFileCount = 0;
            foreach (var path in Program.dirs)
                _totalFileCount += FolderContentsCount(path);   
            BeginInvoke((Action)(() =>
            {
                LogOutput.AppendText("Создание бэкапа базы данных Parus " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                LogOutput.AppendText(Environment.NewLine + "Общее количество папок: " + Program.dirs.Count);
                LogOutput.AppendText(Environment.NewLine + "Общее количество файлов: " + _totalFileCount);

            }));
            FastZipEvents events = new FastZipEvents();
            ZipStrings.CodePage = 866;
            events.ProcessFile = ProcessFileMethod;
            FastZip fastZip = new FastZip(events);
            fastZip.CreateEmptyDirectories = true;
            string datefolder = "ParusBackup " + DateTime.Now.ToString("dd-MM-yyyy");
            if (!Directory.Exists(Properties.Settings.Default.savepath + "\\" + datefolder))
                Directory.CreateDirectory(Properties.Settings.Default.savepath + "\\" + datefolder);
            foreach (var path in Program.dirs)
            {                               
                try
                {
                    string zipFileName = Properties.Settings.Default.savepath + "\\" + datefolder + "\\" + path.Split('\\').Last() + ".zip";
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
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            BeginInvoke((Action)(() =>
            {
                LogOutput.AppendText(Environment.NewLine + "Архивация базы данных завершена. Затрачено времени:" + elapsedTime);
                TextWriter writer = new StreamWriter(Properties.Settings.Default.savepath + "\\" + datefolder + "\\Log.txt");
                writer.Write(LogOutput.Text);
                writer.Close();
                CancelButton.Text = "Закрыть";
                if (Properties.Settings.Default.bWautoclose) Close();
            }));            
        }

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
            string fileName = args.Name;
            BeginInvoke((Action)(() =>
            {
                ZipProgress.Value = percentCompleted;
            }));
        }

        private void BackupWindow_Activated(object sender, EventArgs e)
        {
            t = new Thread(() => TestFastZipCreate());
            t.Start();
            if (Program.window != null) Program.window.Enabled = false;
        }

        private void BackupWindow_Deactivate(object sender, EventArgs e)
        {
            if (Program.window != null)
            {
                Program.window.Enabled = true;
                Program.window.Activate();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (t != null && t.IsAlive)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите отменить создание бэкапа?", "Отмена операции", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    t.Abort();
                    BeginInvoke((Action)(() =>
                    {
                        LogOutput.AppendText(Environment.NewLine + "Создание бэкапа отменено");
                        CancelButton.Text = "Закрыть";
                        if (Properties.Settings.Default.bWautoclose) Close();
                    }));
                }
            }
            else Close();
        }

        private void AutoClose_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.bWautoclose = AutoClose.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
