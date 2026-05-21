using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slopjekt.Classes
{
    public class DebugLogger
    {
        public static void WriteDebug(string Text, DebugType debugType)
        {
			try
			{
				StreamWriter write = new("DebugLog.txt", true, Encoding.UTF8);
                string debugText = $"{debugType}: " + Text + $" {DateTime.Now}";
                write.WriteLine(debugText);
                write.Close();
			}
			catch (Exception e)
			{
				throw;
			}
        }
    }

    public enum DebugType
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Other = 3,
    }
}
