using System;
using System.Windows.Forms;

namespace ParusBackupAdmin
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            interval_check_p.Value = Properties.Settings.Default.check_interval;
        }

        public void UpdateList() => Invoke(new Action(RefreshRows));

        void RefreshRows()
        {
            UsersListView.Rows.Clear();
            foreach (var user in Program.activeusers)
                UsersListView.Rows.Add(user.SessionId, user.UserName);
        }

        private void Users_Load(object sender, EventArgs e) => Invoke(new Action(RefreshRows));

        private void interval_check_p_ValueChanged(object sender, EventArgs e)
        {
            Program.checkTimer.Interval = (double)interval_check_p.Value * 10000;
            Properties.Settings.Default.check_interval = (int)interval_check_p.Value;
            Properties.Settings.Default.Save();
        }

        private void UsersListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Index == 2 && e.RowIndex >= 0)
            {
                //Program.SendMessage((int)UsersListView.Rows[e.RowIndex].Cells[0].Value, "test");
                // need meesage window
            }
        }
    }
}
