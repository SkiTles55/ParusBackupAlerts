using System;
using System.Windows.Forms;

namespace ParusBackupAdmin
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        public void UpdateList() => Invoke(new Action(RefreshRows));

        void RefreshRows()
        {
            UsersListView.Rows.Clear();
            foreach (var session in Program.activeusers)
                UsersListView.Rows.Add(session.SessionId, session.UserName);
        }

        private void Users_Load(object sender, EventArgs e) => Invoke(new Action(RefreshRows));
    }
}
