using System;
using System.IO;
using Logger.Properties;

namespace Epam.Logger
{
    public class FileLogger : ILogger
    {
        private string filePath = Settings.Default.filePath;
        void ILogger.WriteMessage(string message, LogLevel level)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(DateTime.Now + " " + level + "\n" + message + "\n");
                sw.Close();
            }
        }
        void ILogger.WriteMessage(string message, Exception ex, LogLevel level)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(DateTime.Now + " " + level + "\n" + ex.Message + message + "\n");
                sw.Close();
            }
        }
    }
}
