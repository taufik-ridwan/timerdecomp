using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CountdownApp.My;
using CountdownApp.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace CountdownApp
{
	[DesignerGenerated]
	public class frmStartup : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tmrStartup")]
		private Timer _tmrStartup;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lblStatus")]
		private Label _lblStatus;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtLicenseKey")]
		private TextBox _txtLicenseKey;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnActivateLicense")]
		private Button _btnActivateLicense;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPurchaseLicense")]
		private Button _btnPurchaseLicense;

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Timer tmrStartup
		{
			[CompilerGenerated]
			get
			{
				return _tmrStartup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = tmrStartup_Tick;
				Timer timer = _tmrStartup;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				_tmrStartup = value;
				timer = _tmrStartup;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PictureBox1")]
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblStatus")]
		internal virtual Label lblStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnClose
		{
			[CompilerGenerated]
			get
			{
				return _btnClose;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnClose_Click;
				Button button = _btnClose;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnClose = value;
				button = _btnClose;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtLicenseKey")]
		internal virtual TextBox txtLicenseKey
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnActivateLicense
		{
			[CompilerGenerated]
			get
			{
				return _btnActivateLicense;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnActivateLicense_Click;
				Button button = _btnActivateLicense;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnActivateLicense = value;
				button = _btnActivateLicense;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnPurchaseLicense
		{
			[CompilerGenerated]
			get
			{
				return _btnPurchaseLicense;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPurchaseLicense_Click;
				Button button = _btnPurchaseLicense;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPurchaseLicense = value;
				button = _btnPurchaseLicense;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmStartup()
		{
			base.Load += frmStartup_Load;
			InitializeComponent();
		}

		private void btnActivateLicense_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txtLicenseKey.Text, "", TextCompare: false) != 0)
				{
					lblStatus.Text = "Validating the license details ......";
					Application.DoEvents();
					switch (mdlSharedFunctions.ValidateLicense(txtLicenseKey.Text))
					{
					case "LICENSE_EXPIRED":
						lblStatus.Text = "Sorry, the license key you have entered has expired.";
						MessageBox.Show("Sorry, the license key you have entered has expired. Please enter a different key.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						txtLicenseKey.Focus();
						break;
					case "INVALID_PRODUCT":
						lblStatus.Text = "Sorry, this license key is not meant to be used with this product.";
						MessageBox.Show("Sorry, this license key is not meant to be used with this product. Please use a different key.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						txtLicenseKey.Focus();
						break;
					case "VALIDATION_ERROR":
						lblStatus.Text = "Sorry, this license key is invalid.";
						MessageBox.Show("Sorry, the license key you have entered is not valid. Please enter a different key.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						txtLicenseKey.Focus();
						break;
					case "LICENSE_VALID":
						lblStatus.Text = "Activating the product ......";
						Application.DoEvents();
						if (Operators.CompareString(mdlSharedFunctions.ActivateLicense(txtLicenseKey.Text), "LICENSE_ACTIVATED", TextCompare: false) == 0)
						{
							if (MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\\CountdownApp") != null)
							{
								MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\CountdownApp", "LicenseKey", mdlSharedFunctions.EncodeText(txtLicenseKey.Text));
							}
							else
							{
								RegistryKey registryKey = MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\\CountdownApp");
								MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\CountdownApp", "LicenseKey", mdlSharedFunctions.EncodeText(txtLicenseKey.Text));
							}
							lblStatus.Text = "Activation successful ......";
							Application.DoEvents();
							MyProject.Computer.Registry.CurrentUser.Close();
							MyProject.Forms.frmMain.Show();
							Close();
						}
						else
						{
							lblStatus.Text = "Sorry, an error occurred during the activation.";
							MessageBox.Show("Sorry, an error has occurred during the activation. Please check if you have exceeded the maximum activation count.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							txtLicenseKey.Focus();
						}
						break;
					}
				}
				else
				{
					MessageBox.Show("Please enter a license key first.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txtLicenseKey.Focus();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mdlSharedFunctions.DumpErrLog(base.Name + ".btnActivateLicense_Click", ex2.Message);
				MessageBox.Show("Countdown App has encountered an error. If you continue to experience this error, please contact the Portalkey support team.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				lblStatus.Text = "Sorry, an unknown error has occurred during the activation.";
				txtLicenseKey.Focus();
				ProjectData.ClearProjectError();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit Countdown App?", "Countdown App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnPurchaseLicense_Click(object sender, EventArgs e)
		{
			Process.Start(mdlSystemParameters.PurchaseUrl);
		}

		private void frmStartup_Load(object sender, EventArgs e)
		{
			base.Height = 134;
			base.Width = 417;
			tmrStartup.Enabled = true;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void tmrStartup_Tick(object sender, EventArgs e)
		{
			try
			{
				tmrStartup.Enabled = false;
				lblStatus.Text = "Making magic happen ......";
				Application.DoEvents();
				if (mdlSharedFunctions.IsConnected())
				{
					if (MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\\CountdownApp") != null)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\CountdownApp", "LicenseKey", "NO_LICENSE"));
						if (Operators.CompareString(objectValue.ToString(), "NO_LICENSE", TextCompare: false) == 0)
						{
							MyProject.Computer.Registry.CurrentUser.Close();
							lblStatus.Text = "Sorry, the Countdown App could not find a valid license key.";
							MessageBox.Show("You need a valid license key to use Countdown App. If you have already purchased a key, please enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Height = 233;
							base.Width = 417;
							txtLicenseKey.Focus();
							return;
						}
						lblStatus.Text = "Validating the license details ......";
						Application.DoEvents();
						switch (mdlSharedFunctions.ValidateLicense(mdlSharedFunctions.DecodeText(objectValue.ToString())))
						{
						case "LICENSE_EXPIRED":
							MyProject.Computer.Registry.CurrentUser.Close();
							lblStatus.Text = "Sorry, your license key has expired.";
							MessageBox.Show("Sorry, your license key has expired. If you have already purchased a new license, you can enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Height = 233;
							base.Width = 417;
							txtLicenseKey.Focus();
							break;
						case "INVALID_PRODUCT":
							MyProject.Computer.Registry.CurrentUser.Close();
							lblStatus.Text = "Sorry, your current license key is invalid.";
							MessageBox.Show("Your current license key is not intended to be used with this product. If you have already purchased a new license, you can enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Height = 233;
							base.Width = 417;
							txtLicenseKey.Focus();
							break;
						case "VALIDATION_ERROR":
							MyProject.Computer.Registry.CurrentUser.Close();
							MessageBox.Show("An error has occurred during the license validation. If you continue to receve this error, please contact Portalkey support team.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							ProjectData.EndApp();
							break;
						case "LICENSE_VALID":
							MyProject.Computer.Registry.CurrentUser.Close();
							MyProject.Forms.frmMain.Show();
							Close();
							break;
						}
					}
					else
					{
						MyProject.Computer.Registry.CurrentUser.Close();
						lblStatus.Text = "Sorry, the Countdown App could not find a valid license key.";
						MessageBox.Show("You need a valid license key to use Countdown App. If you have already purchased a key, please enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						base.Height = 233;
						base.Width = 417;
						txtLicenseKey.Focus();
					}
				}
				else
				{
					MessageBox.Show("Countdown App is unable to connect to the internet. The application will exit now.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.EndApp();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mdlSharedFunctions.DumpErrLog(base.Name + ".tmrStartup_Tick", ex2.Message);
				MessageBox.Show("Countdown App has encountered an error. If you continue to experience this error, please contact the Portalkey support team.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
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
			Label1 = new System.Windows.Forms.Label();
			tmrStartup = new System.Windows.Forms.Timer(components);
			Label2 = new System.Windows.Forms.Label();
			PictureBox1 = new System.Windows.Forms.PictureBox();
			lblStatus = new System.Windows.Forms.Label();
			btnClose = new System.Windows.Forms.Button();
			txtLicenseKey = new System.Windows.Forms.TextBox();
			Label3 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			btnActivateLicense = new System.Windows.Forms.Button();
			btnPurchaseLicense = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			Label1.AutoSize = true;
			Label1.Font = new System.Drawing.Font("Calibri", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
			Label1.Location = new System.Drawing.Point(128, 21);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(231, 39);
			Label1.TabIndex = 0;
			Label1.Text = "Countdown App";
			tmrStartup.Interval = 500;
			Label2.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
			Label2.Font = new System.Drawing.Font("Calibri", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.Color.White;
			Label2.Location = new System.Drawing.Point(12, 77);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(393, 23);
			Label2.TabIndex = 1;
			Label2.Text = "Karena semua orang butuh kepastian (waktu)";
			PictureBox1.Image = CountdownApp.My.Resources.Resources.Logoblue;
			PictureBox1.Location = new System.Drawing.Point(12, 12);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new System.Drawing.Size(110, 62);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 2;
			PictureBox1.TabStop = false;
			lblStatus.AutoSize = true;
			lblStatus.Location = new System.Drawing.Point(12, 106);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new System.Drawing.Size(159, 15);
			lblStatus.TabIndex = 3;
			lblStatus.Text = "Starting Countdown App ......";
			btnClose.Location = new System.Drawing.Point(286, 195);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(119, 26);
			btnClose.TabIndex = 6;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			txtLicenseKey.Location = new System.Drawing.Point(12, 161);
			txtLicenseKey.Name = "txtLicenseKey";
			txtLicenseKey.Size = new System.Drawing.Size(393, 23);
			txtLicenseKey.TabIndex = 7;
			Label3.AutoSize = true;
			Label3.ForeColor = System.Drawing.Color.Red;
			Label3.Location = new System.Drawing.Point(128, 57);
			Label3.Name = "Label3";
			Label3.Size = new System.Drawing.Size(215, 15);
			Label3.TabIndex = 8;
			Label3.Text = "Approved by the Indonesian President";
			Label4.AutoSize = true;
			Label4.Location = new System.Drawing.Point(12, 141);
			Label4.Name = "Label4";
			Label4.Size = new System.Drawing.Size(168, 15);
			Label4.TabIndex = 9;
			Label4.Text = "Please enter your license key:";
			Label5.BackColor = System.Drawing.Color.LightGray;
			Label5.Font = new System.Drawing.Font("Calibri", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.Color.White;
			Label5.Location = new System.Drawing.Point(4, 132);
			Label5.Name = "Label5";
			Label5.Size = new System.Drawing.Size(408, 1);
			Label5.TabIndex = 10;
			btnActivateLicense.Location = new System.Drawing.Point(160, 195);
			btnActivateLicense.Name = "btnActivateLicense";
			btnActivateLicense.Size = new System.Drawing.Size(119, 26);
			btnActivateLicense.TabIndex = 11;
			btnActivateLicense.Text = "Activate License";
			btnActivateLicense.UseVisualStyleBackColor = true;
			btnPurchaseLicense.Location = new System.Drawing.Point(35, 195);
			btnPurchaseLicense.Name = "btnPurchaseLicense";
			btnPurchaseLicense.Size = new System.Drawing.Size(119, 26);
			btnPurchaseLicense.TabIndex = 12;
			btnPurchaseLicense.Text = "Purchase License";
			btnPurchaseLicense.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			base.ClientSize = new System.Drawing.Size(417, 233);
			base.Controls.Add(btnPurchaseLicense);
			base.Controls.Add(btnActivateLicense);
			base.Controls.Add(Label5);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(txtLicenseKey);
			base.Controls.Add(btnClose);
			base.Controls.Add(lblStatus);
			base.Controls.Add(PictureBox1);
			base.Controls.Add(Label2);
			base.Controls.Add(Label1);
			Font = new System.Drawing.Font("Calibri", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmStartup";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Countdown App";
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
