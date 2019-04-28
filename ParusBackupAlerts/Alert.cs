using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParusBackupAlerts
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2, ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;            
        }

        public void SetMessage(string text)
        {
            label1.Text = text;
        }

        private void Alert_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
