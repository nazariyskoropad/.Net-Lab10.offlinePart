using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Printer;

namespace Epam.Calc
{
    public class CalculatorRunner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            var calculator = new Epam.Calc.Calculator(Source.File);
            try
            {
                var result = calculator.calculate(calculator.reader.ReadParamether(),
                    calculator.reader.ReadParamether(), Operation.Plus);
                printer.PrintLine("result = " + result.ToString());
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }
        }
    }
}
