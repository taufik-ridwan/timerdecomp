// Decompiled with JetBrains decompiler
// Type: CountdownApp.frmCountdown
// Assembly: CountdownApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FC7E3B5E-A665-400F-94A5-48F1DBB775B0
// Assembly location: C:\Users\Pika\Desktop\WaktuSimulasiAppv1.1.exe

using CountdownApp.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CountdownApp
{
  [DesignerGenerated]
  public class frmCountdown : Form
  {
    private IContainer components;
    private int CountdownDuration;

    public frmCountdown()
    {
      this.Closing += new CancelEventHandler(this.frmCountdown_Closing);
      this.Load += new EventHandler(this.frmCountdown_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCountdown));
      this.tmrTime = new Timer(this.components);
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.lblTime = new Label();
      this.lblHours = new Label();
      this.lblMinutes = new Label();
      this.lblSeconds = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.lblTimeServerUrl = new Label();
      this.PictureBox4 = new PictureBox();
      this.Label3 = new Label();
      this.Label4 = new Label();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      this.SuspendLayout();
      this.tmrTime.Interval = 1000;
      this.Label13.BackColor = Color.LightGray;
      this.Label13.Location = new Point(14, 153);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(281, 1);
      this.Label13.TabIndex = 49;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.Location = new Point(54, 158);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(201, 19);
      this.Label14.TabIndex = 50;
      this.Label14.Text = "Time on Target Server GMT+7";
      this.lblTime.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTime.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblTime.Location = new Point(57, 190);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new Size(195, 49);
      this.lblTime.TabIndex = 51;
      this.lblTime.Text = "00:00:00";
      this.lblTime.TextAlign = ContentAlignment.BottomCenter;
      this.lblHours.AutoSize = true;
      this.lblHours.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblHours.Location = new Point(5, 45);
      this.lblHours.Name = "lblHours";
      this.lblHours.Size = new Size(73, 59);
      this.lblHours.TabIndex = 52;
      this.lblHours.Tag = (object) "Hours";
      this.lblHours.Text = "00";
      this.lblMinutes.AutoSize = true;
      this.lblMinutes.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMinutes.Location = new Point(102, 45);
      this.lblMinutes.Name = "lblMinutes";
      this.lblMinutes.Size = new Size(73, 59);
      this.lblMinutes.TabIndex = 53;
      this.lblMinutes.Tag = (object) "Hours";
      this.lblMinutes.Text = "00";
      this.lblSeconds.AutoSize = true;
      this.lblSeconds.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblSeconds.Location = new Point(199, 45);
      this.lblSeconds.Name = "lblSeconds";
      this.lblSeconds.Size = new Size(73, 59);
      this.lblSeconds.TabIndex = 54;
      this.lblSeconds.Tag = (object) "Hours";
      this.lblSeconds.Text = "00";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(18, 100);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(47, 19);
      this.Label1.TabIndex = 55;
      this.Label1.Text = "Hours";
      this.Label2.AutoSize = true;
      this.Label2.BackColor = Color.White;
      this.Label2.Font = new Font("Calibri", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label2.Location = new Point(5, 5);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(144, 33);
      this.Label2.TabIndex = 56;
      this.Label2.Text = "Countdown";
      this.lblTimeServerUrl.AutoSize = true;
      this.lblTimeServerUrl.BackColor = Color.FromArgb(201, 218, 248);
      this.lblTimeServerUrl.Location = new Point(69, 179);
      this.lblTimeServerUrl.Name = "lblTimeServerUrl";
      this.lblTimeServerUrl.Size = new Size(171, 15);
      this.lblTimeServerUrl.TabIndex = 63;
      this.lblTimeServerUrl.Tag = (object) "";
      this.lblTimeServerUrl.Text = "https://internsip.kemkes.go.id";
      this.PictureBox4.Image = (Image) CountdownApp.My.Resources.Resources._480px_Blue_circle;
      this.PictureBox4.Location = new Point(175, 21);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(120, 120);
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 64;
      this.PictureBox4.TabStop = false;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(107, 100);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(62, 19);
      this.Label3.TabIndex = 65;
      this.Label3.Text = "Minutes";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(204, 100);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(62, 19);
      this.Label4.TabIndex = 66;
      this.Label4.Text = "Seconds";
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(308, 254);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lblTimeServerUrl);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lblSeconds);
      this.Controls.Add((Control) this.lblMinutes);
      this.Controls.Add((Control) this.lblHours);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.lblTime);
      this.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmCountdown);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Countdown App";
      ((ISupportInitialize) this.PictureBox4).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Timer tmrTime
    {
      get => this._tmrTime;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrTime_Tick);
        Timer tmrTime1 = this._tmrTime;
        if (tmrTime1 != null)
          tmrTime1.Tick -= eventHandler;
        this._tmrTime = value;
        Timer tmrTime2 = this._tmrTime;
        if (tmrTime2 == null)
          return;
        tmrTime2.Tick += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTime")]
    internal virtual Label lblTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblHours")]
    internal virtual Label lblHours { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblMinutes")]
    internal virtual Label lblMinutes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblSeconds")]
    internal virtual Label lblSeconds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTimeServerUrl")]
    internal virtual Label lblTimeServerUrl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox4")]
    internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void frmCountdown_Closing(object sender, CancelEventArgs e)
    {
      if (MessageBox.Show("Do you want to close the countdown and go back to the previous screen?", "Countdown App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        MyProject.Forms.frmMain.Show();
      else
        e.Cancel = true;
    }

    private void frmCountdown_Load(object sender, EventArgs e)
    {
      this.CountdownDuration = mdlSharedFunctions.CountdownTimeInSeconds;
      this.lblHours.Text = Strings.Format((object) (this.CountdownDuration / 3600), "00");
      this.lblMinutes.Text = Strings.Format((object) (this.CountdownDuration % 3600 / 60), "00");
      this.lblSeconds.Text = Strings.Format((object) (this.CountdownDuration % 60), "00");
      this.lblTime.Text = Strings.Format((object) mdlSharedFunctions.CurrentTime, "HH:mm:ss");
      this.lblTimeServerUrl.Text = mdlSystemParameters.TimeServerUrl;
      this.lblTimeServerUrl.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - this.lblTimeServerUrl.Width) / 2.0)));
      this.TopMost = mdlSharedFunctions.MakeTopmostWin;
      if (mdlSharedFunctions.MakeTransparent)
        this.Opacity = 0.35;
      this.Left = checked (Screen.PrimaryScreen.Bounds.Width - this.Width);
      this.Top = checked (Screen.PrimaryScreen.Bounds.Height - this.Height + 60);
      this.tmrTime.Enabled = true;
    }

    private void tmrTime_Tick(object sender, EventArgs e)
    {
      try
      {
        this.lblTime.Text = Strings.Format((object) mdlSharedFunctions.CurrentTime, "HH:mm:ss");
        if (this.CountdownDuration > 0)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.CountdownDuration) - 1);
          local = num;
          this.lblHours.Text = Strings.Format((object) (this.CountdownDuration / 3600), "00");
          this.lblMinutes.Text = Strings.Format((object) (this.CountdownDuration % 3600 / 60), "00");
          this.lblSeconds.Text = Strings.Format((object) (this.CountdownDuration % 60), "00");
          if (this.CountdownDuration == 0)
          {
            if (mdlSharedFunctions.AllowAudibleNotifications)
              Console.Beep(500, 1000);
            if (mdlSharedFunctions.RefreshBrowser)
              mdlSharedFunctions.RefreshBrowserWindow();
          }
          else if (this.CountdownDuration < 10 & mdlSharedFunctions.AllowAudibleNotifications)
            Console.Beep(500, 200);
        }
        if (this.CountdownDuration < 30 && this.CountdownDuration > 0)
        {
          if (this.lblSeconds.ForeColor == Color.Red)
            this.lblSeconds.ForeColor = Color.Black;
          else
            this.lblSeconds.ForeColor = Color.Red;
        }
        else
          this.lblSeconds.ForeColor = Color.Black;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        mdlSharedFunctions.DumpErrLog(this.Name + ".tmrTime_Tick", exception.Message);
        int num = (int) MessageBox.Show("Countdown App has encountered the following error.\r\n" + exception.Message, "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }
}
