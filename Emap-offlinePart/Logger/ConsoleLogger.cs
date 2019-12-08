using System;

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
