using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Calc
{
    public class ConsoleCalcReader : ICalcReader
    {
        int ICalcReader.ReadParamether()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
