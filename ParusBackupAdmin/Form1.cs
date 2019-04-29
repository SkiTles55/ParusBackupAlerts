using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            UpdateSettings();
        }

        public void UpdateSettings()
        {
            DayofWeakBox.SelectedIndex = (int)Program.backupDay;
            BackupHour.Value = Program.BackupHour;
            BackupMinutes.Value = Program.BackupMinute;
            StartCheck.Value = Program.start_check;
            Interval.Value = Program.interval;
            AlertInterval.Value = Program.alert_interval;
            BackupDuration.Value = Program.backup_duration;
            Alert1Box.Clear();
            Alert1Box.AppendText(Program.alert1);
            Alert2Box.Clear();
            Alert2Box.AppendText(Program.alert2);
        }

        public Dictionary<string, string> GetSettings()
        {
            return new Dictionary<string, string>()
            {
                ["backup_hour"] = BackupHour.Value.ToString(),
                ["backup_minute"] = BackupMinutes.Value.ToString(),
                ["backup_day"] = DayofWeakBox.SelectedIndex.ToString(),
                ["alert1"] = Alert1Box.Text,
                ["alert2"] = Alert2Box.Text,
                ["backup_duration"] = BackupDuration.Value.ToString(),
                ["start_check"] = StartCheck.Value.ToString(),
                ["interval"] = Interval.Value.ToString(),
                ["alert_interval"] = AlertInterval.Value.ToString()
            };
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Program.cfgreload.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DayofWeakBox.SelectedIndex != (int)Program.backupDay || BackupHour.Value != Program.BackupHour ||
                BackupMinutes.Value != Program.BackupMinute || StartCheck.Value != Program.start_check ||
                Interval.Value != Program.interval || AlertInterval.Value != Program.alert_interval ||
                BackupDuration.Value != Program.backup_duration || Alert1Box.Text != Program.alert1 || Alert2Box.Text != Program.alert2)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Имеются несохраненные изменения" + Environment.NewLine + "Сохранить настройки перед выходом?", "Сохранение настроек", buttons);
                if (result == DialogResult.Yes)
                {
                    Program.cfgreload.Save();
                }
            }
        }
    }
}
