using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ParusBackupAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DayofWeakBox.SelectedIndex = (int)Program.backupDay;
            BackupHour.Value = Program.BackupHour;
            BackupMinutes.Value = Program.BackupMinute;
            StartCheck.Value = Program.start_check;
            AlertInterval.Value = Program.alert_interval;
            BackupDuration.Value = Program.backup_duration;
            Alert1Box.Clear();
            Alert1Box.AppendText(Program.alert1);
            Alert2Box.Clear();
            Alert2Box.AppendText(Program.alert2);
        }
    }
}
