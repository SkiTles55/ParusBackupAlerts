using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ParusBackupAlerts
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static MyCustomApplicationContext icon;
        public static System.Timers.Timer aTimer;
        static DateTime lastshow;
        static DateTime backupTime;
        static int BackupHour;
        static int BackupMinute;
        static int interval;
        static DayOfWeek backupDay;
        static string alert1;
        static string alert2;
        static int backup_duration;
        static int start_check;
        static int alert_interval;
        static string time1;
        static string time2;

        static readonly string cfgfile = Application.StartupPath + @"\cfg.xml";


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            icon = new MyCustomApplicationContext();
            ConfigReloader cfgreload = new ConfigReloader(Path.GetDirectoryName(cfgfile), Path.GetFileName(cfgfile));
            cfgreload.Run();
            cfgreload.Load();
            aTimer = new System.Timers.Timer(interval * 1000);
            aTimer.Elapsed += Tick;
            aTimer.Enabled = true;
            lastshow = DateTime.Now.AddHours(-1);
            Application.Run(icon);
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

        static void Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (DateTime.Now.DayOfWeek != backupDay) return;
            List<Process> pname = ParusProcesses();
            if (pname.Count == 0) return;
            DateTime backupT = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, backupTime.Hour, backupTime.Minute, backupTime.Second);
            if (backupT < DateTime.Now && (DateTime.Now - backupT).TotalMinutes < backup_duration)
            {
                DestroyProcess(pname);
                Thread t = new Thread(new ThreadStart(delegate { DestroyAlert(); }));
                t.Start();
            }
            else
            {
                TimeSpan elapse = (backupT - DateTime.Now);
                if (elapse.TotalMinutes > 0 && elapse.TotalMinutes < start_check)
                {
                    Thread t = new Thread(new ThreadStart(delegate { ShowAlerts(); }));
                    t.Start();
                }
            }
        }

        static List<Process> ParusProcesses()
        {
            List<Process> pname = new List<Process>();
            foreach (var p in Process.GetProcesses())
                if ((p.ProcessName.ToLower() == "person" || p.ProcessName.ToLower() == "salary" || p.ProcessName.ToLower() == "account") && Process.GetCurrentProcess().SessionId == p.SessionId) pname.Add(p);
            return pname;
        }

        static void DestroyAlert()
        {
            if (Application.OpenForms.OfType<Alert>().Count() > 0)
            {
                foreach (var f in Application.OpenForms.OfType<Alert>())
                    f.Close();
            }
            Alert window = new Alert();
            time2 = backupTime.AddMinutes(backup_duration).ToString("HH:mm");
            if (alert2.Contains("{time}")) alert2 = alert2.Replace("{time}", time2);
            window.SetMessage(alert2);
            window.ShowDialog();
        }

        static void ShowAlerts()
        {
            if (Application.OpenForms.OfType<Alert>().Count() > 0) return;
            if ((DateTime.Now - lastshow).TotalMinutes < alert_interval) return;
            lastshow = DateTime.Now;
            Alert window = new Alert();
            time1 = backupTime.ToString("HH:mm");
            if (alert1.Contains("{time}")) alert1 = alert1.Replace("{time}", time1);
            window.SetMessage(alert1);
            window.ShowDialog();
        }

        static void DestroyProcess(List<Process> pname)
        {
            foreach (var p in pname)
                p.Kill();
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
                if (aTimer != null) aTimer.Interval = interval * 1000;
                backupDay = (DayOfWeek)Convert.ToInt32(root["backup_day"].InnerText);
                backupTime = new DateTime(2002, 02, 25, BackupHour, BackupMinute, 0);
                alert1 = root["alert1"].InnerText;
                alert2 = root["alert2"].InnerText;
                backup_duration = Convert.ToInt32(root["backup_duration"].InnerText);
                start_check = Convert.ToInt32(root["start_check"].InnerText);
                lastshow = DateTime.Now.AddHours(-1);
                alert_interval = Convert.ToInt32(root["alert_interval"].InnerText);
            }
            catch
            {

            }            
        }
    }
}
