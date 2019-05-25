namespace ParusBackupAdmin
{
    partial class EmailInput
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
            this.EOk = new System.Windows.Forms.Button();
            this.EClose = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EOk
            // 
            this.EOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EOk.Location = new System.Drawing.Point(125, 67);
            this.EOk.Name = "EOk";
            this.EOk.Size = new System.Drawing.Size(161, 26);
            this.EOk.TabIndex = 8;
            this.EOk.Text = "Ок";
            this.EOk.UseVisualStyleBackColor = true;
            this.EOk.Click += new System.EventHandler(this.EOk_Click);
            // 
            // EClose
            // 
            this.EClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EClose.Location = new System.Drawing.Point(292, 67);
            this.EClose.Name = "EClose";
            this.EClose.Size = new System.Drawing.Size(161, 26);
            this.EClose.TabIndex = 7;
            this.EClose.Text = "Отмена";
            this.EClose.UseVisualStyleBackColor = true;
            this.EClose.Click += new System.EventHandler(this.EClose_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(17, 16);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(436, 26);
            this.Email.TabIndex = 5;
            // 
            // EmailInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 109);
            this.Controls.Add(this.EOk);
            this.Controls.Add(this.EClose);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmailInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailInput";
            this.Load += new System.EventHandler(this.EmailInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EOk;
        private System.Windows.Forms.Button EClose;
        private System.Windows.Forms.TextBox Email;
    }
}