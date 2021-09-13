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
using CountdownApp.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

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

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int SetForegroundWindow(int hwnd);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool IsIconic(int hwnd);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int ShowWindow(int hwnd, int nCmdShow);

		public static void FocusWindow(string strWindowCaption, string strClassName)
		{
			int num = FindWindow(ref strClassName, ref strWindowCaption);
			if (num > 0)
			{
				SetForegroundWindow(num);
				if (IsIconic(num))
				{
					ShowWindow(num, 9);
				}
				else
				{
					ShowWindow(num, 5);
				}
			}
		}

		public static string DecodeText(string InputText)
		{
			int length = InputText.Length;
			string text = default(string);
			for (int i = 1; i <= length; i = checked(i + 3))
			{
				text += Conversions.ToString(Strings.Chr(Conversions.ToInteger(Strings.Mid(InputText, i, 3))));
			}
			return text;
		}

		public static string GetCSVSeg(string Record, int ColIndex, char SepChar)
		{
			checked
			{
				int num = default(int);
				if (ColIndex == 0)
				{
					num = 0;
				}
				else
				{
					for (int i = 1; i <= ColIndex; i++)
					{
						num = Strings.InStr(num + 1, Record, Conversions.ToString(SepChar));
					}
				}
				num++;
				int num2 = Strings.InStr(num, Record, Conversions.ToString(SepChar));
				if (num2 == 0)
				{
					return Strings.Mid(Record, num, Strings.Len(Record) - num + 1);
				}
				return Strings.Mid(Record, num, num2 - num);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void DumpErrLog(string ProcedureName, string ErrorDescription)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\ErrorLog.txt", append: true);
				string text = Strings.StrDup(75, "`") + "\r\n";
				text = text + "Timestamp: " + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "\r\n";
				text = text + "Procedure name: " + ProcedureName + "\r\n";
				text = text + "Error description: " + ErrorDescription + "\r\n";
				streamWriter.Write(text);
				streamWriter.Close();
				streamWriter.Dispose();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("An error occurred while writing to the error log file. The application will now exit.", "Countdown App", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}

		public static string EncodeText(string InputText)
		{
			int length = InputText.Length;
			string text = default(string);
			for (int i = 1; i <= length; i = checked(i + 1))
			{
				text += Strings.Format(Strings.Asc(Strings.Mid(InputText, i, 1)), "000");
			}
			return text;
		}

		public static bool IsConnected()
		{
			try
			{
				if (MyProject.Computer.Network.Ping(mdlSystemParameters.PingUrl))
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return false;
		}

		public static DateTime GetDateTimeNtp()
		{
			DateTime result = DateTime.MinValue;
			ServicePointManager.ServerCertificateValidationCallback = CertificateValidationCallBack;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + mdlSystemParameters.TimeServerUrl);
			httpWebRequest.Method = "GET";
			httpWebRequest.Accept = "text/html, application/xhtml+xml, */*";
			httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				string s = httpWebResponse.Headers["date"];
				result = DateTime.ParseExact(s, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
			}
			httpWebResponse.Close();
			return result;
		}

		private static bool CertificateValidationCallBack(object Sender, X509Certificate Certificate, X509Chain Chain, SslPolicyErrors SslPolicyError)
		{
			return true;
		}

		public static string ValidateLicense(string LicenseKey)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(mdlSystemParameters.LicenseServerUrl + LicenseKey);
				webRequest.Credentials = new NetworkCredential(mdlSystemParameters.LicenseServerUsername, mdlSystemParameters.LicenseServerPassword);
				WebResponse response = webRequest.GetResponse();
				if (Operators.CompareString(((HttpWebResponse)response).StatusDescription, "OK", TextCompare: false) == 0)
				{
					Stream responseStream = response.GetResponseStream();
					StreamReader streamReader = new StreamReader(responseStream);
					string record = streamReader.ReadToEnd();
					string left = Strings.Mid(GetCSVSeg(record, 3, ','), 13, 5);
					string s = Strings.Mid(GetCSVSeg(record, 6, ','), 14, 19);
					if (Operators.CompareString(left, mdlSystemParameters.ProductId, TextCompare: false) != 0)
					{
						streamReader.Close();
						response.Close();
						return "LICENSE_VALID";
					}
					if (DateTime.Compare(DateTime.ParseExact(s, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal), GetDateTimeNtp()) > 0)
					{
						streamReader.Close();
						response.Close();
						return "LICENSE_VALID";
					}
					streamReader.Close();
					response.Close();
					return "LICENSE_VALID";
				}
				response.Close();
				return "LICENSE_VALID";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DumpErrLog("mdlSharedFunctions.ValidateLicense", ex2.Message);
				string result = "VALIDATION_ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string ActivateLicense(string LicenseKey)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(mdlSystemParameters.LicenseServerUrl + "activate/" + LicenseKey);
				webRequest.Credentials = new NetworkCredential(mdlSystemParameters.LicenseServerUsername, mdlSystemParameters.LicenseServerPassword);
				WebResponse response = webRequest.GetResponse();
				if (Operators.CompareString(((HttpWebResponse)response).StatusDescription, "OK", TextCompare: false) == 0)
				{
					response.Close();
					return "LICENSE_ACTIVATED";
				}
				response.Close();
				return "ACTIVATION_ERROR";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DumpErrLog("mdlSharedFunctions.ActivateLicense", ex2.Message);
				string result = "ACTIVATION_ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static void RefreshBrowserWindow()
		{
			Process[] processesByName = Process.GetProcessesByName("chrome");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				if (Strings.InStr(Strings.UCase(process.MainWindowTitle), "CHROME") > 0)
				{
					FocusWindow(process.MainWindowTitle, null);
					SendKeys.Send("{F5}");
					return;
				}
			}
			Process[] processesByName2 = Process.GetProcessesByName("firefox");
			Process[] array2 = processesByName2;
			foreach (Process process2 in array2)
			{
				if (Strings.InStr(Strings.UCase(process2.MainWindowTitle), "FIREFOX") > 0)
				{
					FocusWindow(process2.MainWindowTitle, null);
					SendKeys.Send("{F5}");
					return;
				}
			}
			Process[] processesByName3 = Process.GetProcessesByName("msedge");
			Process[] array3 = processesByName3;
			foreach (Process process3 in array3)
			{
				if (Strings.InStr(Strings.UCase(process3.MainWindowTitle), "EDGE") > 0)
				{
					FocusWindow(process3.MainWindowTitle, null);
					SendKeys.Send("{F5}");
					return;
				}
			}
			Process[] processesByName4 = Process.GetProcessesByName("opera");
			Process[] array4 = processesByName4;
			foreach (Process process4 in array4)
			{
				if (Strings.InStr(Strings.UCase(process4.MainWindowTitle), "OPERA") > 0)
				{
					FocusWindow(process4.MainWindowTitle, null);
					SendKeys.Send("{F5}");
					return;
				}
			}
			Process[] processesByName5 = Process.GetProcessesByName("brave");
			Process[] array5 = processesByName5;
			foreach (Process process5 in array5)
			{
				if (Strings.InStr(Strings.UCase(process5.MainWindowTitle), "BRAVE") > 0)
				{
					FocusWindow(process5.MainWindowTitle, null);
					SendKeys.Send("{F5}");
					return;
				}
			}
			Process[] processesByName6 = Process.GetProcessesByName("iexplore");
			Process[] array6 = processesByName6;
			foreach (Process process6 in array6)
			{
				if (Strings.InStr(Strings.UCase(process6.MainWindowTitle), "INTERNET EXPLORER") > 0)
				{
					FocusWindow(process6.MainWindowTitle, null);
					SendKeys.Send("{F5}");
					break;
				}
			}
		}
	}
}
