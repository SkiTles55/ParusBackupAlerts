namespace ParusBackupAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SavePathSet = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dirRemove = new System.Windows.Forms.Button();
            this.dirEdit = new System.Windows.Forms.Button();
            this.dirAdd = new System.Windows.Forms.Button();
            this.dirsList = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Alert2Box = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Alert1Box = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BackupDuration = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AlertInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartCheck = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BackupMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BackupHour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DayofWeakBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveEmail = new System.Windows.Forms.Button();
            this.EditEmail = new System.Windows.Forms.Button();
            this.AddEmail = new System.Windows.Forms.Button();
            this.EmailList = new System.Windows.Forms.ListBox();
            this.EmailCheckBox = new System.Windows.Forms.CheckBox();
            this.BackupSavePath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupHour)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SavePathSet);
            this.groupBox1.Controls.Add(this.BackupSavePath);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dirRemove);
            this.groupBox1.Controls.Add(this.dirEdit);
            this.groupBox1.Controls.Add(this.dirAdd);
            this.groupBox1.Controls.Add(this.dirsList);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(411, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки бэкапа";
            // 
            // SavePathSet
            // 
            this.SavePathSet.Location = new System.Drawing.Point(272, 262);
            this.SavePathSet.Name = "SavePathSet";
            this.SavePathSet.Size = new System.Drawing.Size(130, 30);
            this.SavePathSet.TabIndex = 31;
            this.SavePathSet.Text = "Обзор";
            this.SavePathSet.UseVisualStyleBackColor = true;
            this.SavePathSet.Click += new System.EventHandler(this.SavePathSet_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(247, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Папка для сохранения бэкапов";
            // 
            // dirRemove
            // 
            this.dirRemove.BackgroundImage = global::ParusBackupAdmin.Properties.Resources.appbar_delete;
            this.dirRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirRemove.Location = new System.Drawing.Point(372, 126);
            this.dirRemove.Name = "dirRemove";
            this.dirRemove.Size = new System.Drawing.Size(30, 30);
            this.dirRemove.TabIndex = 28;
            this.dirRemove.UseVisualStyleBackColor = true;
            this.dirRemove.Click += new System.EventHandler(this.dirRemove_Click);
            // 
            // dirEdit
            // 
            this.dirEdit.BackgroundImage = global::ParusBackupAdmin.Properties.Resources.appbar_edit;
            this.dirEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirEdit.Location = new System.Drawing.Point(372, 92);
            this.dirEdit.Name = "dirEdit";
            this.dirEdit.Size = new System.Drawing.Size(30, 30);
            this.dirEdit.TabIndex = 27;
            this.dirEdit.UseVisualStyleBackColor = true;
            this.dirEdit.Click += new System.EventHandler(this.dirEdit_Click);
            // 
            // dirAdd
            // 
            this.dirAdd.BackgroundImage = global::ParusBackupAdmin.Properties.Resources.appbar_add;
            this.dirAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirAdd.Location = new System.Drawing.Point(372, 60);
            this.dirAdd.Name = "dirAdd";
            this.dirAdd.Size = new System.Drawing.Size(30, 30);
            this.dirAdd.TabIndex = 26;
            this.dirAdd.UseVisualStyleBackColor = true;
            this.dirAdd.Click += new System.EventHandler(this.dirAdd_Click);
            // 
            // dirsList
            // 
            this.dirsList.FormattingEnabled = true;
            this.dirsList.ItemHeight = 20;
            this.dirsList.Location = new System.Drawing.Point(10, 60);
            this.dirsList.Name = "dirsList";
            this.dirsList.Size = new System.Drawing.Size(356, 164);
            this.dirsList.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Список папок для бэкапа";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "секунд";
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(270, 90);
            this.Interval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(46, 26);
            this.Interval.TabIndex = 22;
            this.Interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Интервал проверки";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(10, 564);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(372, 35);
            this.Save_button.TabIndex = 20;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(10, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(370, 39);
            this.label12.TabIndex = 19;
            this.label12.Text = "* Переменная {time} используется для подстановки времени.";
            // 
            // Alert2Box
            // 
            this.Alert2Box.Location = new System.Drawing.Point(10, 399);
            this.Alert2Box.Name = "Alert2Box";
            this.Alert2Box.Size = new System.Drawing.Size(372, 105);
            this.Alert2Box.TabIndex = 18;
            this.Alert2Box.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Оповещение о выполняемом бэкапе*";
            // 
            // Alert1Box
            // 
            this.Alert1Box.Location = new System.Drawing.Point(10, 259);
            this.Alert1Box.Name = "Alert1Box";
            this.Alert1Box.Size = new System.Drawing.Size(372, 105);
            this.Alert1Box.TabIndex = 16;
            this.Alert1Box.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Оповещение о предстоящем бэкапе*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "минут";
            // 
            // BackupDuration
            // 
            this.BackupDuration.Location = new System.Drawing.Point(270, 197);
            this.BackupDuration.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.BackupDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BackupDuration.Name = "BackupDuration";
            this.BackupDuration.Size = new System.Drawing.Size(46, 26);
            this.BackupDuration.TabIndex = 13;
            this.BackupDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Длительность бэкапа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "минут";
            // 
            // AlertInterval
            // 
            this.AlertInterval.Location = new System.Drawing.Point(270, 161);
            this.AlertInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.AlertInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AlertInterval.Name = "AlertInterval";
            this.AlertInterval.Size = new System.Drawing.Size(46, 26);
            this.AlertInterval.TabIndex = 10;
            this.AlertInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Интервал оповещений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "минут";
            // 
            // StartCheck
            // 
            this.StartCheck.Location = new System.Drawing.Point(270, 125);
            this.StartCheck.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.StartCheck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartCheck.Name = "StartCheck";
            this.StartCheck.Size = new System.Drawing.Size(46, 26);
            this.StartCheck.TabIndex = 7;
            this.StartCheck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оповещения за";
            // 
            // BackupMinutes
            // 
            this.BackupMinutes.Location = new System.Drawing.Point(336, 55);
            this.BackupMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.BackupMinutes.Name = "BackupMinutes";
            this.BackupMinutes.Size = new System.Drawing.Size(46, 26);
            this.BackupMinutes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(318, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupHour
            // 
            this.BackupHour.Location = new System.Drawing.Point(270, 55);
            this.BackupHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.BackupHour.Name = "BackupHour";
            this.BackupHour.Size = new System.Drawing.Size(46, 26);
            this.BackupHour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время бэкапа";
            // 
            // DayofWeakBox
            // 
            this.DayofWeakBox.FormattingEnabled = true;
            this.DayofWeakBox.Items.AddRange(new object[] {
            "Воскресенье",
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.DayofWeakBox.Location = new System.Drawing.Point(199, 19);
            this.DayofWeakBox.Name = "DayofWeakBox";
            this.DayofWeakBox.Size = new System.Drawing.Size(183, 28);
            this.DayofWeakBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "День недели";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DayofWeakBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BackupHour);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BackupMinutes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.StartCheck);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Interval);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.AlertInterval);
            this.groupBox2.Controls.Add(this.Save_button);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Alert2Box);
            this.groupBox2.Controls.Add(this.BackupDuration);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Alert1Box);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 619);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки помощника";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveEmail);
            this.groupBox3.Controls.Add(this.EmailCheckBox);
            this.groupBox3.Controls.Add(this.EditEmail);
            this.groupBox3.Controls.Add(this.EmailList);
            this.groupBox3.Controls.Add(this.AddEmail);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(412, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки оповещений";
            // 
            // RemoveEmail
            // 
            this.RemoveEmail.BackgroundImage = global::ParusBackupAdmin.Properties.Resources.appbar_delete;
            this.RemoveEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveEmail.Location = new System.Drawing.Point(371, 130);
            this.RemoveEmail.Name = "RemoveEmail";
            this.RemoveEmail.Size = new System.Drawing.Size(30, 30);
            this.RemoveEmail.TabIndex = 35;
            this.RemoveEmail.UseVisualStyleBackColor = true;
            this.RemoveEmail.Click += new System.EventHandler(this.RemoveEmail_Click);
            // 
            // EditEmail
            // 
            this.EditEmail.BackgroundImage = global::ParusBackupAdmin.Properties.Resources.appbar_edit;
            this.EditEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditEmail.Location = new System.Drawing.Point(371, 96);
            this.EditEmail.Name = "EditEmail";
            this.EditEmail.Size = new System.Drawing.Size(30, 30);
            this.EditEmail.TabIndex = 34;
            this.EditEmail.UseVisualStyleBackColor = true;
            this.EditEmail.Click += new System.EventHandler(this.EditEmail_Click);
            // 
            // AddEmail
            // 
            this.AddEmail.BackgroundImage = global::ParusBackupAdmin.Properties.Resources.appbar_add;
            this.AddEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddEmail.Location = new System.Drawing.Point(371, 64);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(30, 30);
            this.AddEmail.TabIndex = 33;
            this.AddEmail.UseVisualStyleBackColor = true;
            this.AddEmail.Click += new System.EventHandler(this.AddEmail_Click);
            // 
            // EmailList
            // 
            this.EmailList.FormattingEnabled = true;
            this.EmailList.ItemHeight = 20;
            this.EmailList.Location = new System.Drawing.Point(9, 64);
            this.EmailList.Name = "EmailList";
            this.EmailList.Size = new System.Drawing.Size(356, 164);
            this.EmailList.TabIndex = 32;
            // 
            // EmailCheckBox
            // 
            this.EmailCheckBox.AutoSize = true;
            this.EmailCheckBox.Checked = global::ParusBackupAdmin.Properties.Settings.Default.emailnotify;
            this.EmailCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EmailCheckBox.Location = new System.Drawing.Point(9, 28);
            this.EmailCheckBox.Name = "EmailCheckBox";
            this.EmailCheckBox.Size = new System.Drawing.Size(263, 24);
            this.EmailCheckBox.TabIndex = 0;
            this.EmailCheckBox.Text = "Отправка оповещений на email";
            this.EmailCheckBox.UseVisualStyleBackColor = true;
            this.EmailCheckBox.CheckedChanged += new System.EventHandler(this.EmailCheckBox_CheckedChanged);
            // 
            // BackupSavePath
            // 
            this.BackupSavePath.Location = new System.Drawing.Point(10, 264);
            this.BackupSavePath.Name = "BackupSavePath";
            this.BackupSavePath.ReadOnly = true;
            this.BackupSavePath.Size = new System.Drawing.Size(255, 26);
            this.BackupSavePath.TabIndex = 30;
            this.BackupSavePath.Text = global::ParusBackupAdmin.Properties.Settings.Default.savepath;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 647);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парус Бэкап Помощник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupHour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DayofWeakBox;
        private System.Windows.Forms.NumericUpDown BackupHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BackupMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown StartCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AlertInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown BackupDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Alert1Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox Alert2Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Interval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button dirAdd;
        private System.Windows.Forms.ListBox dirsList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button dirEdit;
        private System.Windows.Forms.Button dirRemove;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BackupSavePath;
        private System.Windows.Forms.Button SavePathSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox EmailCheckBox;
        private System.Windows.Forms.Button RemoveEmail;
        private System.Windows.Forms.Button EditEmail;
        private System.Windows.Forms.ListBox EmailList;
        private System.Windows.Forms.Button AddEmail;
    }
}

