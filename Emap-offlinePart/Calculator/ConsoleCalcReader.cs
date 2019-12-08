using System;

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
