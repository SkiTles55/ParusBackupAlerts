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
            this.msg_button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.interval_check_p = new System.Windows.Forms.NumericUpDown();
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
            this.msg_button});
            this.UsersListView.Location = new System.Drawing.Point(12, 12);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.RowHeadersVisible = false;
            this.UsersListView.Size = new System.Drawing.Size(483, 330);
            this.UsersListView.TabIndex = 0;
            this.UsersListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersListView_CellContentClick);
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
            // msg_button
            // 
            this.msg_button.HeaderText = "Отправить сообщение";
            this.msg_button.Name = "msg_button";
            this.msg_button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.msg_button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.msg_button.Text = "Написать";
            this.msg_button.UseColumnTextForButtonValue = true;
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
            this.interval_check_p.ValueChanged += new System.EventHandler(this.Interval_check_p_ValueChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 398);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewButtonColumn msg_button;
    }
}