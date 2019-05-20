namespace ParusBackupAdmin
{
    partial class BackupWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupWindow));
            this.ZipProgress = new System.Windows.Forms.ProgressBar();
            this.LogOutput = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AutoClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ZipProgress
            // 
            this.ZipProgress.Location = new System.Drawing.Point(12, 306);
            this.ZipProgress.Name = "ZipProgress";
            this.ZipProgress.Size = new System.Drawing.Size(775, 41);
            this.ZipProgress.TabIndex = 0;
            // 
            // LogOutput
            // 
            this.LogOutput.Location = new System.Drawing.Point(13, 13);
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.ReadOnly = true;
            this.LogOutput.Size = new System.Drawing.Size(774, 199);
            this.LogOutput.TabIndex = 1;
            this.LogOutput.Text = "";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(619, 353);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(168, 33);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AutoClose
            // 
            this.AutoClose.AutoSize = true;
            this.AutoClose.Checked = global::ParusBackupAdmin.Properties.Settings.Default.bWautoclose;
            this.AutoClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoClose.Location = new System.Drawing.Point(13, 358);
            this.AutoClose.Name = "AutoClose";
            this.AutoClose.Size = new System.Drawing.Size(406, 24);
            this.AutoClose.TabIndex = 3;
            this.AutoClose.Text = "Автоматически закрыть это окно по завершению";
            this.AutoClose.UseVisualStyleBackColor = true;
            this.AutoClose.CheckedChanged += new System.EventHandler(this.AutoClose_CheckedChanged);
            // 
            // BackupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.ControlBox = false;
            this.Controls.Add(this.AutoClose);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.ZipProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupWindow";
            this.Text = "Бэкап базы данных Parus";
            this.Activated += new System.EventHandler(this.BackupWindow_Activated);
            this.Deactivate += new System.EventHandler(this.BackupWindow_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ZipProgress;
        private System.Windows.Forms.RichTextBox LogOutput;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox AutoClose;
    }
}