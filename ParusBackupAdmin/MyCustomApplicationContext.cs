﻿using ParusBackupAdmin;
using ParusBackupAdmin.Properties;
using System;
using System.Windows.Forms;

public class MyCustomApplicationContext : ApplicationContext
{
    private NotifyIcon trayIcon;

    public MyCustomApplicationContext()
    {
        trayIcon = new NotifyIcon()
        {
            Icon = Resources.AppIcon,
            Text = "ParusBackupAdmin",
            ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Запуск бэкапа", BackupStart),
                new MenuItem("Пользователи", UserWindow),
                new MenuItem("Настройки", SettingsWindow),
                new MenuItem("О программе", About),
                new MenuItem("Выход", Exit)
            }),
            Visible = true
        };
        trayIcon.MouseDoubleClick += TrayIconDoubleClickHandler;
    }

    private void TrayIconDoubleClickHandler(object sender, MouseEventArgs e)
    {
        Program.window = new ParusBackupAdmin.SettingsWindow();
        Program.window.Show();
    }

    void UserWindow(object sender, EventArgs e)
    {
        Program.uwindow = new Users();
        Program.uwindow.Show();
    }

    void BackupStart(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Уверены что хотите запустить бэкап?", "Подтвердите действие", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK) Program.StartBackup();
    }

    void SettingsWindow(object sender, EventArgs e)
    {
        Program.window = new ParusBackupAdmin.SettingsWindow();
        Program.window.Show();
    }

    void Exit(object sender, EventArgs e)
    {
        trayIcon.Visible = false;
        Application.Exit();
    }

    void About(object sender, EventArgs e)
    {
        MessageBox.Show("Автозакрытие Паруса для проведения бэкапов с переодическими напоминаниями." + Environment.NewLine + "ИКБ№1 имени Далматова Д.М." + Environment.NewLine + "Худяков Д.С. (2019)", "О программе");
    }

    public void ShowMessage(string text, int time) => trayIcon.ShowBalloonTip(time, "Информация", text, ToolTipIcon.Warning);
}
