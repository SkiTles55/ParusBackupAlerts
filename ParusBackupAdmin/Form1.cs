using Newtonsoft.Json;
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
            RefreshDirList();
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

        private void dirAdd_Click(object sender, EventArgs e)
        {
            InputWindow input = new InputWindow()
            {
                Owner = this,
                HelpText = "Добавление папки для бэкапа",
                Title = "Добавление папки для бэкапа"
            };
            input.ShowDialog();
            RefreshDirList();
            Properties.Settings.Default.dirs = JsonConvert.SerializeObject(Program.dirs);
            Properties.Settings.Default.Save();
        }

        private void RefreshDirList()
        {
            dirsList.Items.Clear();
            foreach (var dir in Program.dirs)
                dirsList.Items.Add(dir);
        }

        private void dirEdit_Click(object sender, EventArgs e)
        {
            if (dirsList.SelectedItem == null) return;
            Program.dirs.Remove(dirsList.SelectedItem.ToString());
            InputWindow input = new InputWindow()
            {
                Owner = this,
                HelpText = "Редактирование папки",
                Title = "Редактирование папки",
                Path = dirsList.SelectedItem.ToString()
            };
            input.ShowDialog();
            RefreshDirList();
            Properties.Settings.Default.dirs = JsonConvert.SerializeObject(Program.dirs);
            Properties.Settings.Default.Save();
        }

        private void dirRemove_Click(object sender, EventArgs e)
        {
            if (dirsList.SelectedItem == null) return;
            DialogResult dialogResult = MessageBox.Show(dirsList.SelectedItem.ToString(), "Вы точно хотите удалить эту папку из списка?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.dirs.Remove(dirsList.SelectedItem.ToString());
                RefreshDirList();
                Properties.Settings.Default.dirs = JsonConvert.SerializeObject(Program.dirs);
                Properties.Settings.Default.Save();
            }
        }

        private void SavePathSet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.Description = "Выберите папку для сохранения бэкапов";
            if (!String.IsNullOrEmpty(BackupSavePath.Text))
                folderDlg.SelectedPath = BackupSavePath.Text;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackupSavePath.Text = folderDlg.SelectedPath;
                Properties.Settings.Default.savepath = folderDlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
    }
}
