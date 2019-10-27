using System;

using Epam.Printer;
using Epam.Reader;
using System.Reflection;
using Epam.Task1Part1;
using Epam.Task1Part2;
using Epam.Task2;

namespace Epam.TaskRunner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();

            var task1Part1 = new Task1Runner();
            task1Part1.Main();
            printer.Clear();
            var task1Part2 = new Task1Part2Runner();
            task1Part2.Main();
            printer.Clear();
            var task2 = new Task2Runner();
            task2.Main();

        }
    }
}
