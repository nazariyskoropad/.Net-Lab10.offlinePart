using Printer.Properties;
using System;
using System.IO;

namespace Epam.Printer
{
    public class FilePrinter : IPrinter
    {
        public string filePath = Settings.Default.filePath;
        void IPrinter.Clear()
        {
            throw new NotImplementedException();
        }

        void IPrinter.Print(string text)
        {
            throw new NotImplementedException();
        }

        void IPrinter.PrintLine(string text)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {               
                sw.WriteLine(text);
                sw.Close();
            }
        }
    }
}
