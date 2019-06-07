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
            this.CancelB = new System.Windows.Forms.Button();
            this.AutoClose = new System.Windows.Forms.CheckBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.LogOutput.Size = new System.Drawing.Size(774, 267);
            this.LogOutput.TabIndex = 1;
            this.LogOutput.Text = "";
            // 
            // CancelB
            // 
            this.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelB.Location = new System.Drawing.Point(619, 353);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(168, 33);
            this.CancelB.TabIndex = 2;
            this.CancelB.Text = "Отмена";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelButton_Click);
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
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressLabel.Location = new System.Drawing.Point(12, 283);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 20);
            this.ProgressLabel.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // BackupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.AutoClose);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.ZipProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupWindow";
            this.Text = "Бэкап базы данных Parus";
            this.Activated += new System.EventHandler(this.BackupWindow_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ZipProgress;
        private System.Windows.Forms.RichTextBox LogOutput;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.CheckBox AutoClose;
        private System.Windows.Forms.Label ProgressLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}