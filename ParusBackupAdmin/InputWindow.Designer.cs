namespace ParusBackupAdmin
{
    partial class InputWindow
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
            this.dirPath = new System.Windows.Forms.TextBox();
            this.dirOpen = new System.Windows.Forms.Button();
            this.WClose = new System.Windows.Forms.Button();
            this.WOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirPath
            // 
            this.dirPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dirPath.Location = new System.Drawing.Point(17, 15);
            this.dirPath.Name = "dirPath";
            this.dirPath.ReadOnly = true;
            this.dirPath.Size = new System.Drawing.Size(312, 26);
            this.dirPath.TabIndex = 1;
            // 
            // dirOpen
            // 
            this.dirOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dirOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dirOpen.Location = new System.Drawing.Point(336, 15);
            this.dirOpen.Name = "dirOpen";
            this.dirOpen.Size = new System.Drawing.Size(117, 26);
            this.dirOpen.TabIndex = 2;
            this.dirOpen.Text = "Обзор";
            this.dirOpen.UseVisualStyleBackColor = true;
            this.dirOpen.Click += new System.EventHandler(this.dirOpen_Click);
            // 
            // WClose
            // 
            this.WClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WClose.Location = new System.Drawing.Point(292, 66);
            this.WClose.Name = "WClose";
            this.WClose.Size = new System.Drawing.Size(161, 26);
            this.WClose.TabIndex = 3;
            this.WClose.Text = "Отмена";
            this.WClose.UseVisualStyleBackColor = true;
            this.WClose.Click += new System.EventHandler(this.WClose_Click);
            // 
            // WOk
            // 
            this.WOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WOk.Location = new System.Drawing.Point(125, 66);
            this.WOk.Name = "WOk";
            this.WOk.Size = new System.Drawing.Size(161, 26);
            this.WOk.TabIndex = 4;
            this.WOk.Text = "Ок";
            this.WOk.UseVisualStyleBackColor = true;
            this.WOk.Click += new System.EventHandler(this.WOk_Click);
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 109);
            this.Controls.Add(this.WOk);
            this.Controls.Add(this.WClose);
            this.Controls.Add(this.dirOpen);
            this.Controls.Add(this.dirPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InputWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dirPath;
        private System.Windows.Forms.Button dirOpen;
        private System.Windows.Forms.Button WClose;
        private System.Windows.Forms.Button WOk;
    }
}