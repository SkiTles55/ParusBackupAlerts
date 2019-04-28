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
                new MenuItem("О программе", About),
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

    void About(object sender, EventArgs e)
    {
        MessageBox.Show("Автозакрытие Паруса для проведения бэкапов с переодическими напоминаниями." + Environment.NewLine + "ИКБ№1 имени Далматова Д.М." + Environment.NewLine + "Худяков Д.С. (2019)", "О программе");
    }

    public void ShowMessage(string text, int time) => trayIcon.ShowBalloonTip(time, "Информация", text, ToolTipIcon.Warning);
}