using System;

using Epam.Printer;
using Epam.Reader;
using System.Reflection;
using Epam.Task1Part1;
using Epam.Task1Part2;

namespace Epam.TaskRunner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();
            //printer.Print("kappa");

            //Type type = Type.GetType("Epam.Printer.IPrinter");

            //foreach (var memberInfo in type.GetMembers())
            //    printer.Print(memberInfo.Name);
            var task1Part1 = new Task1Runner();
            task1Part1.Main();
            printer.Clear();
            var task1Part2 = new Task1Part2Runner();
            task1Part2.Main();


            //Lab1.Program.Main();
        }

    }
}
