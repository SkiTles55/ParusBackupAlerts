using System;
using System.Windows.Forms;

namespace ParusBackupAdmin
{
    public partial class InputWindow : Form
    {
        public string HelpText { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public InputWindow()
        {
            InitializeComponent();            
        }

        private void WClose_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Path)) Program.dirs.Add(Path);
            Close();
        }

        private void dirOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.Description = HelpText;
            if (!String.IsNullOrEmpty(Path))
                folderDlg.SelectedPath = Path;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
                dirPath.Text = folderDlg.SelectedPath;
        }

        private void InputWindow_Load(object sender, EventArgs e)
        {
            Text = Title;
            dirPath.Text = Path;
        }

        private void WOk_Click(object sender, EventArgs e)
        {
            if (Program.dirs.Contains(dirPath.Text))
            {
                MessageBox.Show("Папка уже присутствует в списке");
                return;
            }
            else
            {
                Program.dirs.Add(dirPath.Text);
                Close();
            }
        }
    }
}
