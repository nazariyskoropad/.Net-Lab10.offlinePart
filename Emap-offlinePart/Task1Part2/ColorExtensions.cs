using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
