using Cassia;
using Newtonsoft.Json;
using ParusBackupAdmin.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ParusBackupAdmin
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static MyCustomApplicationContext icon;
        public static System.Timers.Timer checkTimer;
        public static System.Timers.Timer backupTimer;
        public static Form1 window;
        public static Users uwindow;
        public static BackupWindow bwindow;
        public static List<ITerminalServicesSession> activeusers;
        public static List<string> dirs;
        public static List<string> emails;
        public static DateTime backupTime;
        public static List<DateTime> FinishedBackups;
        public static Dictionary<int, DateTime> Notifications;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            backupTime = new DateTime();
            activeusers = new List<ITerminalServicesSession>();
            FinishedBackups = new List<DateTime>();
            Notifications = new Dictionary<int, DateTime>();
            checkTimer = new System.Timers.Timer(Settings.Default.check_interval * 10000);
            checkTimer.Elapsed += UpdateUsers;
            checkTimer.Enabled = true;
            dirs = JsonConvert.DeserializeObject<List<string>>(Settings.Default.dirs);
            if (dirs == null) dirs = new List<string>();
            emails = JsonConvert.DeserializeObject<List<string>>(Settings.Default.emails);
            if (emails == null) emails = new List<string>();
            icon = new MyCustomApplicationContext();
            backupTimer = new System.Timers.Timer(5000);
            backupTimer.Elapsed += CheckBackupTime;
            backupTimer.Enabled = true;
            Application.Run(icon);
        }

        static void UpdateUsers(object sender, System.Timers.ElapsedEventArgs e)
        {
            activeusers.Clear();
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                foreach (ITerminalServicesSession session in server.GetSessions())
                    if (ParusRunned(session.GetProcesses())) activeusers.Add(session);
            }
            if (uwindow != null)
            {
                try { uwindow.UpdateList(); }
                catch { }
            }
        }

        static void CheckBackupTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            if ((int)DateTime.Now.DayOfWeek != Settings.Default.backupday) return;
            backupTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Settings.Default.backupday, (int)Settings.Default.backuphour, (int)Settings.Default.backupminute, 0);
            if (backupTime < DateTime.Now)
            {
                if ((DateTime.Now - backupTime).Minutes <= Settings.Default.startcheck)
                {
                    foreach (var session in activeusers)
                    {
                        if (!Notifications.ContainsKey(session.SessionId))
                        {
                            SendMessage(session.SessionId, Properties.Settings.Default.alert1box.Replace("{time}", backupTime.ToString("HH:mm")));
                            Notifications.Add(session.SessionId, DateTime.Now);
                        }
                        else
                        {
                            if ((DateTime.Now - Notifications[session.SessionId]).TotalMinutes >= (int)Settings.Default.alert_interval)
                            {
                                SendMessage(session.SessionId, Properties.Settings.Default.alert1box.Replace("{time}", backupTime.ToString("HH:mm")));
                                Notifications[session.SessionId] = DateTime.Now;
                            }
                        }
                    }
                }
            }
            else
            {
                if (Application.OpenForms.OfType<BackupWindow>().Count() > 0 || !FinishedBackups.Contains(backupTime))
                {
                    ITerminalServicesManager manager = new TerminalServicesManager();
                    using (ITerminalServer server = manager.GetLocalServer())
                    {
                        server.Open();
                        foreach (ITerminalServicesSession session in server.GetSessions())
                            KillParusWithNotifiction(session);
                    }
                }
                else
                {
                    if (!Settings.Default.backupauto) return;
                    if (!FinishedBackups.Contains(backupTime))
                    {
                        bwindow = new BackupWindow();
                        bwindow.ShowDialog();
                    }
                }
            }
        }

        static void KillParusWithNotifiction(ITerminalServicesSession session)
        {
            int kills = 0;
            foreach (var l in session.GetProcesses())
                if (l.ProcessName.ToLower() == "salary.exe" || l.ProcessName.ToLower() == "person.exe" || l.ProcessName.ToLower() == "account.exe")
                {
                    l.Kill();
                    kills++;
                }
            //if (kills > 0) session.MessageBox //message here
        }

        public static void StartBackup()
        {
            if (Application.OpenForms.OfType<BackupWindow>().Count() > 0) return;
            bwindow = new BackupWindow();
            bwindow.Show();
        }

        public static bool ParusRunned(IList<ITerminalServicesProcess> list)
        {
            bool result = false;
            foreach (var l in list)
                if (l.ProcessName.ToLower() == "salary.exe" || l.ProcessName.ToLower() == "person.exe" || l.ProcessName.ToLower() == "account.exe") result = true;
            return result;
        }

        public static void SendMessage(int sessionid, string message)
        {
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                try
                {
                    var session = server.GetSession(sessionid);
                    session.MessageBox(message, "Сообщение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка отправки сообщения: " + ex.Message);
                }
            }
        }
    }
}
