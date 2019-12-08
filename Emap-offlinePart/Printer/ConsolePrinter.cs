using System;

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

        void IPrinter.Clear()
        {
            Console.Clear();
        }
    }
}
