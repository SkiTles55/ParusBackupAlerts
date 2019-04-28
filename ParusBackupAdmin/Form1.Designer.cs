﻿namespace ParusBackupAdmin
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
            this.label11 = new System.Windows.Forms.Label();
            this.Alert2Box = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupHour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Save_button);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Alert2Box);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Alert1Box);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BackupDuration);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AlertInterval);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.StartCheck);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BackupMinutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BackupHour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DayofWeakBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // Alert1Box
            // 
            this.Alert1Box.Location = new System.Drawing.Point(10, 232);
            this.Alert1Box.Name = "Alert1Box";
            this.Alert1Box.Size = new System.Drawing.Size(370, 105);
            this.Alert1Box.TabIndex = 16;
            this.Alert1Box.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Оповещение о предстоящем бэкапе*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "минут";
            // 
            // BackupDuration
            // 
            this.BackupDuration.Location = new System.Drawing.Point(270, 170);
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
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Длительность бэкапа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "минут";
            // 
            // AlertInterval
            // 
            this.AlertInterval.Location = new System.Drawing.Point(270, 134);
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
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Интервал оповещений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "минут";
            // 
            // StartCheck
            // 
            this.StartCheck.Location = new System.Drawing.Point(270, 98);
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
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оповещения за";
            // 
            // BackupMinutes
            // 
            this.BackupMinutes.Location = new System.Drawing.Point(336, 64);
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
            this.label3.Location = new System.Drawing.Point(318, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupHour
            // 
            this.BackupHour.Location = new System.Drawing.Point(270, 64);
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
            this.label2.Location = new System.Drawing.Point(6, 66);
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
            this.DayofWeakBox.Location = new System.Drawing.Point(199, 28);
            this.DayofWeakBox.Name = "DayofWeakBox";
            this.DayofWeakBox.Size = new System.Drawing.Size(183, 28);
            this.DayofWeakBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "День недели";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Оповещение о выполняемом бэкапе*";
            // 
            // Alert2Box
            // 
            this.Alert2Box.Location = new System.Drawing.Point(10, 372);
            this.Alert2Box.Name = "Alert2Box";
            this.Alert2Box.Size = new System.Drawing.Size(370, 105);
            this.Alert2Box.TabIndex = 18;
            this.Alert2Box.Text = "";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(10, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(370, 39);
            this.label12.TabIndex = 19;
            this.label12.Text = "* Переменная {time} используется для подстановки времени.";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(13, 537);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(367, 35);
            this.Save_button.TabIndex = 20;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Парус Бэкап Помощник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupHour)).EndInit();
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
    }
}

