
using Epam.Printer;
using Epam.Reader;
using Epam.Task1Part1;
using Epam.Task1Part2;
using Epam.Task2;
using Epam.Task3;
using Epam.Task4;
using Epam.Task5;
using Epam.Task6;
using Epam.Calc;

namespace Epam.TaskRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }     

        private static void RunMenu()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();
            while (true)
            {
                printer.PrintLine("Enter task number to run task (1-7) or `calc` or `skypetask` or any other value to quit");
                string taskNumber = reader.ReadLine();
                bool continueLooping = true;
                switch (taskNumber)
                {
                    case "1":
                        {
                            printer.PrintLine("Enter part number to run task (1 or 2) or any other value to quit");
                            string partNumber = reader.ReadLine();
                            switch (partNumber)
                            {
                                case "1":
                                    {
                                        var task1Part1 = new Task1Runner();
                                        task1Part1.Main();
                                        break;
                                    }
                                case "2":
                                    {
                                        var task1Part2 = new Task1Part2Runner();
                                        task1Part2.Main();
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case "2":
                        {
                            var task2 = new Task2Runner();
                            task2.Main();
                            break;
                        }
                    case "3":
                        {
                            var task3 = new Task3Runner();
                            task3.Main();
                            break;
                        }
                    case "4":
                        {
                            var task4 = new Task4Runner();
                            task4.Main();
                            break;
                        }
                    case "5":
                        {
                            var task5 = new Tusk5Runner();
                            task5.Main();
                            break;
                        }
                    case "6":
                        {
                            var task6 = new Task6Runner();
                            task6.Main();
                            break;
                        }
                    case "7":
                        {
                            var task7 = new Epam.Task7.Task7Runner();
                            task7.Main();
                            break;
                        }
                    case "skypetask":
                        {
                            printer.PrintLine("Enter variant" +
                                " (1 or 2) or any other value to quit");
                            string partNumber = reader.ReadLine();
                            switch (partNumber)
                            {
                                case "1":
                                    {
                                        var skypetask = new Epam.TaskFromSkype1Variant1.Task7Runner();
                                        skypetask.Main();
                                        break;
                                    }
                                case "2":
                                    {
                                        var skypetask = new Epam.TaskFromSkype1Variant2.Task7Runner();
                                        skypetask.Main();
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;

                        }
                    case "calc":
                        {
                            var taskCalc = new CalculatorRunner();
                            taskCalc.Main();
                            break;
                        }
                    default:
                        {
                            continueLooping = false;
                            break;
                        }
                }
                if (!continueLooping)
                    break;
            }
        }
    }
}
