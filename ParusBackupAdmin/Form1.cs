using Newtonsoft.Json;
using System;
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
            RefreshEmailList();
        }

        public void UpdateSettings()
        {
            DayofWeakBox.SelectedIndex = Properties.Settings.Default.backupday;
            BackupHour.Value = Properties.Settings.Default.backuphour;
            BackupMinutes.Value = Properties.Settings.Default.backupminute;
            StartCheck.Value = Properties.Settings.Default.startcheck;
            Interval.Value = Properties.Settings.Default.interval;
            AlertInterval.Value = Properties.Settings.Default.alert_interval;
            Alert1Box.Clear();
            Alert1Box.AppendText(Properties.Settings.Default.alert1box);
            Alert2Box.Clear();
            Alert2Box.AppendText(Properties.Settings.Default.alert2box);
            ePass.Text = Properties.Settings.Default.emailpass;
            eLogin.Text = Properties.Settings.Default.emaillogin;
            EmailCheckBox.Checked = Properties.Settings.Default.emailnotify;
            BackupAutoRun.Checked = Properties.Settings.Default.backupauto;
            BackupSavePath.Text = Properties.Settings.Default.savepath;
        }

        private void RefreshDirList()
        {
            dirsList.Items.Clear();
            foreach (var dir in Program.dirs)
                dirsList.Items.Add(dir);
        }

        private void RefreshEmailList()
        {
            EmailList.Items.Clear();
            foreach (var email in Program.emails)
                EmailList.Items.Add(email);
        }

        private void DirAdd_Click(object sender, EventArgs e)
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

        private void AddEmail_Click(object sender, EventArgs e)
        {
            EmailInput input = new EmailInput()
            {
                Owner = this,
                HelpText = "Добавление email адреса",
                Text = "Добавление email адреса"
            };
            input.ShowDialog();
            RefreshEmailList();
            Properties.Settings.Default.emails = JsonConvert.SerializeObject(Program.emails);
            Properties.Settings.Default.Save();
        }

        private void DirEdit_Click(object sender, EventArgs e)
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

        private void EditEmail_Click(object sender, EventArgs e)
        {
            if (EmailList.SelectedItem == null) return;
            Program.emails.Remove(EmailList.SelectedItem.ToString());
            EmailInput input = new EmailInput()
            {
                Owner = this,
                HelpText = "Редактирование email адреса",
                Text = "Редактирование email адреса",
                Path = EmailList.SelectedItem.ToString()
            };
            input.ShowDialog();
            RefreshEmailList();
            Properties.Settings.Default.emails = JsonConvert.SerializeObject(Program.emails);
            Properties.Settings.Default.Save();
        }

        private void RemoveEmail_Click(object sender, EventArgs e)
        {
            if (EmailList.SelectedItem == null) return;
            DialogResult dialogResult = MessageBox.Show(EmailList.SelectedItem.ToString(), "Вы точно хотите удалить этот email из списка?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.emails.Remove(EmailList.SelectedItem.ToString());
                RefreshEmailList();
                Properties.Settings.Default.emails = JsonConvert.SerializeObject(Program.emails);
                Properties.Settings.Default.Save();
            }
        }

        private void DirRemove_Click(object sender, EventArgs e)
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
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                Description = "Выберите папку для сохранения бэкапов"
            };
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

        private void EmailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.emailnotify = EmailCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ESave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(eLogin.Text) || String.IsNullOrEmpty(ePass.Text)) return;
            if (!eLogin.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Указан неправильный адрес электронной почты!");
                return;
            }
            if (!String.IsNullOrEmpty(Properties.Settings.Default.emaillogin) || !String.IsNullOrEmpty(Properties.Settings.Default.emailpass))
            {
                DialogResult dialogResult = MessageBox.Show("Заменить учетную запись на " + eLogin.Text + "?", "Изменение учетных данных", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) return;
            }
            Properties.Settings.Default.emaillogin = eLogin.Text;
            Properties.Settings.Default.emailpass = ePass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Учетная запись почты сохранена!");
        }

        private void BackupAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.backupauto = BackupAutoRun.Checked;
            Properties.Settings.Default.Save();
        }

        private void DayofWeakBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.backupday = DayofWeakBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void BackupHour_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.backuphour = BackupHour.Value;
            Properties.Settings.Default.Save();
            Program.UpdateBackupTime();
        }

        private void BackupMinutes_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.backupminute = BackupMinutes.Value;
            Properties.Settings.Default.Save();
            Program.UpdateBackupTime();
        }

        private void Interval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.interval = Interval.Value;
            Properties.Settings.Default.Save();
        }

        private void StartCheck_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.startcheck = StartCheck.Value;
            Properties.Settings.Default.Save();
        }

        private void AlertInterval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.alert_interval = AlertInterval.Value;
            Properties.Settings.Default.Save();
        }

        private void Alert1Box_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.alert1box = Alert1Box.Text;
            Properties.Settings.Default.Save();
        }

        private void Alert2Box_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.alert2box = Alert2Box.Text;
            Properties.Settings.Default.Save();
        }
    }
}
