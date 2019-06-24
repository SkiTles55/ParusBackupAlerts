namespace ParusBackupAdmin
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.UsersListView = new System.Windows.Forms.DataGridView();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helper_runned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.interval_check_p = new System.Windows.Forms.NumericUpDown();
            this.HelperAutoRun = new System.Windows.Forms.CheckBox();
            this.HelperClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_check_p)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersListView
            // 
            this.UsersListView.AllowUserToAddRows = false;
            this.UsersListView.AllowUserToDeleteRows = false;
            this.UsersListView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UsersListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sID,
            this.sName,
            this.helper_runned});
            this.UsersListView.Location = new System.Drawing.Point(12, 12);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.RowHeadersVisible = false;
            this.UsersListView.Size = new System.Drawing.Size(483, 330);
            this.UsersListView.TabIndex = 0;
            // 
            // sID
            // 
            this.sID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sID.HeaderText = "ID";
            this.sID.Name = "sID";
            // 
            // sName
            // 
            this.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sName.HeaderText = "Пользователь";
            this.sName.Name = "sName";
            // 
            // helper_runned
            // 
            this.helper_runned.HeaderText = "Помощник";
            this.helper_runned.Name = "helper_runned";
            this.helper_runned.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Интервал проверок (мин.)";
            // 
            // interval_check_p
            // 
            this.interval_check_p.Location = new System.Drawing.Point(375, 363);
            this.interval_check_p.Name = "interval_check_p";
            this.interval_check_p.Size = new System.Drawing.Size(120, 20);
            this.interval_check_p.TabIndex = 2;
            this.interval_check_p.ValueChanged += new System.EventHandler(this.interval_check_p_ValueChanged);
            // 
            // HelperAutoRun
            // 
            this.HelperAutoRun.Checked = global::ParusBackupAdmin.Properties.Settings.Default.autohelper_checkbox;
            this.HelperAutoRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HelperAutoRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelperAutoRun.Location = new System.Drawing.Point(12, 392);
            this.HelperAutoRun.Name = "HelperAutoRun";
            this.HelperAutoRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelperAutoRun.Size = new System.Drawing.Size(485, 24);
            this.HelperAutoRun.TabIndex = 3;
            this.HelperAutoRun.Text = "Автоматический запуск помощника";
            this.HelperAutoRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HelperAutoRun.UseVisualStyleBackColor = true;
            this.HelperAutoRun.CheckedChanged += new System.EventHandler(this.HelperAutoRun_CheckedChanged);
            this.HelperAutoRun.CheckStateChanged += new System.EventHandler(this.HelperAutoRun_CheckStateChanged);
            // 
            // HelperClose
            // 
            this.HelperClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelperClose.Location = new System.Drawing.Point(12, 433);
            this.HelperClose.Name = "HelperClose";
            this.HelperClose.Size = new System.Drawing.Size(483, 36);
            this.HelperClose.TabIndex = 4;
            this.HelperClose.Text = "Закрыть помощника у всех пользователей";
            this.HelperClose.UseVisualStyleBackColor = true;
            this.HelperClose.Click += new System.EventHandler(this.HelperClose_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 479);
            this.Controls.Add(this.HelperClose);
            this.Controls.Add(this.HelperAutoRun);
            this.Controls.Add(this.interval_check_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пользователей";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_check_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown interval_check_p;
        private System.Windows.Forms.CheckBox HelperAutoRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn helper_runned;
        private System.Windows.Forms.Button HelperClose;
    }
}