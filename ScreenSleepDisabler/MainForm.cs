
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenSleepDisabler
{
  public partial class MainForm : Form
  {
    //Startup registry key and value
    private const string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
    private const string StartupValue = "ScreenSleepDisabler";
    private const string EnableAutoStartText = "Enable Auto-Start With Windows";
    private const string DisableAutoStartText = "Disable Auto-Start With Windows";

    [Flags]
    public enum EXECUTION_STATE : uint
    {
      ES_AWAYMODE_REQUIRED = 0x00000040,
      ES_CONTINUOUS = 0x80000000,
      ES_DISPLAY_REQUIRED = 0x00000002,
      ES_SYSTEM_REQUIRED = 0x00000001
      // Legacy flag, should not be used.
      // ES_USER_PRESENT = 0x00000004
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

    public MainForm()
    {
      InitializeComponent();
      this.DisableScreenSaverEntry.Checked = true;
      this.toolStripMenuItemAutoStart.Text = GetStartup() ? DisableAutoStartText : EnableAutoStartText;
    }

    private void prevent_screensaver(bool preventSleep)
    {
      if (preventSleep)
      {
        SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
      }
      else
      {
        SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
      }
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      DisableScreenSaverEntry.Checked = true;
    }

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      prevent_screensaver(false);
    }

    private void DisableScreenSaverEntry_CheckedChanged(object sender, EventArgs e)
    {
      prevent_screensaver(DisableScreenSaverEntry.Checked);
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      this.ShowInTaskbar = true;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.ShowInTaskbar = false;
      this.WindowState = FormWindowState.Minimized;
      e.Cancel = true;
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Minimized)
      {
        this.ShowInTaskbar = false;
        this.WindowState = FormWindowState.Minimized;
      }
    }

    private void trayMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      switch (e.ClickedItem.Tag.ToString().ToUpper())
      {
        case "EXIT":
          prevent_screensaver(false);
          notifyIcon1.Visible = false;
          this.Close();
          Application.Exit();
          break;
        case "SHOW":
          this.WindowState = FormWindowState.Normal;
          this.ShowInTaskbar = true;
          break;
        case "AUTOSTART":
          if (e.ClickedItem.Text.Equals(EnableAutoStartText, StringComparison.OrdinalIgnoreCase))
          {
            SetStartup(true);
            this.toolStripMenuItemAutoStart.Text = DisableAutoStartText;
          }
          else
          {
            SetStartup(false);
            this.toolStripMenuItemAutoStart.Text = EnableAutoStartText;
          }
          break;
        default:
          break;
      }
    }

    private bool GetStartup()
    {
      var key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
      var value = key.GetValue(StartupValue, string.Empty).ToString();
      return value.Equals(Application.ExecutablePath, StringComparison.OrdinalIgnoreCase);
    }

    private void SetStartup(bool autoStart)
    {
      //Set the application to run at startup
      var key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
      if (autoStart)
      {
        key.SetValue(StartupValue, Application.ExecutablePath);
      }
      else
      {
        key.DeleteValue(StartupValue);
      }
    }
  }
}
