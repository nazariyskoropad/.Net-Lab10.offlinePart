using System;

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
