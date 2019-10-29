using System;

using Epam.Printer;
using Epam.Reader;
using Epam.Task1Part1;
using Epam.Task1Part2;
using Epam.Task2;
using Epam.Task3;
using Epam.Task4;
using Epam.Task5;
using Epam.Logger;

using System.Configuration;

namespace Epam.TaskRunner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();

            //var task1Part1 = new Task1Runner();
            //task1Part1.Main();
            //printer.Clear();
            //var task1Part2 = new Task1Part2Runner();
            //task1Part2.Main();
            //printer.Clear();
            //var task2 = new Task2Runner();
            //task2.Main();
            //var task3 = new Task3Runner();
            //task3.Main();
            //var task4 = new Task4Runner();
            //task4.Main();
            //var task5 = new Tusk5Runner();
            //task5.Main();
            var logger = new LoggerCreator();
            try
            {
                int t = 0;
                int x = t/t;
            }
            catch(Exception ex)
            { 
            logger.Log(LogTarget.File, "Problem", ex, LogLevel.Debug);
            logger.Log(LogTarget.Console, "Problem", LogLevel.Error);
            }
        }
    }
}
