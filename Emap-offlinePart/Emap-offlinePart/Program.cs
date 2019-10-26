using System;

using Epam.Printer;
using System.Reflection;
using Epam.Task1;
//using Epam.Task1;

namespace Epam.TaskRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPrinter printer = new ConsolePrinter();
            //printer.Print("kappa");

            //Type type = Type.GetType("Epam.Printer.IPrinter");

            //foreach (var memberInfo in type.GetMembers())
            //    printer.Print(memberInfo.Name);
            var task1 = new Task1.Task1Runner();
            task1.Main();
            


            //Lab1.Program.Main();
        }

    }
}
