using Epam.Printer;
using Epam.Reader;
using System;
using System.Diagnostics;

namespace Epam.Task7
{
    public class Task7Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();
            int n;
            int m;
            int threadCount;
            printer.PrintLine("Task on threads\nEnter size of matrix to generate and to find the sum of all elements");
            while (true)
            {
                try
                {
                    printer.PrintLine("Enter n:");
                    n = Convert.ToInt32(reader.ReadLine());
                    printer.PrintLine("Enter m:");
                    m = Convert.ToInt32(reader.ReadLine());
                    break;
                }
                catch
                {
                    printer.PrintLine("You entered wrong size. Try again\n");
                }
            }
            var matrix = new Matrix(n, m);

            while(true)
            {
                try
                {
                    printer.PrintLine("Enter a number of threads:");
                    threadCount = Convert.ToInt32(reader.ReadLine());
                    break;
                }
                catch
                {
                    printer.PrintLine("You entered wrong number of threads. Try again\n");;
                }
            }

            var threads = new Threads(threadCount);

            var watch = new Stopwatch();
            watch.Start();
            int sumFromThreads = threads.GetSumOfMatrixElements(matrix);
            watch.Stop();

            printer.PrintLine("sum from threads = " + sumFromThreads);
            var _sum = matrix.GetSumOfAllElements();

            printer.PrintLine("real sum = " + _sum);
            printer.PrintLine("Execution time = " + watch.ElapsedMilliseconds + " ms");
        }
    }
}
