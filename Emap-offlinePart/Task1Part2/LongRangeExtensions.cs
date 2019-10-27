using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1Part2

{
    static class LongRangeExtensions
    {
        public static void PrintAllValues()
        {
            foreach(var value in Enum.GetValues(typeof(LongRange)))
            {
                Console.WriteLine(value + " = " + (long)value);
            }
        }
    }
}
