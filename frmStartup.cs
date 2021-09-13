// Decompiled with JetBrains decompiler
// Type: CountdownApp.frmStartup
// Assembly: CountdownApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FC7E3B5E-A665-400F-94A5-48F1DBB775B0
// Assembly location: C:\Users\Pika\Desktop\WaktuSimulasiAppv1.1.exe

using CountdownApp.My;
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
  public class frmStartup : Form
  {
    private IContainer components;

    public frmStartup()
    {
      this.Load += new EventHandler(this.frmStartup_Load);
      this.InitializeComponent();
    }

    private void btnActivateLicense_Click(object sender, EventArgs e)
    {
      try
      {
        if ((uint) Operators.CompareString(this.txtLicenseKey.Text, "", false) > 0U)
        {
          this.lblStatus.Text = "Validating the license details ......";
          Application.DoEvents();
          string Left = mdlSharedFunctions.ValidateLicense(this.txtLicenseKey.Text);
          if (Operators.CompareString(Left, "LICENSE_EXPIRED", false) == 0)
          {
            this.lblStatus.Text = "Sorry, the license key you have entered has expired.";
            int num = (int) MessageBox.Show("Sorry, the license key you have entered has expired. Please enter a different key.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtLicenseKey.Focus();
          }
          else if (Operators.CompareString(Left, "INVALID_PRODUCT", false) == 0)
          {
            this.lblStatus.Text = "Sorry, this license key is not meant to be used with this product.";
            int num = (int) MessageBox.Show("Sorry, this license key is not meant to be used with this product. Please use a different key.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtLicenseKey.Focus();
          }
          else if (Operators.CompareString(Left, "VALIDATION_ERROR", false) == 0)
          {
            this.lblStatus.Text = "Sorry, this license key is invalid.";
            int num = (int) MessageBox.Show("Sorry, the license key you have entered is not valid. Please enter a different key.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtLicenseKey.Focus();
          }
          else if (Operators.CompareString(Left, "LICENSE_VALID", false) == 0)
          {
            this.lblStatus.Text = "Activating the product ......";
            Application.DoEvents();
            if (Operators.CompareString(mdlSharedFunctions.ActivateLicense(this.txtLicenseKey.Text), "LICENSE_ACTIVATED", false) == 0)
            {
              if (MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\\CountdownApp") != null)
              {
                MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\CountdownApp", "LicenseKey", (object) mdlSharedFunctions.EncodeText(this.txtLicenseKey.Text));
              }
              else
              {
                MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\\CountdownApp");
                MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\CountdownApp", "LicenseKey", (object) mdlSharedFunctions.EncodeText(this.txtLicenseKey.Text));
              }
              this.lblStatus.Text = "Activation successful ......";
              Application.DoEvents();
              MyProject.Computer.Registry.CurrentUser.Close();
              MyProject.Forms.frmMain.Show();
              this.Close();
            }
            else
            {
              this.lblStatus.Text = "Sorry, an error occurred during the activation.";
              int num = (int) MessageBox.Show("Sorry, an error has occurred during the activation. Please check if you have exceeded the maximum activation count.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              this.txtLicenseKey.Focus();
            }
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Please enter a license key first.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.txtLicenseKey.Focus();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        mdlSharedFunctions.DumpErrLog(this.Name + ".btnActivateLicense_Click", ex.Message);
        int num = (int) MessageBox.Show("Countdown App has encountered an error. If you continue to experience this error, please contact the Portalkey support team.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.lblStatus.Text = "Sorry, an unknown error has occurred during the activation.";
        this.txtLicenseKey.Focus();
        ProjectData.ClearProjectError();
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to exit Countdown App?", "Countdown App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
        return;
      Application.Exit();
    }

    private void btnPurchaseLicense_Click(object sender, EventArgs e) => Process.Start(mdlSystemParameters.PurchaseUrl);

    private void frmStartup_Load(object sender, EventArgs e)
    {
      this.Height = 134;
      this.Width = 417;
      this.tmrStartup.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void tmrStartup_Tick(object sender, EventArgs e)
    {
      try
      {
        this.tmrStartup.Enabled = false;
        this.lblStatus.Text = "Making magic happen ......";
        Application.DoEvents();
        if (mdlSharedFunctions.IsConnected())
        {
          if (MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\\CountdownApp") != null)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\CountdownApp", "LicenseKey", (object) "NO_LICENSE"));
            if (Operators.CompareString(objectValue.ToString(), "NO_LICENSE", false) == 0)
            {
              MyProject.Computer.Registry.CurrentUser.Close();
              this.lblStatus.Text = "Sorry, the Countdown App could not find a valid license key.";
              int num = (int) MessageBox.Show("You need a valid license key to use Countdown App. If you have already purchased a key, please enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              this.Height = 233;
              this.Width = 417;
              this.txtLicenseKey.Focus();
            }
            else
            {
              this.lblStatus.Text = "Validating the license details ......";
              Application.DoEvents();
              string Left = mdlSharedFunctions.ValidateLicense(mdlSharedFunctions.DecodeText(objectValue.ToString()));
              if (Operators.CompareString(Left, "LICENSE_EXPIRED", false) == 0)
              {
                MyProject.Computer.Registry.CurrentUser.Close();
                this.lblStatus.Text = "Sorry, your license key has expired.";
                int num = (int) MessageBox.Show("Sorry, your license key has expired. If you have already purchased a new license, you can enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Height = 233;
                this.Width = 417;
                this.txtLicenseKey.Focus();
              }
              else if (Operators.CompareString(Left, "INVALID_PRODUCT", false) == 0)
              {
                MyProject.Computer.Registry.CurrentUser.Close();
                this.lblStatus.Text = "Sorry, your current license key is invalid.";
                int num = (int) MessageBox.Show("Your current license key is not intended to be used with this product. If you have already purchased a new license, you can enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Height = 233;
                this.Width = 417;
                this.txtLicenseKey.Focus();
              }
              else if (Operators.CompareString(Left, "VALIDATION_ERROR", false) == 0)
              {
                MyProject.Computer.Registry.CurrentUser.Close();
                int num = (int) MessageBox.Show("An error has occurred during the license validation. If you continue to receve this error, please contact Portalkey support team.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ProjectData.EndApp();
              }
              else if (Operators.CompareString(Left, "LICENSE_VALID", false) == 0)
              {
                MyProject.Computer.Registry.CurrentUser.Close();
                MyProject.Forms.frmMain.Show();
                this.Close();
              }
            }
          }
          else
          {
            MyProject.Computer.Registry.CurrentUser.Close();
            this.lblStatus.Text = "Sorry, the Countdown App could not find a valid license key.";
            int num = (int) MessageBox.Show("You need a valid license key to use Countdown App. If you have already purchased a key, please enter it here or you can purchase one from our website.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Height = 233;
            this.Width = 417;
            this.txtLicenseKey.Focus();
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Countdown App is unable to connect to the internet. The application will exit now.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.EndApp();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        mdlSharedFunctions.DumpErrLog(this.Name + ".tmrStartup_Tick", ex.Message);
        int num = (int) MessageBox.Show("Countdown App has encountered an error. If you continue to experience this error, please contact the Portalkey support team.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.EndApp();
        ProjectData.ClearProjectError();
      }
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
      this.Label1 = new Label();
      this.tmrStartup = new Timer(this.components);
      this.Label2 = new Label();
      this.PictureBox1 = new PictureBox();
      this.lblStatus = new Label();
      this.btnClose = new Button();
      this.txtLicenseKey = new TextBox();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.btnActivateLicense = new Button();
      this.btnPurchaseLicense = new Button();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Calibri", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label1.Location = new Point(128, 21);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(231, 39);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Countdown App";
      this.tmrStartup.Interval = 500;
      this.Label2.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label2.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(12, 77);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(393, 23);
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Karena semua orang butuh kepastian (waktu)";
      this.PictureBox1.Image = (Image) CountdownApp.My.Resources.Resources.Logoblue;
      this.PictureBox1.Location = new Point(12, 12);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(110, 62);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 2;
      this.PictureBox1.TabStop = false;
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new Point(12, 106);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new Size(159, 15);
      this.lblStatus.TabIndex = 3;
      this.lblStatus.Text = "Starting Countdown App ......";
      this.btnClose.Location = new Point(286, 195);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(119, 26);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.txtLicenseKey.Location = new Point(12, 161);
      this.txtLicenseKey.Name = "txtLicenseKey";
      this.txtLicenseKey.Size = new Size(393, 23);
      this.txtLicenseKey.TabIndex = 7;
      this.Label3.AutoSize = true;
      this.Label3.ForeColor = Color.Red;
      this.Label3.Location = new Point(128, 57);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(215, 15);
      this.Label3.TabIndex = 8;
      this.Label3.Text = "Approved by the Indonesian President";
      this.Label4.AutoSize = true;
      this.Label4.Location = new Point(12, 141);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(168, 15);
      this.Label4.TabIndex = 9;
      this.Label4.Text = "Please enter your license key:";
      this.Label5.BackColor = Color.LightGray;
      this.Label5.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.White;
      this.Label5.Location = new Point(4, 132);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(408, 1);
      this.Label5.TabIndex = 10;
      this.btnActivateLicense.Location = new Point(160, 195);
      this.btnActivateLicense.Name = "btnActivateLicense";
      this.btnActivateLicense.Size = new Size(119, 26);
      this.btnActivateLicense.TabIndex = 11;
      this.btnActivateLicense.Text = "Activate License";
      this.btnActivateLicense.UseVisualStyleBackColor = true;
      this.btnPurchaseLicense.Location = new Point(35, 195);
      this.btnPurchaseLicense.Name = "btnPurchaseLicense";
      this.btnPurchaseLicense.Size = new Size(119, 26);
      this.btnPurchaseLicense.TabIndex = 12;
      this.btnPurchaseLicense.Text = "Purchase License";
      this.btnPurchaseLicense.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(224, 224, 224);
      this.ClientSize = new Size(417, 233);
      this.Controls.Add((Control) this.btnPurchaseLicense);
      this.Controls.Add((Control) this.btnActivateLicense);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.txtLicenseKey);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.lblStatus);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (frmStartup);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Countdown App";
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Timer tmrStartup
    {
      get => this._tmrStartup;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrStartup_Tick);
        Timer tmrStartup1 = this._tmrStartup;
        if (tmrStartup1 != null)
          tmrStartup1.Tick -= eventHandler;
        this._tmrStartup = value;
        Timer tmrStartup2 = this._tmrStartup;
        if (tmrStartup2 == null)
          return;
        tmrStartup2.Tick += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblStatus")]
    internal virtual Label lblStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnClose
    {
      get => this._btnClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose_Click);
        Button btnClose1 = this._btnClose;
        if (btnClose1 != null)
          btnClose1.Click -= eventHandler;
        this._btnClose = value;
        Button btnClose2 = this._btnClose;
        if (btnClose2 == null)
          return;
        btnClose2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtLicenseKey")]
    internal virtual TextBox txtLicenseKey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnActivateLicense
    {
      get => this._btnActivateLicense;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnActivateLicense_Click);
        Button btnActivateLicense1 = this._btnActivateLicense;
        if (btnActivateLicense1 != null)
          btnActivateLicense1.Click -= eventHandler;
        this._btnActivateLicense = value;
        Button btnActivateLicense2 = this._btnActivateLicense;
        if (btnActivateLicense2 == null)
          return;
        btnActivateLicense2.Click += eventHandler;
      }
    }

    internal virtual Button btnPurchaseLicense
    {
      get => this._btnPurchaseLicense;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPurchaseLicense_Click);
        Button btnPurchaseLicense1 = this._btnPurchaseLicense;
        if (btnPurchaseLicense1 != null)
          btnPurchaseLicense1.Click -= eventHandler;
        this._btnPurchaseLicense = value;
        Button btnPurchaseLicense2 = this._btnPurchaseLicense;
        if (btnPurchaseLicense2 == null)
          return;
        btnPurchaseLicense2.Click += eventHandler;
      }
    }
  }
}
