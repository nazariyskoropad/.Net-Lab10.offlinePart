using Epam.Printer;
using Epam.Reader;
using System;

namespace Epam.DiService
{
    public class TaskRunner
    {
        public void Main()
        {
            var services = new ServiceCollector();
            services.RegisterTransient<IPrinter, ConsolePrinter>();

            var IoCcontainer = services.CreateContainer();

            var printer = IoCcontainer.GetService<IPrinter>();

            printer.PrintLine("Printer was taken from IoC container");

            try
            {
            var x = IoCcontainer.GetService<IReader>();
            printer.PrintLine("reader hit");
            }
            catch(Exception ex)
            {
                printer.PrintLine(ex.Message);
            }     
        }
    }
}
