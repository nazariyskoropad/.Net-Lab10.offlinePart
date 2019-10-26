using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Printer
{
    public class ConsolePrinter : IPrinter
    {
        void IPrinter.PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        void IPrinter.Print(string text)
        {
            Console.Write(text);
        }
    }
}
