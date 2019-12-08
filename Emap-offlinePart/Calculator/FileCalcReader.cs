using Calculator.Properties;
using System;
using System.IO;

namespace Epam.Calc
{
    public class FileCalcReader : ICalcReader
    {
        public string filePath = Settings.Default.filePath;
        string line;
        int lineNumber = 1;
        int ICalcReader.ReadParamether()
        {
            using (StreamReader sw = new StreamReader(filePath, true))
            {
                for (int i = 0; i < lineNumber; i++)
                    line = sw.ReadLine();
                lineNumber++;
            }
            return Convert.ToInt32(line);
        }
    }
}
