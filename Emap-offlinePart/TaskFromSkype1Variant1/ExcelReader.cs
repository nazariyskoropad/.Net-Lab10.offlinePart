using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.IO;

namespace Epam.TaskFromSkype1Variant1
{
    /// <summary>
    /// Contains a method that reads info from excel file
    /// </summary>
    public class ExcelReader
    {
        public IDictionary<string, string> GetData(string columnName, int startRange, string inputFileName)
        {
            Dictionary<string, string> elements = new Dictionary<string, string>();

            using (FileStream inputStream = new FileStream(inputFileName, FileMode.Open))
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputStream);
                IWorksheet worksheet = workbook.Worksheets[0];

                int i = startRange;
                string data = null;
                do
                {
                    data = worksheet.Range[$"{columnName}{i}"].Text;
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        elements.Add($"{columnName}{i}", data);
                    }
                    ++i;
                }
                while (!string.IsNullOrWhiteSpace(data));
            }
            return elements;
        }
    }
}
