using System;

namespace Epam.Task1Part2
{
    static class ColorExtensions
    {
        public static void PrintAndOrderAllValues()
        {
           foreach(var color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine(color + " = " + (int)color);
            }
            
        }
    }
}
