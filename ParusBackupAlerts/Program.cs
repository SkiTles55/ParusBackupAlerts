using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParusBackupAlerts
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static MyCustomApplicationContext icon;
        public static Timer tmr;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tmr = new Timer
            {
                Interval = 60000
            };
            tmr.Tick += new EventHandler(Tmr_Tick);
            tmr.Start();
            icon = new MyCustomApplicationContext();
            Application.Run(icon);
        }

        static void Tmr_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == Properties.Settings.Default.backuptime.Hour)
            {
                //check for apps and return if closed
                Process[] pname = Process.GetProcessesByName("notepad"); // rename later
                if (pname.Length == 0) return;
                if (DateTime.Now.Minute == Properties.Settings.Default.backuptime.Minute)
                {
                    //close parus apps
                }
                else if (DateTime.Now.Minute <= Properties.Settings.Default.backuptime.Minute)
                {
                    //show alerts
                    DateTime backupT = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Properties.Settings.Default.backuptime.Hour, Properties.Settings.Default.backuptime.Minute, 0);
                    switch ((backupT - DateTime.Now).Minutes)
                    {
                        case 10:
                            ShowAlert(DateTime.Now.Minute);
                            break;
                        case 20:
                            ShowAlert(DateTime.Now.Minute);
                            break;
                        case 30:
                            ShowAlert(DateTime.Now.Minute);
                            break;
                    }
                }
            }
        }

        static void ShowAlert(int min)
        {
            Alert window = new Alert();
            window.Show();
        }
    }
}
