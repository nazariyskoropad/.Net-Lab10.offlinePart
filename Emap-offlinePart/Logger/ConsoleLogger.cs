using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void WriteMessage(string message, LogLevel level)
        {
            Console.WriteLine(level);
            Console.WriteLine(message);
        }

        public void WriteMessage(string message, Exception ex, LogLevel level)
        {
            Console.WriteLine(level);
            Console.WriteLine(message);
            Console.WriteLine(ex.Message);
        }
    }
}
