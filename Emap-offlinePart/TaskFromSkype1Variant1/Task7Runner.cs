using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;
using Epam.Printer;
using System.Diagnostics;
using TaskFromSkype1Variant1.Properties;

namespace Epam.TaskFromSkype1Variant1
{
    public class Task7Runner
    {
        public void Main()
        {
            string firstCol = Settings.Default.firstColumn;
            string secondCol = Settings.Default.secondColumn;
            string inputFile = Settings.Default.inputFile;
            int firstColStartRange = Settings.Default.firstStartIndex;
            int secondColStartRange = Settings.Default.secondStartIndex;
            IPrinter printer = new ConsolePrinter();
          
            var reader = new ExcelReader();
            try
            {
                var watch = new Stopwatch();
                watch.Start();

                var firstRange = reader.GetData(firstCol, firstColStartRange, inputFile);
                var secondRange = reader.GetData(secondCol, secondColStartRange, inputFile);

                var resultRange = GetUniqueElements(firstRange as Dictionary<string, string>, 
                    secondRange as Dictionary<string, string>);

                watch.Stop();
                switch (Settings.Default.outputTarget)
                {
                    case "Console":
                        {
                            Print(resultRange, new ConsolePrinter());
                            break;
                        }
                    case "File":
                        {
                            Print(resultRange, new FilePrinter());
                            break;
                        }
                }
                printer.PrintLine("Project execution time = " + watch.ElapsedMilliseconds + "ms");
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

        }
        private Dictionary<string, string> GetUniqueElements(Dictionary<string, string> firstRange,
            Dictionary<string, string> secondRange)
        {
            Dictionary<string, string> resultRange = new Dictionary<string, string>();

            foreach (var first in firstRange)
            {
                if (!(secondRange as Dictionary<string, string>).ContainsValue(first.Value))
                    resultRange.Add(first.Key, first.Value);
            }

            foreach (var second in secondRange)
            {
                if (!(firstRange as Dictionary<string, string>).ContainsValue(second.Value))
                    resultRange.Add(second.Key, second.Value);
            }

            return resultRange;
        }
        private void Print(Dictionary<string,string> dict,  IPrinter _printer)
        {
            IPrinter printer = _printer;
            if ((printer as FilePrinter) != null)
                (printer as FilePrinter).filePath = Settings.Default.outputFile;

            foreach (var word in dict)
                printer.PrintLine("[" + word.Key + "]" + " = " + word.Value);         
        }
    }
}
