
namespace ScreenSleepDisabler
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.DisableScreenSaverEntry = new System.Windows.Forms.CheckBox();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemAutoStart = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
      this.trayMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // DisableScreenSaverEntry
      // 
      this.DisableScreenSaverEntry.AutoSize = true;
      this.DisableScreenSaverEntry.Location = new System.Drawing.Point(25, 25);
      this.DisableScreenSaverEntry.Name = "DisableScreenSaverEntry";
      this.DisableScreenSaverEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.DisableScreenSaverEntry.Size = new System.Drawing.Size(212, 19);
      this.DisableScreenSaverEntry.TabIndex = 0;
      this.DisableScreenSaverEntry.Text = "Disable Screen Saver/Monitor Sleep";
      this.DisableScreenSaverEntry.UseVisualStyleBackColor = true;
      this.DisableScreenSaverEntry.CheckedChanged += new System.EventHandler(this.DisableScreenSaverEntry_CheckedChanged);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.trayMenuStrip;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "Screen Sleep Disabler";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      // 
      // trayMenuStrip
      // 
      this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemAutoStart,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
      this.trayMenuStrip.Name = "trayMenuStrip";
      this.trayMenuStrip.Size = new System.Drawing.Size(248, 76);
      this.trayMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.trayMenuStrip_ItemClicked);
      // 
      // toolStripMenuItemShow
      // 
      this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
      this.toolStripMenuItemShow.Size = new System.Drawing.Size(247, 22);
      this.toolStripMenuItemShow.Tag = "Show";
      this.toolStripMenuItemShow.Text = "Show";
      // 
      // toolStripMenuItemAutoStart
      // 
      this.toolStripMenuItemAutoStart.Name = "toolStripMenuItemAutoStart";
      this.toolStripMenuItemAutoStart.Size = new System.Drawing.Size(247, 22);
      this.toolStripMenuItemAutoStart.Tag = "AutoStart";
      this.toolStripMenuItemAutoStart.Text = "Enable Auto-Start With Windows";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
      // 
      // toolStripMenuItemExit
      // 
      this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
      this.toolStripMenuItemExit.Size = new System.Drawing.Size(247, 22);
      this.toolStripMenuItemExit.Tag = "Exit";
      this.toolStripMenuItemExit.Text = "Exit";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(330, 108);
      this.Controls.Add(this.DisableScreenSaverEntry);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Screen Sleep Disabler";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Resize += new System.EventHandler(this.MainForm_Resize);
      this.trayMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox DisableScreenSaverEntry;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAutoStart;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  }
}

