using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Paxton.Net2.OemSample.GetEventDescriptions
{
	public class Logging
	{
		public static string GenerateDefaultLogFileName(string BaseFileName)
		{
			return AppDomain.CurrentDomain.BaseDirectory + "\\" + BaseFileName + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + ".log";
		}

		/// <summary>
		/// Pass in the fully qualified name of the log file you want to write to
		/// and the message to write
		/// </summary>
		/// <param name="LogPath"></param>
		/// <param name="Message"></param>

		public static void WriteToLog(string Message)
		{

			string logPath = Application.StartupPath + @"\ApplicationLogging.txt";

			try
			{
				if (File.Exists(logPath))
				{
					FileInfo fi = new FileInfo(logPath);
					long fileLength = fi.Length;
					if (fileLength > 100000)
					{
						File.Delete(logPath);
					}

				}

				using (StreamWriter s = File.AppendText(logPath))
				{
					s.WriteLine(DateTime.Now + "\t" + Message);
					//s.WriteLine();
				}
			}

			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		/// <summary>
		/// Writes a message to the application event log
		/// /// </summary>
		/// <param name="Source">Source is the source of the message ususally you will want this to be the application name</param>
		/// <param name="Message">message to be written</param>
		/// <param name="EntryType">the entry type to use to categorize the message like for exmaple error or information</param>

		public static void WriteToEventLog(string Source, string Message, System.Diagnostics.EventLogEntryType EntryType)
		{
			try
			{
				if (!EventLog.SourceExists(Source))
				{
					EventLog.CreateEventSource(Source, Application.ProductName);
				}
				EventLog.WriteEntry(Source, Message, EntryType);
			}

			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}
	}
}
