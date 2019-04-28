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
        static Form1 window;
        public static ConfigReloader cfgreload;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cfgreload = new ConfigReloader(Path.GetDirectoryName(cfgfile), Path.GetFileName(cfgfile));
            cfgreload.Run();
            cfgreload.Load();
            window = new Form1();
            Application.Run(window);
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

        /*
        public static IList<ITerminalServicesSession> LoggedUsers()
        {
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                return server.GetSessions();
            }
        }
        */

        public static List<UserInfo> LoggedUsers()
        {
            List<UserInfo> users = new List<UserInfo>();
            ITerminalServicesManager manager = new TerminalServicesManager();
            using (ITerminalServer server = manager.GetLocalServer())
            {
                server.Open();
                foreach (var s in server.GetSessions())
                {
                    UserInfo current = new UserInfo
                    {
                        Name = s.UserName,
                        Enabled = true,
                        HelperRunned = false,
                        sessionId = s.SessionId
                    };
                    foreach (var proc in s.GetProcesses())
                        if (proc.ProcessName.ToLower() == "notepad.exe") current.HelperRunned = true; //change later
                    users.Add(current);
                }
            }
            return users;
        }
    }
}
