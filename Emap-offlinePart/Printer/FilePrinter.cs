using Printer.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Printer
{
    public class FilePrinter : IPrinter
    {
        private string filePath = Settings.Default.filePath;
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
