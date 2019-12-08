using System;
using System.Collections.Generic;
using System.Linq;
using Epam.Task3;
using Epam.Printer;
using Epam.Reader;
using System.Diagnostics;

namespace Epam.TaskFromSkype1Variant2
{
    public class Task7Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();
                
            try
            {
                printer.PrintLine("Enter first path to directory");
                var path1 = reader.ReadLine();
                var fileList1 = DirectoryVisualizer.GetFilesFromDirectory(path1);

                printer.PrintLine("Enter second path to directory");
                var path2 = reader.ReadLine();
                var fileList2 = DirectoryVisualizer.GetFilesFromDirectory(path2);

                var watch = new Stopwatch();
                watch.Start();
                var uniqueFiles = CompareFiles.GetUniqueFiles(fileList1 as List<string>, fileList2 as List<string>);
                var commonFiles = CompareFiles.GetCommonFiles(fileList1 as List<string>, fileList2 as List<string>);
                watch.Stop();

                printer.PrintLine("Enter 1 to print info on console or 2 to print info to file");
                string FileOrConsole = reader.ReadLine();
                switch (FileOrConsole)
                {
                    case "1":
                        {
                            Print(commonFiles.ToList(), uniqueFiles.ToList(), new ConsolePrinter());                           
                            break;
                        }
                    case "2":
                        {                      
                            Print(commonFiles.ToList(), uniqueFiles.ToList(), new FilePrinter());
                            break;
                        }
                    default:
                        {
                            printer.PrintLine("You entered wrong symbol");
                            break;
                        }
                }

                printer.PrintLine("\nExecution task time = " + watch.ElapsedMilliseconds + " ms");
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
                return;
            }

        }
        private void Print(List<string> commonFiles, List<string> uniqueFiles, IPrinter _printer)
        {
            IPrinter printer = _printer;
            printer.PrintLine("\n\n\tUnique Files:");
            foreach (var file in uniqueFiles)
                printer.PrintLine(file);

            printer.PrintLine("\n\n\tCommon Files:");
            foreach (var file in commonFiles)
                printer.PrintLine(file);
            printer.PrintLine("Number of common files = " + commonFiles.ToList().Count);
            printer.PrintLine("-----------------------------------");
        }
       
    }
}
