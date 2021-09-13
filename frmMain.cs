// Decompiled with JetBrains decompiler
// Type: CountdownApp.frmMain
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
  public class frmMain : Form
  {
    private IContainer components;
    private bool FlagInitialTimeSynced;

    public frmMain()
    {
      this.Closing += new CancelEventHandler(this.frmMain_Closing);
      this.Load += new EventHandler(this.frmMain_Load);
      this.FlagInitialTimeSynced = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
      this.lblMainTitle = new Label();
      this.lblHeaderBackground = new Label();
      this.lblSubTitle = new Label();
      this.btnStart = new Button();
      this.btnOnOff = new Button();
      this.PictureBox2 = new PictureBox();
      this.picLogo = new PictureBox();
      this.txtHours = new TextBox();
      this.txtMinutes = new TextBox();
      this.PictureBox3 = new PictureBox();
      this.txtSeconds = new TextBox();
      this.PictureBox4 = new PictureBox();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.Label11 = new Label();
      this.Label10 = new Label();
      this.Label9 = new Label();
      this.lblTime = new Label();
      this.Label14 = new Label();
      this.Label13 = new Label();
      this.Label8 = new Label();
      this.chkMakeTransparent = new CheckBox();
      this.Label15 = new Label();
      this.chkMakeTopmostWin = new CheckBox();
      this.chkRefreshBrowser = new CheckBox();
      this.Label12 = new Label();
      this.btnRereadTime = new Button();
      this.btnAddSeconds = new Button();
      this.Label16 = new Label();
      this.Label4 = new Label();
      this.Label17 = new Label();
      this.btnSubtractSeconds = new Button();
      this.Label19 = new Label();
      this.Label20 = new Label();
      this.Label18 = new Label();
      this.lblTimeServerUrl = new Label();
      this.tmrTime = new Timer(this.components);
      this.chkAudibleNotifications = new CheckBox();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.picLogo).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      this.SuspendLayout();
      this.lblMainTitle.AutoSize = true;
      this.lblMainTitle.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblMainTitle.Font = new Font("Calibri", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMainTitle.ForeColor = Color.WhiteSmoke;
      this.lblMainTitle.Location = new Point(5, 9);
      this.lblMainTitle.Name = "lblMainTitle";
      this.lblMainTitle.Size = new Size(194, 33);
      this.lblMainTitle.TabIndex = 3;
      this.lblMainTitle.Text = "Countdown App";
      this.lblHeaderBackground.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblHeaderBackground.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblHeaderBackground.ForeColor = Color.White;
      this.lblHeaderBackground.Location = new Point(0, 0);
      this.lblHeaderBackground.Name = "lblHeaderBackground";
      this.lblHeaderBackground.Size = new Size(520, 80);
      this.lblHeaderBackground.TabIndex = 5;
      this.lblSubTitle.AutoSize = true;
      this.lblSubTitle.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblSubTitle.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSubTitle.ForeColor = Color.WhiteSmoke;
      this.lblSubTitle.Location = new Point(5, 40);
      this.lblSubTitle.Name = "lblSubTitle";
      this.lblSubTitle.Size = new Size(360, 23);
      this.lblSubTitle.TabIndex = 6;
      this.lblSubTitle.Text = "Karena semua orang butuh kepastian (waktu)";
      this.btnStart.BackColor = Color.FromArgb(17, 85, 204);
      this.btnStart.FlatAppearance.BorderColor = Color.FromArgb(17, 85, 204);
      this.btnStart.FlatStyle = FlatStyle.Flat;
      this.btnStart.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnStart.ForeColor = Color.White;
      this.btnStart.Location = new Point(395, 93);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new Size(97, 25);
      this.btnStart.TabIndex = 27;
      this.btnStart.Tag = (object) "Start Countdown";
      this.btnStart.Text = "Mulai Hitung";
      this.btnStart.UseVisualStyleBackColor = false;
      this.btnOnOff.FlatAppearance.BorderColor = Color.LightGray;
      this.btnOnOff.FlatStyle = FlatStyle.Flat;
      this.btnOnOff.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnOnOff.Location = new Point(330, 93);
      this.btnOnOff.Name = "btnOnOff";
      this.btnOnOff.Size = new Size(56, 25);
      this.btnOnOff.TabIndex = 26;
      this.btnOnOff.Text = "On";
      this.btnOnOff.UseVisualStyleBackColor = true;
      this.PictureBox2.Image = (Image) CountdownApp.My.Resources.Resources.Rounded_Rectangle;
      this.PictureBox2.Location = new Point(157, 145);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(97, 92);
      this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox2.TabIndex = 30;
      this.PictureBox2.TabStop = false;
      this.picLogo.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.picLogo.Image = (Image) CountdownApp.My.Resources.Resources.Logoblue;
      this.picLogo.Location = new Point(390, 12);
      this.picLogo.Name = "picLogo";
      this.picLogo.Size = new Size(102, 56);
      this.picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
      this.picLogo.TabIndex = 4;
      this.picLogo.TabStop = false;
      this.txtHours.BackColor = Color.FromArgb(201, 218, 248);
      this.txtHours.BorderStyle = BorderStyle.None;
      this.txtHours.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtHours.Location = new Point(176, 162);
      this.txtHours.Name = "txtHours";
      this.txtHours.Size = new Size(59, 59);
      this.txtHours.TabIndex = 31;
      this.txtHours.Text = "00";
      this.txtHours.TextAlign = HorizontalAlignment.Center;
      this.txtMinutes.BackColor = Color.FromArgb(201, 218, 248);
      this.txtMinutes.BorderStyle = BorderStyle.None;
      this.txtMinutes.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtMinutes.Location = new Point(294, 162);
      this.txtMinutes.Name = "txtMinutes";
      this.txtMinutes.Size = new Size(59, 59);
      this.txtMinutes.TabIndex = 33;
      this.txtMinutes.Text = "00";
      this.txtMinutes.TextAlign = HorizontalAlignment.Center;
      this.PictureBox3.Image = (Image) CountdownApp.My.Resources.Resources.Rounded_Rectangle;
      this.PictureBox3.Location = new Point(275, 145);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(97, 92);
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 32;
      this.PictureBox3.TabStop = false;
      this.txtSeconds.BackColor = Color.FromArgb(201, 218, 248);
      this.txtSeconds.BorderStyle = BorderStyle.None;
      this.txtSeconds.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSeconds.Location = new Point(414, 162);
      this.txtSeconds.Name = "txtSeconds";
      this.txtSeconds.Size = new Size(59, 59);
      this.txtSeconds.TabIndex = 35;
      this.txtSeconds.Text = "00";
      this.txtSeconds.TextAlign = HorizontalAlignment.Center;
      this.PictureBox4.Image = (Image) CountdownApp.My.Resources.Resources.Rounded_Rectangle;
      this.PictureBox4.Location = new Point(395, 145);
      this.PictureBox4.Name = "PictureBox4";
      this.PictureBox4.Size = new Size(97, 92);
      this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox4.TabIndex = 34;
      this.PictureBox4.TabStop = false;
      this.Label5.AutoSize = true;
      this.Label5.Location = new Point(5, 98);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(214, 15);
      this.Label5.TabIndex = 36;
      this.Label5.Tag = (object) "Automatic countdown? (click button)";
      this.Label5.Text = "Hitung Otomatis? (Klik Tombol on/off)";
      this.Label6.Location = new Point(5, 186);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(116, 51);
      this.Label6.TabIndex = 38;
      this.Label6.Tag = (object) "(time reference to countdown)";
      this.Label6.Text = "(Waktu target Refresh untuk Countdown)";
      this.Label7.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(5, 145);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(128, 41);
      this.Label7.TabIndex = 37;
      this.Label7.Tag = (object) "Countdown to what time?";
      this.Label7.Text = "Countdown Ke Jam Berapa?";
      this.Label11.AutoSize = true;
      this.Label11.Location = new Point(418, 240);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(51, 15);
      this.Label11.TabIndex = 41;
      this.Label11.Tag = (object) "Seconds";
      this.Label11.Text = "Detik (s)";
      this.Label10.AutoSize = true;
      this.Label10.Location = new Point(288, 240);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(70, 15);
      this.Label10.TabIndex = 40;
      this.Label10.Tag = (object) "Minutes";
      this.Label10.Text = "Menit (mts)";
      this.Label9.AutoSize = true;
      this.Label9.Location = new Point(173, 240);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(65, 15);
      this.Label9.TabIndex = 39;
      this.Label9.Tag = (object) "Hours";
      this.Label9.Text = "Jam (hour)";
      this.lblTime.Font = new Font("Calibri", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTime.ForeColor = Color.Gray;
      this.lblTime.Location = new Point(277, 322);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new Size(195, 56);
      this.lblTime.TabIndex = 50;
      this.lblTime.Text = "00:00:00";
      this.lblTime.TextAlign = ContentAlignment.BottomCenter;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.Location = new Point(274, 301);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(201, 19);
      this.Label14.TabIndex = 49;
      this.Label14.Text = "Time on Target Server GMT+7";
      this.Label13.BackColor = Color.LightGray;
      this.Label13.Location = new Point(5, 300);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(241, 1);
      this.Label13.TabIndex = 48;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(5, 274);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(199, 15);
      this.Label8.TabIndex = 47;
      this.Label8.Tag = (object) "What Features You Want to turn on?";
      this.Label8.Text = "Fitur apa yang mau kamu nyalakan?";
      this.chkMakeTransparent.AutoSize = true;
      this.chkMakeTransparent.Location = new Point(11, 359);
      this.chkMakeTransparent.Name = "chkMakeTransparent";
      this.chkMakeTransparent.Size = new Size(143, 19);
      this.chkMakeTransparent.TabIndex = 45;
      this.chkMakeTransparent.Tag = (object) "Make Window Transparent";
      this.chkMakeTransparent.Text = "Windows transparan";
      this.chkMakeTransparent.UseVisualStyleBackColor = true;
      this.Label15.BackColor = Color.LightGray;
      this.Label15.Location = new Point(5, 262);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(492, 1);
      this.Label15.TabIndex = 46;
      this.chkMakeTopmostWin.AutoSize = true;
      this.chkMakeTopmostWin.Location = new Point(11, 333);
      this.chkMakeTopmostWin.Name = "chkMakeTopmostWin";
      this.chkMakeTopmostWin.Size = new Size(183, 19);
      this.chkMakeTopmostWin.TabIndex = 44;
      this.chkMakeTopmostWin.Tag = (object) "Show Timer Window on Top";
      this.chkMakeTopmostWin.Text = "Tampilkan di Depan browser";
      this.chkMakeTopmostWin.UseVisualStyleBackColor = true;
      this.chkRefreshBrowser.AutoSize = true;
      this.chkRefreshBrowser.Location = new Point(11, 307);
      this.chkRefreshBrowser.Name = "chkRefreshBrowser";
      this.chkRefreshBrowser.Size = new Size(180, 19);
      this.chkRefreshBrowser.TabIndex = 43;
      this.chkRefreshBrowser.Tag = (object) "Countdown to 0 -> Refresh";
      this.chkRefreshBrowser.Text = "Bila Countdown 0 -> Refresh";
      this.chkRefreshBrowser.UseVisualStyleBackColor = true;
      this.Label12.BackColor = Color.LightGray;
      this.Label12.Location = new Point(5, 411);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(492, 1);
      this.Label12.TabIndex = 51;
      this.btnRereadTime.BackColor = Color.FromArgb(17, 85, 204);
      this.btnRereadTime.FlatAppearance.BorderColor = Color.FromArgb(17, 85, 204);
      this.btnRereadTime.FlatAppearance.BorderSize = 0;
      this.btnRereadTime.FlatStyle = FlatStyle.Flat;
      this.btnRereadTime.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnRereadTime.ForeColor = Color.White;
      this.btnRereadTime.Location = new Point(323, 274);
      this.btnRereadTime.Name = "btnRereadTime";
      this.btnRereadTime.Size = new Size(102, 20);
      this.btnRereadTime.TabIndex = 52;
      this.btnRereadTime.Text = "Re-read Time";
      this.btnRereadTime.UseVisualStyleBackColor = false;
      this.btnAddSeconds.BackColor = Color.FromArgb(201, 218, 248);
      this.btnAddSeconds.FlatAppearance.BorderColor = Color.Silver;
      this.btnAddSeconds.FlatAppearance.BorderSize = 0;
      this.btnAddSeconds.FlatStyle = FlatStyle.Flat;
      this.btnAddSeconds.Font = new Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAddSeconds.Location = new Point(452, 386);
      this.btnAddSeconds.Name = "btnAddSeconds";
      this.btnAddSeconds.Size = new Size(17, 18);
      this.btnAddSeconds.TabIndex = 53;
      this.btnAddSeconds.Text = "+";
      this.btnAddSeconds.TextAlign = ContentAlignment.TopCenter;
      this.btnAddSeconds.UseVisualStyleBackColor = false;
      this.Label16.AutoSize = true;
      this.Label16.Location = new Point(252, 388);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(198, 15);
      this.Label16.TabIndex = 54;
      this.Label16.Tag = (object) "";
      this.Label16.Text = "Click + / - to adjust seconds (detik):";
      this.Label4.BackColor = Color.LightGray;
      this.Label4.Location = new Point(5, 129);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(492, 1);
      this.Label4.TabIndex = 55;
      this.Label17.BackColor = Color.LightGray;
      this.Label17.Location = new Point(245, 262);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(1, 149);
      this.Label17.TabIndex = 56;
      this.btnSubtractSeconds.BackColor = Color.FromArgb(201, 218, 248);
      this.btnSubtractSeconds.FlatAppearance.BorderColor = Color.Silver;
      this.btnSubtractSeconds.FlatAppearance.BorderSize = 0;
      this.btnSubtractSeconds.FlatStyle = FlatStyle.Flat;
      this.btnSubtractSeconds.Font = new Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSubtractSeconds.Location = new Point(475, 386);
      this.btnSubtractSeconds.Name = "btnSubtractSeconds";
      this.btnSubtractSeconds.Size = new Size(17, 18);
      this.btnSubtractSeconds.TabIndex = 57;
      this.btnSubtractSeconds.Text = "-";
      this.btnSubtractSeconds.TextAlign = ContentAlignment.TopCenter;
      this.btnSubtractSeconds.UseVisualStyleBackColor = false;
      this.Label19.BackColor = Color.LightGray;
      this.Label19.Location = new Point(5, 443);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(492, 1);
      this.Label19.TabIndex = 59;
      this.Label20.AutoSize = true;
      this.Label20.Location = new Point(5, 420);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(173, 15);
      this.Label20.TabIndex = 60;
      this.Label20.Tag = (object) "";
      this.Label20.Text = "Target Server URL to Read time:";
      this.Label18.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.Location = new Point(5, 449);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(470, 28);
      this.Label18.TabIndex = 61;
      this.Label18.Tag = (object) "";
      this.Label18.Text = "Program ini adalah sebuah kekayaan intelektual yang dilindungi oleh undang undang HAKI. Supportlah / bantulah kami dengan membeli lisensi resmi agar kami bisa terus menolong TS.";
      this.lblTimeServerUrl.AutoSize = true;
      this.lblTimeServerUrl.BackColor = Color.FromArgb(201, 218, 248);
      this.lblTimeServerUrl.Location = new Point(185, 420);
      this.lblTimeServerUrl.Name = "lblTimeServerUrl";
      this.lblTimeServerUrl.Size = new Size(171, 15);
      this.lblTimeServerUrl.TabIndex = 62;
      this.lblTimeServerUrl.Tag = (object) "";
      this.lblTimeServerUrl.Text = "https://internsip.kemkes.go.id";
      this.tmrTime.Interval = 1000;
      this.chkAudibleNotifications.AutoSize = true;
      this.chkAudibleNotifications.Location = new Point(11, 385);
      this.chkAudibleNotifications.Name = "chkAudibleNotifications";
      this.chkAudibleNotifications.Size = new Size(176, 19);
      this.chkAudibleNotifications.TabIndex = 63;
      this.chkAudibleNotifications.Tag = (object) "";
      this.chkAudibleNotifications.Text = "Allow audible notifications.";
      this.chkAudibleNotifications.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(504, 481);
      this.Controls.Add((Control) this.chkAudibleNotifications);
      this.Controls.Add((Control) this.lblTimeServerUrl);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.Label20);
      this.Controls.Add((Control) this.Label19);
      this.Controls.Add((Control) this.btnSubtractSeconds);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.lblMainTitle);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.btnAddSeconds);
      this.Controls.Add((Control) this.btnRereadTime);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.chkMakeTransparent);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.chkMakeTopmostWin);
      this.Controls.Add((Control) this.chkRefreshBrowser);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.txtSeconds);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.txtMinutes);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.txtHours);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.btnStart);
      this.Controls.Add((Control) this.btnOnOff);
      this.Controls.Add((Control) this.lblSubTitle);
      this.Controls.Add((Control) this.picLogo);
      this.Controls.Add((Control) this.lblHeaderBackground);
      this.Controls.Add((Control) this.lblTime);
      this.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (frmMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Countdown App";
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.picLogo).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("picLogo")]
    internal virtual PictureBox picLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblMainTitle")]
    internal virtual Label lblMainTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblHeaderBackground")]
    internal virtual Label lblHeaderBackground { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblSubTitle")]
    internal virtual Label lblSubTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnStart
    {
      get => this._btnStart;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnStart_Click);
        Button btnStart1 = this._btnStart;
        if (btnStart1 != null)
          btnStart1.Click -= eventHandler;
        this._btnStart = value;
        Button btnStart2 = this._btnStart;
        if (btnStart2 == null)
          return;
        btnStart2.Click += eventHandler;
      }
    }

    internal virtual Button btnOnOff
    {
      get => this._btnOnOff;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOnOff_Click);
        Button btnOnOff1 = this._btnOnOff;
        if (btnOnOff1 != null)
          btnOnOff1.Click -= eventHandler;
        this._btnOnOff = value;
        Button btnOnOff2 = this._btnOnOff;
        if (btnOnOff2 == null)
          return;
        btnOnOff2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PictureBox2")]
    internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtHours
    {
      get => this._txtHours;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtHours_GotFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtHours_LostFocus);
        TextBox txtHours1 = this._txtHours;
        if (txtHours1 != null)
        {
          txtHours1.GotFocus -= eventHandler1;
          txtHours1.LostFocus -= eventHandler2;
        }
        this._txtHours = value;
        TextBox txtHours2 = this._txtHours;
        if (txtHours2 == null)
          return;
        txtHours2.GotFocus += eventHandler1;
        txtHours2.LostFocus += eventHandler2;
      }
    }

    internal virtual TextBox txtMinutes
    {
      get => this._txtMinutes;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtMinutes_GotFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtMinutes_LostFocus);
        TextBox txtMinutes1 = this._txtMinutes;
        if (txtMinutes1 != null)
        {
          txtMinutes1.GotFocus -= eventHandler1;
          txtMinutes1.LostFocus -= eventHandler2;
        }
        this._txtMinutes = value;
        TextBox txtMinutes2 = this._txtMinutes;
        if (txtMinutes2 == null)
          return;
        txtMinutes2.GotFocus += eventHandler1;
        txtMinutes2.LostFocus += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("PictureBox3")]
    internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtSeconds
    {
      get => this._txtSeconds;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtSeconds_GotFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtSeconds_LostFocus);
        TextBox txtSeconds1 = this._txtSeconds;
        if (txtSeconds1 != null)
        {
          txtSeconds1.GotFocus -= eventHandler1;
          txtSeconds1.LostFocus -= eventHandler2;
        }
        this._txtSeconds = value;
        TextBox txtSeconds2 = this._txtSeconds;
        if (txtSeconds2 == null)
          return;
        txtSeconds2.GotFocus += eventHandler1;
        txtSeconds2.LostFocus += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("PictureBox4")]
    internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTime")]
    internal virtual Label lblTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkMakeTransparent")]
    internal virtual CheckBox chkMakeTransparent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkMakeTopmostWin")]
    internal virtual CheckBox chkMakeTopmostWin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkRefreshBrowser")]
    internal virtual CheckBox chkRefreshBrowser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnRereadTime
    {
      get => this._btnRereadTime;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnRereadTime_Click);
        Button btnRereadTime1 = this._btnRereadTime;
        if (btnRereadTime1 != null)
          btnRereadTime1.Click -= eventHandler;
        this._btnRereadTime = value;
        Button btnRereadTime2 = this._btnRereadTime;
        if (btnRereadTime2 == null)
          return;
        btnRereadTime2.Click += eventHandler;
      }
    }

    internal virtual Button btnAddSeconds
    {
      get => this._btnAddSeconds;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAddSeconds_Click);
        Button btnAddSeconds1 = this._btnAddSeconds;
        if (btnAddSeconds1 != null)
          btnAddSeconds1.Click -= eventHandler;
        this._btnAddSeconds = value;
        Button btnAddSeconds2 = this._btnAddSeconds;
        if (btnAddSeconds2 == null)
          return;
        btnAddSeconds2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnSubtractSeconds
    {
      get => this._btnSubtractSeconds;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSubtractSeconds_Click);
        Button btnSubtractSeconds1 = this._btnSubtractSeconds;
        if (btnSubtractSeconds1 != null)
          btnSubtractSeconds1.Click -= eventHandler;
        this._btnSubtractSeconds = value;
        Button btnSubtractSeconds2 = this._btnSubtractSeconds;
        if (btnSubtractSeconds2 == null)
          return;
        btnSubtractSeconds2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTimeServerUrl")]
    internal virtual Label lblTimeServerUrl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("chkAudibleNotifications")]
    internal virtual CheckBox chkAudibleNotifications { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void btnAddSeconds_Click(object sender, EventArgs e)
    {
      mdlSharedFunctions.CurrentTime = mdlSharedFunctions.CurrentTime.AddSeconds(1.0);
      this.lblTime.ForeColor = Color.Green;
    }

    private void btnOnOff_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.btnOnOff.Text, "On", false) == 0)
      {
        this.btnOnOff.Text = "Off";
        this.btnOnOff.BackColor = Color.Green;
        this.txtHours.Enabled = true;
        this.txtMinutes.Enabled = true;
        this.txtSeconds.Enabled = true;
      }
      else
      {
        this.btnOnOff.Text = "On";
        this.btnOnOff.BackColor = Color.White;
        this.txtHours.Enabled = false;
        this.txtMinutes.Enabled = false;
        this.txtSeconds.Enabled = false;
      }
    }

    private void btnRereadTime_Click(object sender, EventArgs e)
    {
      try
      {
        mdlSharedFunctions.CurrentTime = mdlSharedFunctions.GetDateTimeNtp();
        this.lblTime.ForeColor = Color.Green;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        mdlSharedFunctions.DumpErrLog(this.Name + ".btnRereadTime_Click", exception.Message);
        int num = (int) MessageBox.Show("Countdown App encountered the following error while syncing the time.\r\n" + exception.Message, "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      mdlSharedFunctions.CountdownTimeInSeconds = checked (Conversions.ToInteger(this.txtHours.Text) * 3600 + Conversions.ToInteger(this.txtMinutes.Text) * 60 + Conversions.ToInteger(this.txtSeconds.Text));
      if (mdlSharedFunctions.CountdownTimeInSeconds > 0)
      {
        mdlSharedFunctions.MakeTopmostWin = this.chkMakeTopmostWin.Checked;
        mdlSharedFunctions.RefreshBrowser = this.chkRefreshBrowser.Checked;
        mdlSharedFunctions.MakeTransparent = this.chkMakeTransparent.Checked;
        mdlSharedFunctions.AllowAudibleNotifications = this.chkAudibleNotifications.Checked;
        MyProject.Forms.frmCountdown.Show();
        this.Hide();
      }
      else
      {
        int num = (int) MessageBox.Show("You will have to enter a time duration before starting the countdown timer.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnSubtractSeconds_Click(object sender, EventArgs e)
    {
      mdlSharedFunctions.CurrentTime = mdlSharedFunctions.CurrentTime.AddSeconds(-1.0);
      this.lblTime.ForeColor = Color.Green;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void frmMain_Closing(object sender, CancelEventArgs e)
    {
      try
      {
        if (MessageBox.Show("Are you sure you want to exit Countdown App?", "Countdown App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
          ProjectData.EndApp();
        else
          e.Cancel = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        mdlSharedFunctions.DumpErrLog(this.Name + ".frmMain_Closing", ex.Message);
        ProjectData.EndApp();
        ProjectData.ClearProjectError();
      }
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      this.txtHours.Enabled = false;
      this.txtMinutes.Enabled = false;
      this.txtSeconds.Enabled = false;
      this.lblTimeServerUrl.Text = mdlSystemParameters.TimeServerUrl;
      mdlSharedFunctions.CurrentTime = DateAndTime.Now;
      this.lblTime.Text = Strings.Format((object) mdlSharedFunctions.CurrentTime, "HH:mm:ss");
      this.tmrTime.Enabled = true;
      this.lblHeaderBackground.BackColor = mdlSystemParameters.HeaderBackColor;
      this.lblMainTitle.BackColor = mdlSystemParameters.HeaderBackColor;
      this.lblSubTitle.BackColor = mdlSystemParameters.HeaderBackColor;
      this.picLogo.BackColor = mdlSystemParameters.HeaderBackColor;
    }

    private void tmrTime_Tick(object sender, EventArgs e)
    {
      try
      {
        if (this.FlagInitialTimeSynced)
        {
          mdlSharedFunctions.CurrentTime = mdlSharedFunctions.CurrentTime.AddSeconds(1.0);
        }
        else
        {
          mdlSharedFunctions.CurrentTime = mdlSharedFunctions.GetDateTimeNtp();
          this.FlagInitialTimeSynced = true;
        }
        this.lblTime.ForeColor = Color.Gray;
        this.lblTime.Text = Strings.Format((object) mdlSharedFunctions.CurrentTime, "HH:mm:ss");
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

    private void txtHours_GotFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtHours.Text, "00", false) != 0)
        return;
      this.txtHours.Text = "";
    }

    private void txtHours_LostFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtHours.Text, "", false) != 0 && Versioned.IsNumeric((object) this.txtHours.Text))
        return;
      this.txtHours.Text = "00";
    }

    private void txtMinutes_GotFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtMinutes.Text, "00", false) != 0)
        return;
      this.txtMinutes.Text = "";
    }

    private void txtMinutes_LostFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtMinutes.Text, "", false) != 0 && Versioned.IsNumeric((object) this.txtMinutes.Text))
        return;
      this.txtMinutes.Text = "00";
    }

    private void txtSeconds_GotFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtSeconds.Text, "00", false) != 0)
        return;
      this.txtSeconds.Text = "";
    }

    private void txtSeconds_LostFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtSeconds.Text, "", false) != 0 && Versioned.IsNumeric((object) this.txtSeconds.Text))
        return;
      this.txtSeconds.Text = "00";
    }
  }
}
