using Cassia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ParusBackupAdmin
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static MyCustomApplicationContext icon;
        static System.Timers.Timer checkTimer;
        static readonly string cfgfile = Application.StartupPath + @"\cfg.xml";
        public static int BackupHour;
        public static int BackupMinute;
        public static int interval;
        public static DayOfWeek backupDay;
        public static string alert1;
        public static string alert2;
        public static int backup_duration;
        public static int start_check;
        public static int alert_interval;
        public static Form1 window;
        public static Users uwindow;
        public static ConfigReloader cfgreload;
        public static List<ITerminalServicesSession> activeusers;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            activeusers = new List<ITerminalServicesSession>();
            checkTimer = new System.Timers.Timer(5000);
            checkTimer.Elapsed += UpdateUsers;
            checkTimer.Enabled = true;
            icon = new MyCustomApplicationContext();
            cfgreload = new ConfigReloader(Path.GetDirectoryName(cfgfile), Path.GetFileName(cfgfile));
            cfgreload.Run();
            cfgreload.Load();
            Application.Run(icon);
        }

        public class ConfigReloader
        {
            FileSystemWatcher fsw;
            public ConfigReloader(string path, string filter)
            {
                fsw = new FileSystemWatcher(path, filter);
                fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            }
            public void Run()
            {
                fsw.EnableRaisingEvents = true;
            }
            public void Load()
            {
                try
                {
                    if (!FileIsReady(cfgfile)) return;
                    LoadCFG();
                    fsw.EnableRaisingEvents = false;
                }

                finally
                {
                    fsw.EnableRaisingEvents = true;
                }
            }
            public void Save()
            {
                try
                {
                    if (!FileIsReady(cfgfile)) return;
                    SaveCFG();
                    fsw.EnableRaisingEvents = false;
                }

                finally
                {
                    MessageBox.Show("Настройки успешно сохранены!", "Настройки");
                    LoadCFG();
                    fsw.EnableRaisingEvents = true;
                }
            }
            void fsw_Changed(object sender, FileSystemEventArgs e)
            {
                try
                {
                    if (!FileIsReady(cfgfile)) return;
                    LoadCFG();
                    fsw.EnableRaisingEvents = false;
                }

                finally
                {
                    fsw.EnableRaisingEvents = true;
                }
            }
            bool FileIsReady(string path)
            {
                try
                {
                    using (var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        return true;
                    }
                }
                catch (IOException)
                {
                    return false;
                }
            }
        }

        static void LoadCFG()
        {
            try
            {
                var doc = new XmlDocument();
                doc.Load(cfgfile);
                var root = doc.DocumentElement;
                BackupHour = Convert.ToInt32(root["backup_hour"].InnerText);
                BackupMinute = Convert.ToInt32(root["backup_minute"].InnerText);
                interval = Convert.ToInt32(root["interval"].InnerText);
                backupDay = (DayOfWeek)Convert.ToInt32(root["backup_day"].InnerText);
                alert1 = root["alert1"].InnerText;
                alert2 = root["alert2"].InnerText;
                backup_duration = Convert.ToInt32(root["backup_duration"].InnerText);
                start_check = Convert.ToInt32(root["start_check"].InnerText);
                alert_interval = Convert.ToInt32(root["alert_interval"].InnerText);
                if (window != null) window.UpdateSettings();
            }
            catch
            {

            }
        }

        static void SaveCFG()
        {
            try
            {
                Dictionary<string, string> Settings = window.GetSettings();
                var doc = new XmlDocument();
                var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(xmlDeclaration);
                var root = doc.CreateElement("config");
                var child1 = doc.CreateElement("backup_hour");
                child1.InnerText = Settings["backup_hour"];
                root.AppendChild(child1);
                var child2 = doc.CreateElement("backup_minute");
                child2.InnerText = Settings["backup_minute"];
                root.AppendChild(child2);
                var child3 = doc.CreateElement("backup_day");
                child3.InnerText = Settings["backup_day"];
                root.AppendChild(child3);
                var child4 = doc.CreateElement("alert1");
                child4.InnerText = Settings["alert1"];
                root.AppendChild(child4);
                var child5 = doc.CreateElement("alert2");
                child5.InnerText = Settings["alert2"];
                root.AppendChild(child5);
                var child6 = doc.CreateElement("backup_duration");
                child6.InnerText = Settings["backup_duration"];
                root.AppendChild(child6);
                var child7 = doc.CreateElement("start_check");
                child7.InnerText = Settings["start_check"];
                root.AppendChild(child7);
                var child8 = doc.CreateElement("interval");
                child8.InnerText = Settings["interval"];
                root.AppendChild(child8);
                var child9 = doc.CreateElement("alert_interval");
                child9.InnerText = Settings["alert_interval"];
                root.AppendChild(child9);
                doc.AppendChild(root);
                doc.Save(cfgfile);
            }
            catch { }
        }

        static void UpdateUsers(object sender, System.Timers.ElapsedEventArgs e)
        {
            activeusers.Clear();
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                foreach (var session in server.GetSessions())
                {
                    var processes = session.GetProcesses();
                    if (ParusRunned(processes))
                    {
                        activeusers.Add(session);
                        //check for helper later
                    }
                }
            }
            if (uwindow != null) uwindow.UpdateList();
        }

        static bool ParusRunned(IList<ITerminalServicesProcess> list)
        {
            bool result = false;
            foreach (var l in list)
                if (l.ProcessName.ToLower() == "salary.exe" || l.ProcessName.ToLower() == "person.exe" || l.ProcessName.ToLower() == "account.exe") result = true;
            return result;
        }

        static bool HelperRunned(IList<ITerminalServicesProcess> list)
        {
            bool result = false;
            foreach (var l in list)
                if (l.ProcessName.ToLower() == "parusbackupalerts.exe") result = true;
            return result;
        }
    }
}
