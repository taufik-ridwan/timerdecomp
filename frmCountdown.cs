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
	public class frmCountdown : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tmrTime")]
		private Timer _tmrTime;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblTime")]
		private Label _lblTime;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblHours")]
		private Label _lblHours;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblMinutes")]
		private Label _lblMinutes;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblSeconds")]
		private Label _lblSeconds;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblTimeServerUrl")]
		private Label _lblTimeServerUrl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox4")]
		private PictureBox _PictureBox4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		private int CountdownDuration;

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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
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

		[field: AccessedThroughProperty("lblTime")]
		internal virtual Label lblTime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblHours")]
		internal virtual Label lblHours
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblMinutes")]
		internal virtual Label lblMinutes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSeconds")]
		internal virtual Label lblSeconds
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("PictureBox4")]
		internal virtual PictureBox PictureBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		public frmCountdown()
		{
			base.Closing += frmCountdown_Closing;
			base.Load += frmCountdown_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountdownApp.frmCountdown));
			tmrTime = new System.Windows.Forms.Timer(components);
			Label13 = new System.Windows.Forms.Label();
			Label14 = new System.Windows.Forms.Label();
			lblTime = new System.Windows.Forms.Label();
			lblHours = new System.Windows.Forms.Label();
			lblMinutes = new System.Windows.Forms.Label();
			lblSeconds = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			lblTimeServerUrl = new System.Windows.Forms.Label();
			PictureBox4 = new System.Windows.Forms.PictureBox();
			Label3 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
			SuspendLayout();
			tmrTime.Interval = 1000;
			Label13.BackColor = System.Drawing.Color.LightGray;
			Label13.Location = new System.Drawing.Point(14, 153);
			Label13.Name = "Label13";
			Label13.Size = new System.Drawing.Size(281, 1);
			Label13.TabIndex = 49;
			Label14.AutoSize = true;
			Label14.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label14.Location = new System.Drawing.Point(54, 158);
			Label14.Name = "Label14";
			Label14.Size = new System.Drawing.Size(201, 19);
			Label14.TabIndex = 50;
			Label14.Text = "Time on Target Server GMT+7";
			lblTime.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblTime.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
			lblTime.Location = new System.Drawing.Point(57, 190);
			lblTime.Name = "lblTime";
			lblTime.Size = new System.Drawing.Size(195, 49);
			lblTime.TabIndex = 51;
			lblTime.Text = "00:00:00";
			lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			lblHours.AutoSize = true;
			lblHours.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblHours.Location = new System.Drawing.Point(5, 45);
			lblHours.Name = "lblHours";
			lblHours.Size = new System.Drawing.Size(73, 59);
			lblHours.TabIndex = 52;
			lblHours.Tag = "Hours";
			lblHours.Text = "00";
			lblMinutes.AutoSize = true;
			lblMinutes.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblMinutes.Location = new System.Drawing.Point(102, 45);
			lblMinutes.Name = "lblMinutes";
			lblMinutes.Size = new System.Drawing.Size(73, 59);
			lblMinutes.TabIndex = 53;
			lblMinutes.Tag = "Hours";
			lblMinutes.Text = "00";
			lblSeconds.AutoSize = true;
			lblSeconds.Font = new System.Drawing.Font("Calibri", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblSeconds.Location = new System.Drawing.Point(199, 45);
			lblSeconds.Name = "lblSeconds";
			lblSeconds.Size = new System.Drawing.Size(73, 59);
			lblSeconds.TabIndex = 54;
			lblSeconds.Tag = "Hours";
			lblSeconds.Text = "00";
			Label1.AutoSize = true;
			Label1.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.Location = new System.Drawing.Point(18, 100);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(47, 19);
			Label1.TabIndex = 55;
			Label1.Text = "Hours";
			Label2.AutoSize = true;
			Label2.BackColor = System.Drawing.Color.White;
			Label2.Font = new System.Drawing.Font("Calibri", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
			Label2.Location = new System.Drawing.Point(5, 5);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(144, 33);
			Label2.TabIndex = 56;
			Label2.Text = "Countdown";
			lblTimeServerUrl.AutoSize = true;
			lblTimeServerUrl.BackColor = System.Drawing.Color.FromArgb(201, 218, 248);
			lblTimeServerUrl.Location = new System.Drawing.Point(69, 179);
			lblTimeServerUrl.Name = "lblTimeServerUrl";
			lblTimeServerUrl.Size = new System.Drawing.Size(171, 15);
			lblTimeServerUrl.TabIndex = 63;
			lblTimeServerUrl.Tag = "";
			lblTimeServerUrl.Text = "https://internsip.kemkes.go.id";
			PictureBox4.Image = CountdownApp.My.Resources.Resources._480px_Blue_circle;
			PictureBox4.Location = new System.Drawing.Point(175, 21);
			PictureBox4.Name = "PictureBox4";
			PictureBox4.Size = new System.Drawing.Size(120, 120);
			PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox4.TabIndex = 64;
			PictureBox4.TabStop = false;
			Label3.AutoSize = true;
			Label3.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.Location = new System.Drawing.Point(107, 100);
			Label3.Name = "Label3";
			Label3.Size = new System.Drawing.Size(62, 19);
			Label3.TabIndex = 65;
			Label3.Text = "Minutes";
			Label4.AutoSize = true;
			Label4.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.Location = new System.Drawing.Point(204, 100);
			Label4.Name = "Label4";
			Label4.Size = new System.Drawing.Size(62, 19);
			Label4.TabIndex = 66;
			Label4.Text = "Seconds";
			base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			base.ClientSize = new System.Drawing.Size(308, 254);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(lblTimeServerUrl);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			base.Controls.Add(lblSeconds);
			base.Controls.Add(lblMinutes);
			base.Controls.Add(lblHours);
			base.Controls.Add(Label14);
			base.Controls.Add(Label13);
			base.Controls.Add(PictureBox4);
			base.Controls.Add(lblTime);
			Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmCountdown";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Countdown App";
			((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void frmCountdown_Closing(object sender, CancelEventArgs e)
		{
			if (MessageBox.Show("Do you want to close the countdown and go back to the previous screen?", "Countdown App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				MyProject.Forms.frmMain.Show();
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void frmCountdown_Load(object sender, EventArgs e)
		{
			CountdownDuration = mdlSharedFunctions.CountdownTimeInSeconds;
			lblHours.Text = Strings.Format(CountdownDuration / 3600, "00");
			lblMinutes.Text = Strings.Format(CountdownDuration % 3600 / 60, "00");
			lblSeconds.Text = Strings.Format(CountdownDuration % 60, "00");
			lblTime.Text = Strings.Format(mdlSharedFunctions.CurrentTime, "HH:mm:ss");
			lblTimeServerUrl.Text = mdlSystemParameters.TimeServerUrl;
			checked
			{
				lblTimeServerUrl.Left = (int)Math.Round((double)(base.Width - lblTimeServerUrl.Width) / 2.0);
				base.TopMost = mdlSharedFunctions.MakeTopmostWin;
				if (mdlSharedFunctions.MakeTransparent)
				{
					base.Opacity = 0.35;
				}
				base.Left = Screen.PrimaryScreen.Bounds.Width - base.Width;
				base.Top = Screen.PrimaryScreen.Bounds.Height - (base.Height + 60);
				tmrTime.Enabled = true;
			}
		}

		private void tmrTime_Tick(object sender, EventArgs e)
		{
			try
			{
				lblTime.Text = Strings.Format(mdlSharedFunctions.CurrentTime, "HH:mm:ss");
				if (CountdownDuration > 0)
				{
					checked
					{
						CountdownDuration--;
					}
					lblHours.Text = Strings.Format(CountdownDuration / 3600, "00");
					lblMinutes.Text = Strings.Format(CountdownDuration % 3600 / 60, "00");
					lblSeconds.Text = Strings.Format(CountdownDuration % 60, "00");
					if (CountdownDuration == 0)
					{
						if (mdlSharedFunctions.AllowAudibleNotifications)
						{
							Console.Beep(500, 1000);
						}
						if (mdlSharedFunctions.RefreshBrowser)
						{
							mdlSharedFunctions.RefreshBrowserWindow();
						}
					}
					else if ((CountdownDuration < 10) & mdlSharedFunctions.AllowAudibleNotifications)
					{
						Console.Beep(500, 200);
					}
				}
				if (CountdownDuration < 30 && CountdownDuration > 0)
				{
					if (lblSeconds.ForeColor == Color.Red)
					{
						lblSeconds.ForeColor = Color.Black;
					}
					else
					{
						lblSeconds.ForeColor = Color.Red;
					}
				}
				else
				{
					lblSeconds.ForeColor = Color.Black;
				}
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
	}
}
