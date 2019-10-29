using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task3;
using Epam.Printer;
using Epam.Reader;

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

                var uniqueFiles = CompareFiles.GetUniqueFiles(fileList1 as List<string>, fileList2 as List<string>);
                var commonFiles = CompareFiles.GetCommonFiles(fileList1 as List<string>, fileList2 as List<string>);

                printer.PrintLine("Enter 1 to print info on console or 2 to print info to file");
                string FileOrConsole = reader.ReadLine();
                switch (FileOrConsole)
                {
                    case "1":
                        {
                            ConsolePrint(commonFiles.ToList(), uniqueFiles.ToList());
                            break;
                        }
                    case "2":
                        {
                            FilePrint(commonFiles.ToList(), uniqueFiles.ToList());
                            break;
                        }
                    default:
                        {
                            printer.PrintLine("You entered wrong symbol");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
                return;
            }

        }
        private void ConsolePrint(List<string> commonFiles, List<string> uniqueFiles)
        {
            IPrinter printer = new ConsolePrinter();
            printer.PrintLine("\n\n\tUnique Files:");
            foreach (var file in uniqueFiles)
                printer.PrintLine(file);

            printer.PrintLine("\n\n\tCommon Files:");
            foreach (var file in commonFiles)
                printer.PrintLine(file);
            printer.PrintLine("Number of common files = " + commonFiles.ToList().Count);
        }

        private void FilePrint(List<string> commonFiles, List<string> uniqueFiles)
        {
            IPrinter printer = new FilePrinter();

            printer.PrintLine("\t\t\nCommon files");
            foreach (var file in commonFiles)
                printer.PrintLine(file);
            printer.PrintLine("Number of common files = " + commonFiles.ToList().Count);

            printer.PrintLine("\t\t\nUnique Files");
            foreach (var file in uniqueFiles)
                printer.PrintLine(file);         
        }
    }
}
