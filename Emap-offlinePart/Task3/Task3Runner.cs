using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Printer;
using Epam.Reader;
using System.Configuration;

namespace Epam.Task3
{
    public class Task3Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();

            printer.PrintLine("Task 3.1");
            printer.PrintLine("Enter path to directory");
            var path = reader.ReadLine();

            try
            {
                var files = DirectoryVisualizer.GetFilesFromDirectory(path);
                printer.PrintLine("Result:");
                foreach (var file in files)
                    printer.PrintLine(file);
            }
            catch(Exception ex)
            {
                printer.PrintLine(ex.Message);
            }
            printer.PrintLine("\n_________________________\nTask 3.2");
            printer.PrintLine("Enter a part of filename");
            try
            {
                var partName = reader.ReadLine();
                var files = FileFinder.findAllFiles(partName);

                foreach (var file in files)
                    printer.PrintLine(file);
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }


            Console.ReadKey();      
        }
    }
}
