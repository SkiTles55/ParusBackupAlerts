using System;
using System.Linq;
using System.Windows.Forms;

namespace ParusBackupAdmin
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            interval_check_p.Value = Properties.Settings.Default.check_interval;
            HelperAutoRun.Checked = Properties.Settings.Default.autohelper_checkbox;
        }

        public void UpdateList() => Invoke(new Action(RefreshRows));

        void RefreshRows()
        {
            UsersListView.Rows.Clear();
            foreach (var user in Program.activeusers)
                UsersListView.Rows.Add(user.session.SessionId, user.session.UserName, user.HelperStarted ? "Запущен" : "Не запущен");
        }

        private void Users_Load(object sender, EventArgs e) => Invoke(new Action(RefreshRows));

        private void interval_check_p_ValueChanged(object sender, EventArgs e)
        {
            Program.checkTimer.Interval = (double)interval_check_p.Value * 10000;
            Properties.Settings.Default.check_interval = (int)interval_check_p.Value;
            Properties.Settings.Default.Save();
        }

        private void HelperAutoRun_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autohelper_checkbox = HelperAutoRun.Checked;
            Properties.Settings.Default.Save();
        }

        private void HelperClose_Click(object sender, EventArgs e)
        {
            Program.KillParus();
            Program.activeusers.Clear();
            RefreshRows();
        }

        private void HelperAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autohelper_checkbox = HelperAutoRun.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
