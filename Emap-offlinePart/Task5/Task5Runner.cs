using System;
using Epam.Printer;
using Epam.Reader;

namespace Epam.Task5
{
    public class Tusk5Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();

            printer.PrintLine("Enter the name of assembly");
            string assemblyName = reader.ReadLine();

            try
            {
                var components = ModulesVisualizer.GetAssemblyInfo(assemblyName);
                foreach (var component in components)
                {
                    printer.PrintLine(component);
                }                
            }
            catch(Exception ex)
            {
                printer.PrintLine(ex.Message);
            }
        }
    }
}
