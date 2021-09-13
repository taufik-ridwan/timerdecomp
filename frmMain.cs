using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CountdownApp.My;
using CountdownApp.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CountdownApp
{
	[DesignerGenerated]
	public class frmMain : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("picLogo")]
		private PictureBox _picLogo;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblMainTitle")]
		private Label _lblMainTitle;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblHeaderBackground")]
		private Label _lblHeaderBackground;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblSubTitle")]
		private Label _lblSubTitle;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnStart")]
		private Button _btnStart;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnOnOff")]
		private Button _btnOnOff;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtHours")]
		private TextBox _txtHours;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtMinutes")]
		private TextBox _txtMinutes;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtSeconds")]
		private TextBox _txtSeconds;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox4")]
		private PictureBox _PictureBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblTime")]
		private Label _lblTime;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkMakeTransparent")]
		private CheckBox _chkMakeTransparent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkMakeTopmostWin")]
		private CheckBox _chkMakeTopmostWin;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkRefreshBrowser")]
		private CheckBox _chkRefreshBrowser;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRereadTime")]
		private Button _btnRereadTime;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnAddSeconds")]
		private Button _btnAddSeconds;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSubtractSeconds")]
		private Button _btnSubtractSeconds;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblTimeServerUrl")]
		private Label _lblTimeServerUrl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tmrTime")]
		private Timer _tmrTime;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkAudibleNotifications")]
		private CheckBox _chkAudibleNotifications;

		private bool FlagInitialTimeSynced;

		[field: AccessedThroughProperty("picLogo")]
		internal virtual PictureBox picLogo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblMainTitle")]
		internal virtual Label lblMainTitle
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblHeaderBackground")]
		internal virtual Label lblHeaderBackground
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSubTitle")]
		internal virtual Label lblSubTitle
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnStart
		{
			[CompilerGenerated]
			get
			{
				return _btnStart;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnStart_Click;
				Button button = _btnStart;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnStart = value;
				button = _btnStart;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnOnOff
		{
			[CompilerGenerated]
			get
			{
				return _btnOnOff;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnOnOff_Click;
				Button button = _btnOnOff;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnOnOff = value;
				button = _btnOnOff;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("PictureBox2")]
		internal virtual PictureBox PictureBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtHours
		{
			[CompilerGenerated]
			get
			{
				return _txtHours;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtHours_GotFocus;
				EventHandler value3 = txtHours_LostFocus;
				TextBox textBox = _txtHours;
				if (textBox != null)
				{
					textBox.GotFocus -= value2;
					textBox.LostFocus -= value3;
				}
				_txtHours = value;
				textBox = _txtHours;
				if (textBox != null)
				{
					textBox.GotFocus += value2;
					textBox.LostFocus += value3;
				}
			}
		}

		internal virtual TextBox txtMinutes
		{
			[CompilerGenerated]
			get
			{
				return _txtMinutes;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtMinutes_GotFocus;
				EventHandler value3 = txtMinutes_LostFocus;
				TextBox textBox = _txtMinutes;
				if (textBox != null)
				{
					textBox.GotFocus -= value2;
					textBox.LostFocus -= value3;
				}
				_txtMinutes = value;
				textBox = _txtMinutes;
				if (textBox != null)
				{
					textBox.GotFocus += value2;
					textBox.LostFocus += value3;
				}
			}
		}

		[field: AccessedThroughProperty("PictureBox3")]
		internal virtual PictureBox PictureBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtSeconds
		{
			[CompilerGenerated]
			get
			{
				return _txtSeconds;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtSeconds_GotFocus;
				EventHandler value3 = txtSeconds_LostFocus;
				TextBox textBox = _txtSeconds;
				if (textBox != null)
				{
					textBox.GotFocus -= value2;
					textBox.LostFocus -= value3;
				}
				_txtSeconds = value;
				textBox = _txtSeconds;
				if (textBox != null)
				{
					textBox.GotFocus += value2;
					textBox.LostFocus += value3;
				}
			}
		}

		[field: AccessedThroughProperty("PictureBox4")]
		internal virtual PictureBox PictureBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTime")]
		internal virtual Label lblTime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkMakeTransparent")]
		internal virtual CheckBox chkMakeTransparent
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkMakeTopmostWin")]
		internal virtual CheckBox chkMakeTopmostWin
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkRefreshBrowser")]
		internal virtual CheckBox chkRefreshBrowser
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRereadTime
		{
			[CompilerGenerated]
			get
			{
				return _btnRereadTime;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRereadTime_Click;
				Button button = _btnRereadTime;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRereadTime = value;
				button = _btnRereadTime;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnAddSeconds
		{
			[CompilerGenerated]
			get
			{
				return _btnAddSeconds;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnAddSeconds_Click;
				Button button = _btnAddSeconds;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnAddSeconds = value;
				button = _btnAddSeconds;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label16")]
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSubtractSeconds
		{
			[CompilerGenerated]
			get
			{
				return _btnSubtractSeconds;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSubtractSeconds_Click;
				Button button = _btnSubtractSeconds;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSubtractSeconds = value;
				button = _btnSubtractSeconds;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label20")]
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTimeServerUrl")]
		internal virtual Label lblTimeServerUrl
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Timer tmrTime
		{
			[CompilerGenerated]
			get
			{
				return _tmrTime;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = tmrTime_Tick;
				Timer timer = _tmrTime;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				_tmrTime = value;
				timer = _tmrTime;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("chkAudibleNotifications")]
		internal virtual CheckBox chkAudibleNotifications
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMain()
		{
			base.Closing += frmMain_Closing;
			base.Load += frmMain_Load;
			FlagInitialTimeSynced = false;
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountdownApp.frmMain));
			lblMainTitle = new System.Windows.Forms.Label();
			lblHeaderBackground = new System.Windows.Forms.Label();
			lblSubTitle = new System.Windows.Forms.Label();
			btnStart = new System.Windows.Forms.Button();
			btnOnOff = new System.Windows.Forms.Button();
			PictureBox2 = new System.Windows.Forms.PictureBox();
			picLogo = new System.Windows.Forms.PictureBox();
			txtHours = new System.Windows.Forms.TextBox();
			txtMinutes = new System.Windows.Forms.TextBox();
			PictureBox3 = new System.Windows.Forms.PictureBox();
			txtSeconds = new System.Windows.Forms.TextBox();
			PictureBox4 = new System.Windows.Forms.PictureBox();
			Label5 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			lblTime = new System.Windows.Forms.Label();
			Label14 = new System.Windows.Forms.Label();
			Label13 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			chkMakeTransparent = new System.Windows.Forms.CheckBox();
			Label15 = new System.Windows.Forms.Label();
			chkMakeTopmostWin = new System.Windows.Forms.CheckBox();
			chkRefreshBrowser = new System.Windows.Forms.CheckBox();
			Label12 = new System.Windows.Forms.Label();
			btnRereadTime = new System.Windows.Forms.Button();
			btnAddSeconds = new System.Windows.Forms.Button();
			Label16 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label17 = new System.Windows.Forms.Label();
			btnSubtractSeconds = new System.Windows.Forms.Button();
			Label19 = new System.Windows.Forms.Label();
			Label20 = new System.Windows.Forms.Label();
			Label18 = new System.Windows.Forms.Label();
			lblTimeServerUrl = new System.Windows.Forms.Label();
			tmrTime = new System.Windows.Forms.Timer(components);
			chkAudibleNotifications = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
			((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
			SuspendLayout();
			lblMainTitle.AutoSize = true;
			lblMainTitle.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
			lblMainTitle.Font = new System.Drawing.Font("Calibri", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblMainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
			lblMainTitle.Location = new System.Drawing.Point(5, 9);
			lblMainTitle.Name = "lblMainTitle";
			lblMainTitle.Size = new System.Drawing.Size(194, 33);
			lblMainTitle.TabIndex = 3;
			lblMainTitle.Text = "Countdown App";
			lblHeaderBackground.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
			lblHeaderBackground.Font = new System.Drawing.Font("Calibri", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblHeaderBackground.ForeColor = System.Drawing.Color.White;
			lblHeaderBackground.Location = new System.Drawing.Point(0, 0);
			lblHeaderBackground.Name = "lblHeaderBackground";
			lblHeaderBackground.Size = new System.Drawing.Size(520, 80);
			lblHeaderBackground.TabIndex = 5;
			lblSubTitle.AutoSize = true;
			lblSubTitle.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
			lblSubTitle.Font = new System.Drawing.Font("Calibri", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblSubTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
			lblSubTitle.Location = new System.Drawing.Point(5, 40);
			lblSubTitle.Name = "lblSubTitle";
			lblSubTitle.Size = new System.Drawing.Size(360, 23);
			lblSubTitle.TabIndex = 6;
			lblSubTitle.Text = "Karena semua orang butuh kepastian (waktu)";
			btnStart.BackColor = System.Drawing.Color.FromArgb(17, 85, 204);
			btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(17, 85, 204);
			btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnStart.Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnStart.ForeColor = System.Drawing.Color.White;
			btnStart.Location = new System.Drawing.Point(395, 93);
			btnStart.Name = "btnStart";
			btnStart.Size = new System.Drawing.Size(97, 25);
			btnStart.TabIndex = 27;
			btnStart.Tag = "Start Countdown";
			btnStart.Text = "Mulai Hitung";
			btnStart.UseVisualStyleBackColor = false;
			btnOnOff.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnOnOff.Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnOnOff.Location = new System.Drawing.Point(330, 93);
			btnOnOff.Name = "btnOnOff";
			btnOnOff.Size = new System.Drawing.Size(56, 25);
			btnOnOff.TabIndex = 26;
			btnOnOff.Text = "On";
			btnOnOff.UseVisualStyleBackColor = true;
			PictureBox2.Image = CountdownApp.My.Resources.Resources.Rounded_Rectangle;
			PictureBox2.Location = new System.Drawing.Point(157, 145);
			PictureBox2.Name = "PictureBox2";
			PictureBox2.Size = new System.Drawing.Size(97, 92);
			PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox2.TabIndex = 30;
			PictureBox2.TabStop = false;
			picLogo.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
			picLogo.Image = CountdownApp.My.Resources.Resources.Logoblue;
			picLogo.Location = new System.Drawing.Point(390, 12);
			picLogo.Name = "picLogo";
			picLogo.Size = new System.Drawing.Size(102, 56);
			picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			picLogo.TabIndex = 4;
			picLogo.TabStop = false;
			txtHours.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
			txtHours.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtHours.Location = new System.Drawing.Point(176, 162);
			txtHours.Name = "txtHours";
			txtHours.Size = new System.Drawing.Size(59, 59);
			txtHours.TabIndex = 31;
			txtHours.Text = "00";
			txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtMinutes.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			txtMinutes.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtMinutes.Location = new System.Drawing.Point(294, 162);
			txtMinutes.Name = "txtMinutes";
			txtMinutes.Size = new System.Drawing.Size(59, 59);
			txtMinutes.TabIndex = 33;
			txtMinutes.Text = "00";
			txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			PictureBox3.Image = CountdownApp.My.Resources.Resources.Rounded_Rectangle;
			PictureBox3.Location = new System.Drawing.Point(275, 145);
			PictureBox3.Name = "PictureBox3";
			PictureBox3.Size = new System.Drawing.Size(97, 92);
			PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox3.TabIndex = 32;
			PictureBox3.TabStop = false;
			txtSeconds.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
			txtSeconds.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtSeconds.Location = new System.Drawing.Point(414, 162);
			txtSeconds.Name = "txtSeconds";
			txtSeconds.Size = new System.Drawing.Size(59, 59);
			txtSeconds.TabIndex = 35;
			txtSeconds.Text = "00";
			txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			PictureBox4.Image = CountdownApp.My.Resources.Resources.Rounded_Rectangle;
			PictureBox4.Location = new System.Drawing.Point(395, 145);
			PictureBox4.Name = "PictureBox4";
			PictureBox4.Size = new System.Drawing.Size(97, 92);
			PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox4.TabIndex = 34;
			PictureBox4.TabStop = false;
			Label5.AutoSize = true;
			Label5.Location = new System.Drawing.Point(5, 98);
			Label5.Name = "Label5";
			Label5.Size = new System.Drawing.Size(214, 15);
			Label5.TabIndex = 36;
			Label5.Tag = "Automatic countdown? (click button)";
			Label5.Text = "Hitung Otomatis? (Klik Tombol on/off)";
			Label6.Location = new System.Drawing.Point(5, 186);
			Label6.Name = "Label6";
			Label6.Size = new System.Drawing.Size(116, 51);
			Label6.TabIndex = 38;
			Label6.Tag = "(time reference to countdown)";
			Label6.Text = "(Waktu target Refresh untuk Countdown)";
			Label7.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label7.Location = new System.Drawing.Point(5, 145);
			Label7.Name = "Label7";
			Label7.Size = new System.Drawing.Size(128, 41);
			Label7.TabIndex = 37;
			Label7.Tag = "Countdown to what time?";
			Label7.Text = "Countdown Ke Jam Berapa?";
			Label11.AutoSize = true;
			Label11.Location = new System.Drawing.Point(418, 240);
			Label11.Name = "Label11";
			Label11.Size = new System.Drawing.Size(51, 15);
			Label11.TabIndex = 41;
			Label11.Tag = "Seconds";
			Label11.Text = "Detik (s)";
			Label10.AutoSize = true;
			Label10.Location = new System.Drawing.Point(288, 240);
			Label10.Name = "Label10";
			Label10.Size = new System.Drawing.Size(70, 15);
			Label10.TabIndex = 40;
			Label10.Tag = "Minutes";
			Label10.Text = "Menit (mts)";
			Label9.AutoSize = true;
			Label9.Location = new System.Drawing.Point(173, 240);
			Label9.Name = "Label9";
			Label9.Size = new System.Drawing.Size(65, 15);
			Label9.TabIndex = 39;
			Label9.Tag = "Hours";
			Label9.Text = "Jam (hour)";
			lblTime.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblTime.ForeColor = System.Drawing.Color.Gray;
			lblTime.Location = new System.Drawing.Point(277, 322);
			lblTime.Name = "lblTime";
			lblTime.Size = new System.Drawing.Size(195, 56);
			lblTime.TabIndex = 50;
			lblTime.Text = "00:00:00";
			lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			Label14.AutoSize = true;
			Label14.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label14.Location = new System.Drawing.Point(274, 301);
			Label14.Name = "Label14";
			Label14.Size = new System.Drawing.Size(201, 19);
			Label14.TabIndex = 49;
			Label14.Text = "Time on Target Server GMT+7";
			Label13.BackColor = System.Drawing.Color.LightGray;
			Label13.Location = new System.Drawing.Point(5, 300);
			Label13.Name = "Label13";
			Label13.Size = new System.Drawing.Size(241, 1);
			Label13.TabIndex = 48;
			Label8.AutoSize = true;
			Label8.Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			Label8.Location = new System.Drawing.Point(5, 274);
			Label8.Name = "Label8";
			Label8.Size = new System.Drawing.Size(199, 15);
			Label8.TabIndex = 47;
			Label8.Tag = "What Features You Want to turn on?";
			Label8.Text = "Fitur apa yang mau kamu nyalakan?";
			chkMakeTransparent.AutoSize = true;
			chkMakeTransparent.Location = new System.Drawing.Point(11, 359);
			chkMakeTransparent.Name = "chkMakeTransparent";
			chkMakeTransparent.Size = new System.Drawing.Size(143, 19);
			chkMakeTransparent.TabIndex = 45;
			chkMakeTransparent.Tag = "Make Window Transparent";
			chkMakeTransparent.Text = "Windows transparan";
			chkMakeTransparent.UseVisualStyleBackColor = true;
			Label15.BackColor = System.Drawing.Color.LightGray;
			Label15.Location = new System.Drawing.Point(5, 262);
			Label15.Name = "Label15";
			Label15.Size = new System.Drawing.Size(492, 1);
			Label15.TabIndex = 46;
			chkMakeTopmostWin.AutoSize = true;
			chkMakeTopmostWin.Location = new System.Drawing.Point(11, 333);
			chkMakeTopmostWin.Name = "chkMakeTopmostWin";
			chkMakeTopmostWin.Size = new System.Drawing.Size(183, 19);
			chkMakeTopmostWin.TabIndex = 44;
			chkMakeTopmostWin.Tag = "Show Timer Window on Top";
			chkMakeTopmostWin.Text = "Tampilkan di Depan browser";
			chkMakeTopmostWin.UseVisualStyleBackColor = true;
			chkRefreshBrowser.AutoSize = true;
			chkRefreshBrowser.Location = new System.Drawing.Point(11, 307);
			chkRefreshBrowser.Name = "chkRefreshBrowser";
			chkRefreshBrowser.Size = new System.Drawing.Size(180, 19);
			chkRefreshBrowser.TabIndex = 43;
			chkRefreshBrowser.Tag = "Countdown to 0 -> Refresh";
			chkRefreshBrowser.Text = "Bila Countdown 0 -> Refresh";
			chkRefreshBrowser.UseVisualStyleBackColor = true;
			Label12.BackColor = System.Drawing.Color.LightGray;
			Label12.Location = new System.Drawing.Point(5, 411);
			Label12.Name = "Label12";
			Label12.Size = new System.Drawing.Size(492, 1);
			Label12.TabIndex = 51;
			btnRereadTime.BackColor = System.Drawing.Color.FromArgb(17, 85, 204);
			btnRereadTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(17, 85, 204);
			btnRereadTime.FlatAppearance.BorderSize = 0;
			btnRereadTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRereadTime.Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnRereadTime.ForeColor = System.Drawing.Color.White;
			btnRereadTime.Location = new System.Drawing.Point(323, 274);
			btnRereadTime.Name = "btnRereadTime";
			btnRereadTime.Size = new System.Drawing.Size(102, 20);
			btnRereadTime.TabIndex = 52;
			btnRereadTime.Text = "Re-read Time";
			btnRereadTime.UseVisualStyleBackColor = false;
			btnAddSeconds.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			btnAddSeconds.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			btnAddSeconds.FlatAppearance.BorderSize = 0;
			btnAddSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnAddSeconds.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnAddSeconds.Location = new System.Drawing.Point(452, 386);
			btnAddSeconds.Name = "btnAddSeconds";
			btnAddSeconds.Size = new System.Drawing.Size(17, 18);
			btnAddSeconds.TabIndex = 53;
			btnAddSeconds.Text = "+";
			btnAddSeconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			btnAddSeconds.UseVisualStyleBackColor = false;
			Label16.AutoSize = true;
			Label16.Location = new System.Drawing.Point(252, 388);
			Label16.Name = "Label16";
			Label16.Size = new System.Drawing.Size(198, 15);
			Label16.TabIndex = 54;
			Label16.Tag = "";
			Label16.Text = "Click + / - to adjust seconds (detik):";
			Label4.BackColor = System.Drawing.Color.LightGray;
			Label4.Location = new System.Drawing.Point(5, 129);
			Label4.Name = "Label4";
			Label4.Size = new System.Drawing.Size(492, 1);
			Label4.TabIndex = 55;
			Label17.BackColor = System.Drawing.Color.LightGray;
			Label17.Location = new System.Drawing.Point(245, 262);
			Label17.Name = "Label17";
			Label17.Size = new System.Drawing.Size(1, 149);
			Label17.TabIndex = 56;
			btnSubtractSeconds.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			btnSubtractSeconds.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			btnSubtractSeconds.FlatAppearance.BorderSize = 0;
			btnSubtractSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSubtractSeconds.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSubtractSeconds.Location = new System.Drawing.Point(475, 386);
			btnSubtractSeconds.Name = "btnSubtractSeconds";
			btnSubtractSeconds.Size = new System.Drawing.Size(17, 18);
			btnSubtractSeconds.TabIndex = 57;
			btnSubtractSeconds.Text = "-";
			btnSubtractSeconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			btnSubtractSeconds.UseVisualStyleBackColor = false;
			Label19.BackColor = System.Drawing.Color.LightGray;
			Label19.Location = new System.Drawing.Point(5, 443);
			Label19.Name = "Label19";
			Label19.Size = new System.Drawing.Size(492, 1);
			Label19.TabIndex = 59;
			Label20.AutoSize = true;
			Label20.Location = new System.Drawing.Point(5, 420);
			Label20.Name = "Label20";
			Label20.Size = new System.Drawing.Size(173, 15);
			Label20.TabIndex = 60;
			Label20.Tag = "";
			Label20.Text = "Target Server URL to Read time:";
			Label18.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label18.Location = new System.Drawing.Point(5, 449);
			Label18.Name = "Label18";
			Label18.Size = new System.Drawing.Size(470, 28);
			Label18.TabIndex = 61;
			Label18.Tag = "";
			Label18.Text = "Program ini sudah dibajak sama pikapi mwahahahaa";
			lblTimeServerUrl.AutoSize = true;
			lblTimeServerUrl.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			lblTimeServerUrl.Location = new System.Drawing.Point(185, 420);
			lblTimeServerUrl.Name = "lblTimeServerUrl";
			lblTimeServerUrl.Size = new System.Drawing.Size(171, 15);
			lblTimeServerUrl.TabIndex = 62;
			lblTimeServerUrl.Tag = "";
			lblTimeServerUrl.Text = "https://internsip.kemkes.go.id";
			tmrTime.Interval = 1000;
			chkAudibleNotifications.AutoSize = true;
			chkAudibleNotifications.Location = new System.Drawing.Point(11, 385);
			chkAudibleNotifications.Name = "chkAudibleNotifications";
			chkAudibleNotifications.Size = new System.Drawing.Size(176, 19);
			chkAudibleNotifications.TabIndex = 63;
			chkAudibleNotifications.Tag = "";
			chkAudibleNotifications.Text = "Allow audible notifications.";
			chkAudibleNotifications.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			base.ClientSize = new System.Drawing.Size(504, 481);
			base.Controls.Add(chkAudibleNotifications);
			base.Controls.Add(lblTimeServerUrl);
			base.Controls.Add(Label18);
			base.Controls.Add(Label20);
			base.Controls.Add(Label19);
			base.Controls.Add(btnSubtractSeconds);
			base.Controls.Add(Label17);
			base.Controls.Add(Label4);
			base.Controls.Add(lblMainTitle);
			base.Controls.Add(Label16);
			base.Controls.Add(btnAddSeconds);
			base.Controls.Add(btnRereadTime);
			base.Controls.Add(Label12);
			base.Controls.Add(Label14);
			base.Controls.Add(Label13);
			base.Controls.Add(Label8);
			base.Controls.Add(chkMakeTransparent);
			base.Controls.Add(Label15);
			base.Controls.Add(chkMakeTopmostWin);
			base.Controls.Add(chkRefreshBrowser);
			base.Controls.Add(Label11);
			base.Controls.Add(Label10);
			base.Controls.Add(Label9);
			base.Controls.Add(Label6);
			base.Controls.Add(Label7);
			base.Controls.Add(Label5);
			base.Controls.Add(txtSeconds);
			base.Controls.Add(PictureBox4);
			base.Controls.Add(txtMinutes);
			base.Controls.Add(PictureBox3);
			base.Controls.Add(txtHours);
			base.Controls.Add(PictureBox2);
			base.Controls.Add(btnStart);
			base.Controls.Add(btnOnOff);
			base.Controls.Add(lblSubTitle);
			base.Controls.Add(picLogo);
			base.Controls.Add(lblHeaderBackground);
			base.Controls.Add(lblTime);
			Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmMain";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Countdown App";
			((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
			((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void btnAddSeconds_Click(object sender, EventArgs e)
		{
			mdlSharedFunctions.CurrentTime = mdlSharedFunctions.CurrentTime.AddSeconds(1.0);
			lblTime.ForeColor = Color.Green;
		}

		private void btnOnOff_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btnOnOff.Text, "On", TextCompare: false) == 0)
			{
				btnOnOff.Text = "Off";
				btnOnOff.BackColor = Color.Green;
				txtHours.Enabled = true;
				txtMinutes.Enabled = true;
				txtSeconds.Enabled = true;
			}
			else
			{
				btnOnOff.Text = "On";
				btnOnOff.BackColor = Color.White;
				txtHours.Enabled = false;
				txtMinutes.Enabled = false;
				txtSeconds.Enabled = false;
			}
		}

		private void btnRereadTime_Click(object sender, EventArgs e)
		{
			try
			{
				mdlSharedFunctions.CurrentTime = mdlSharedFunctions.GetDateTimeNtp();
				lblTime.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mdlSharedFunctions.DumpErrLog(base.Name + ".btnRereadTime_Click", ex2.Message);
				MessageBox.Show("Countdown App encountered the following error while syncing the time.\r\n" + ex2.Message, "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			mdlSharedFunctions.CountdownTimeInSeconds = checked(Conversions.ToInteger(txtHours.Text) * 3600 + Conversions.ToInteger(txtMinutes.Text) * 60 + Conversions.ToInteger(txtSeconds.Text));
			if (mdlSharedFunctions.CountdownTimeInSeconds > 0)
			{
				mdlSharedFunctions.MakeTopmostWin = chkMakeTopmostWin.Checked;
				mdlSharedFunctions.RefreshBrowser = chkRefreshBrowser.Checked;
				mdlSharedFunctions.MakeTransparent = chkMakeTransparent.Checked;
				mdlSharedFunctions.AllowAudibleNotifications = chkAudibleNotifications.Checked;
				MyProject.Forms.frmCountdown.Show();
				Hide();
			}
			else
			{
				MessageBox.Show("You will have to enter a time duration before starting the countdown timer.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnSubtractSeconds_Click(object sender, EventArgs e)
		{
			mdlSharedFunctions.CurrentTime = mdlSharedFunctions.CurrentTime.AddSeconds(-1.0);
			lblTime.ForeColor = Color.Green;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void frmMain_Closing(object sender, CancelEventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are you sure you want to exit Countdown App?", "Countdown App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					ProjectData.EndApp();
				}
				else
				{
					e.Cancel = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mdlSharedFunctions.DumpErrLog(base.Name + ".frmMain_Closing", ex2.Message);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			txtHours.Enabled = false;
			txtMinutes.Enabled = false;
			txtSeconds.Enabled = false;
			lblTimeServerUrl.Text = mdlSystemParameters.TimeServerUrl;
			mdlSharedFunctions.CurrentTime = DateAndTime.Now;
			lblTime.Text = Strings.Format(mdlSharedFunctions.CurrentTime, "HH:mm:ss");
			tmrTime.Enabled = true;
			lblHeaderBackground.BackColor = mdlSystemParameters.HeaderBackColor;
			lblMainTitle.BackColor = mdlSystemParameters.HeaderBackColor;
			lblSubTitle.BackColor = mdlSystemParameters.HeaderBackColor;
			picLogo.BackColor = mdlSystemParameters.HeaderBackColor;
		}

		private void tmrTime_Tick(object sender, EventArgs e)
		{
			try
			{
				if (FlagInitialTimeSynced)
				{
					mdlSharedFunctions.CurrentTime = mdlSharedFunctions.CurrentTime.AddSeconds(1.0);
				}
				else
				{
					mdlSharedFunctions.CurrentTime = mdlSharedFunctions.GetDateTimeNtp();
					FlagInitialTimeSynced = true;
				}
				lblTime.ForeColor = Color.Gray;
				lblTime.Text = Strings.Format(mdlSharedFunctions.CurrentTime, "HH:mm:ss");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mdlSharedFunctions.DumpErrLog(base.Name + ".tmrTime_Tick", ex2.Message);
				MessageBox.Show("Countdown App has encountered the following error.\r\n" + ex2.Message, "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void txtHours_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtHours.Text, "00", TextCompare: false) == 0)
			{
				txtHours.Text = "";
			}
		}

		private void txtHours_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtHours.Text, "", TextCompare: false) == 0 || !Versioned.IsNumeric(txtHours.Text))
			{
				txtHours.Text = "00";
			}
		}

		private void txtMinutes_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtMinutes.Text, "00", TextCompare: false) == 0)
			{
				txtMinutes.Text = "";
			}
		}

		private void txtMinutes_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtMinutes.Text, "", TextCompare: false) == 0 || !Versioned.IsNumeric(txtMinutes.Text))
			{
				txtMinutes.Text = "00";
			}
		}

		private void txtSeconds_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtSeconds.Text, "00", TextCompare: false) == 0)
			{
				txtSeconds.Text = "";
			}
		}

		private void txtSeconds_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtSeconds.Text, "", TextCompare: false) == 0 || !Versioned.IsNumeric(txtSeconds.Text))
			{
				txtSeconds.Text = "00";
			}
		}
	}
}
