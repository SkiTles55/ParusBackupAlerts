using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigReloader cfgreload = new ConfigReloader(Path.GetDirectoryName(cfgfile), Path.GetFileName(cfgfile));
            cfgreload.Run();
            cfgreload.Load();
            Application.Run(new Form1());
        }

        class ConfigReloader
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
            }
            catch
            {

            }
        }
    }
}
