using System;
using System.Windows.Forms;

namespace ParusBackupAdmin
{
    public partial class EmailInput : Form
    {
        public string HelpText { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public EmailInput()
        {
            InitializeComponent();
        }

        private void EmailInput_Load(object sender, EventArgs e)
        {
            Text = Title;
            Email.Text = Path;
        }

        private void EClose_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Path)) Program.emails.Add(Path);
            Close();
        }

        private void EOk_Click(object sender, EventArgs e)
        {
            if (Program.emails.Contains(Email.Text))
            {
                MessageBox.Show("Этот email уже присутствует в списке");
                return;
            }
            else
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(Email.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Неверный адрес электронной почты!" + Environment.NewLine + ex.Message);
                    return;
                }
                Program.emails.Add(Email.Text);
                Close();
            }
        }
    }
}
