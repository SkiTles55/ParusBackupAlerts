using ParusBackupAlerts.Properties;
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
            Text = "ParusBackupHelper",
            ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Выход", Exit)
            }),
            Visible = true
        };
    }

    void Exit(object sender, EventArgs e)
    {
        trayIcon.Visible = false;
        Application.Exit();
    }

    public void ShowMessage(string text, int time) => trayIcon.ShowBalloonTip(time, "Информация", text, ToolTipIcon.Warning);
}