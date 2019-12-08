using System;
using Epam.Printer;
using Epam.Reader;

namespace Epam.Task1Part2
{
    public class Task1Part2Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();

            printer.PrintLine("Task 1.2");
            try
            {
                printer.PrintLine("enter value 1-12");
                int n = Convert.ToInt32(reader.ReadLine()) - 1;
                if (n <= 0 || n > 12)
                    throw new ArgumentException("Valuse must be between 1 and 12");
                Console.WriteLine((Months)n);
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

            printer.PrintLine("___________________________");
            ColorExtensions.PrintAndOrderAllValues();

            printer.PrintLine("___________________________");
            LongRangeExtensions.PrintAllValues();
        }
    }
}
