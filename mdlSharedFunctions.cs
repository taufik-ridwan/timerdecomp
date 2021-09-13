// Decompiled with JetBrains decompiler
// Type: CountdownApp.mdlSharedFunctions
// Assembly: CountdownApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FC7E3B5E-A665-400F-94A5-48F1DBB775B0
// Assembly location: C:\Users\Pika\Desktop\WaktuSimulasiAppv1.1.exe

using CountdownApp.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CountdownApp
{
  [StandardModule]
  internal sealed class mdlSharedFunctions
  {
    public static DateTime CurrentTime;
    public static int CountdownTimeInSeconds;
    public static bool RefreshBrowser;
    public static bool MakeTopmostWin;
    public static bool MakeTransparent;
    public static bool AllowAudibleNotifications;
    public const int SW_RESTORE = 9;
    public const int SW_SHOW = 5;

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern int SetForegroundWindow(int hwnd);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool IsIconic(int hwnd);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern int ShowWindow(int hwnd, int nCmdShow);

    public static void FocusWindow(string strWindowCaption, string strClassName)
    {
      int window = mdlSharedFunctions.FindWindow(ref strClassName, ref strWindowCaption);
      if (window <= 0)
        return;
      mdlSharedFunctions.SetForegroundWindow(window);
      if (mdlSharedFunctions.IsIconic(window))
        mdlSharedFunctions.ShowWindow(window, 9);
      else
        mdlSharedFunctions.ShowWindow(window, 5);
    }

    public static string DecodeText(string InputText)
    {
      int length = InputText.Length;
      int Start = 1;
      string str;
      while (Start <= length)
      {
        str += Conversions.ToString(Strings.Chr(Conversions.ToInteger(Strings.Mid(InputText, Start, 3))));
        checked { Start += 3; }
      }
      return str;
    }

    public static string GetCSVSeg(string Record, int ColIndex, char SepChar)
    {
      int num1;
      if (ColIndex == 0)
      {
        num1 = 0;
      }
      else
      {
        int num2 = ColIndex;
        int num3 = 1;
        while (num3 <= num2)
        {
          num1 = Strings.InStr(checked (num1 + 1), Record, Conversions.ToString(SepChar));
          checked { ++num3; }
        }
      }
      int Start = checked (num1 + 1);
      int num4 = Strings.InStr(Start, Record, Conversions.ToString(SepChar));
      return num4 == 0 ? Strings.Mid(Record, Start, checked (Strings.Len(Record) - Start + 1)) : Strings.Mid(Record, Start, checked (num4 - Start));
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void DumpErrLog(string ProcedureName, string ErrorDescription)
    {
      try
      {
        StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\ErrorLog.txt", true);
        string str = Strings.StrDup(75, "`") + "\r\n" + "Timestamp: " + Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "\r\n" + "Procedure name: " + ProcedureName + "\r\n" + "Error description: " + ErrorDescription + "\r\n";
        streamWriter.Write(str);
        streamWriter.Close();
        streamWriter.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show("An error occurred while writing to the error log file. The application will now exit.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.EndApp();
        ProjectData.ClearProjectError();
      }
    }

    public static string EncodeText(string InputText)
    {
      int length = InputText.Length;
      int Start = 1;
      string str;
      while (Start <= length)
      {
        str += Strings.Format((object) Strings.Asc(Strings.Mid(InputText, Start, 1)), "000");
        checked { ++Start; }
      }
      return str;
    }

    public static bool IsConnected()
    {
      try
      {
        if (MyProject.Computer.Network.Ping(mdlSystemParameters.PingUrl))
          return true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return false;
    }

    public static DateTime GetDateTimeNtp()
    {
      DateTime dateTime = DateTime.MinValue;
      ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(mdlSharedFunctions.CertificateValidationCallBack);
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create("http://" + mdlSystemParameters.TimeServerUrl);
      httpWebRequest.Method = "GET";
      httpWebRequest.Accept = "text/html, application/xhtml+xml, */*";
      httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
      httpWebRequest.ContentType = "application/x-www-form-urlencoded";
      httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
      HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      if (response.StatusCode == HttpStatusCode.OK)
        dateTime = DateTime.ParseExact(response.Headers["date"], "ddd, dd MMM yyyy HH:mm:ss 'GMT'", (IFormatProvider) CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
      response.Close();
      return dateTime;
    }

    private static bool CertificateValidationCallBack(
      object Sender,
      X509Certificate Certificate,
      X509Chain Chain,
      SslPolicyErrors SslPolicyError)
    {
      return true;
    }

    public static string ValidateLicense(string LicenseKey)
    {
      string str;
      try
      {
        WebRequest webRequest = WebRequest.Create(mdlSystemParameters.LicenseServerUrl + LicenseKey);
        webRequest.Credentials = (ICredentials) new NetworkCredential(mdlSystemParameters.LicenseServerUsername, mdlSystemParameters.LicenseServerPassword);
        WebResponse response = webRequest.GetResponse();
        if (Operators.CompareString(((HttpWebResponse) response).StatusDescription, "OK", false) == 0)
        {
          StreamReader streamReader = new StreamReader(response.GetResponseStream());
          string end = streamReader.ReadToEnd();
          string Left = Strings.Mid(mdlSharedFunctions.GetCSVSeg(end, 3, ','), 13, 5);
          string s = Strings.Mid(mdlSharedFunctions.GetCSVSeg(end, 6, ','), 14, 19);
          if ((uint) Operators.CompareString(Left, mdlSystemParameters.ProductId, false) > 0U)
          {
            streamReader.Close();
            response.Close();
            str = "INVALID_PRODUCT";
          }
          else if (DateTime.Compare(DateTime.ParseExact(s, "yyyy-MM-dd HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal), mdlSharedFunctions.GetDateTimeNtp()) > 0)
          {
            streamReader.Close();
            response.Close();
            str = "LICENSE_VALID";
          }
          else
          {
            streamReader.Close();
            response.Close();
            str = "LICENSE_EXPIRED";
          }
        }
        else
        {
          response.Close();
          str = "VALIDATION_ERROR";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        mdlSharedFunctions.DumpErrLog("mdlSharedFunctions.ValidateLicense", ex.Message);
        str = "VALIDATION_ERROR";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static string ActivateLicense(string LicenseKey)
    {
      string str;
      try
      {
        WebRequest webRequest = WebRequest.Create(mdlSystemParameters.LicenseServerUrl + "activate/" + LicenseKey);
        webRequest.Credentials = (ICredentials) new NetworkCredential(mdlSystemParameters.LicenseServerUsername, mdlSystemParameters.LicenseServerPassword);
        WebResponse response = webRequest.GetResponse();
        if (Operators.CompareString(((HttpWebResponse) response).StatusDescription, "OK", false) == 0)
        {
          response.Close();
          str = "LICENSE_ACTIVATED";
        }
        else
        {
          response.Close();
          str = "ACTIVATION_ERROR";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        mdlSharedFunctions.DumpErrLog("mdlSharedFunctions.ActivateLicense", ex.Message);
        str = "ACTIVATION_ERROR";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static void RefreshBrowserWindow()
    {
      Process[] processesByName1 = Process.GetProcessesByName("chrome");
      int index1 = 0;
      while (index1 < processesByName1.Length)
      {
        Process process = processesByName1[index1];
        if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "CHROME") > 0)
        {
          mdlSharedFunctions.FocusWindow(process.MainWindowTitle, (string) null);
          SendKeys.Send("{F5}");
          return;
        }
        checked { ++index1; }
      }
      Process[] processesByName2 = Process.GetProcessesByName("firefox");
      int index2 = 0;
      while (index2 < processesByName2.Length)
      {
        Process process = processesByName2[index2];
        if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "FIREFOX") > 0)
        {
          mdlSharedFunctions.FocusWindow(process.MainWindowTitle, (string) null);
          SendKeys.Send("{F5}");
          return;
        }
        checked { ++index2; }
      }
      Process[] processesByName3 = Process.GetProcessesByName("msedge");
      int index3 = 0;
      while (index3 < processesByName3.Length)
      {
        Process process = processesByName3[index3];
        if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "EDGE") > 0)
        {
          mdlSharedFunctions.FocusWindow(process.MainWindowTitle, (string) null);
          SendKeys.Send("{F5}");
          return;
        }
        checked { ++index3; }
      }
      Process[] processesByName4 = Process.GetProcessesByName("opera");
      int index4 = 0;
      while (index4 < processesByName4.Length)
      {
        Process process = processesByName4[index4];
        if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "OPERA") > 0)
        {
          mdlSharedFunctions.FocusWindow(process.MainWindowTitle, (string) null);
          SendKeys.Send("{F5}");
          return;
        }
        checked { ++index4; }
      }
      Process[] processesByName5 = Process.GetProcessesByName("brave");
      int index5 = 0;
      while (index5 < processesByName5.Length)
      {
        Process process = processesByName5[index5];
        if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "BRAVE") > 0)
        {
          mdlSharedFunctions.FocusWindow(process.MainWindowTitle, (string) null);
          SendKeys.Send("{F5}");
          return;
        }
        checked { ++index5; }
      }
      Process[] processesByName6 = Process.GetProcessesByName("iexplore");
      int index6 = 0;
      while (index6 < processesByName6.Length)
      {
        Process process = processesByName6[index6];
        if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "INTERNET EXPLORER") > 0)
        {
          mdlSharedFunctions.FocusWindow(process.MainWindowTitle, (string) null);
          SendKeys.Send("{F5}");
          break;
        }
        checked { ++index6; }
      }
    }
  }
}
