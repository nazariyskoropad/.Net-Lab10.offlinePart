using System;

namespace Epam.Reader
{
    public class ConsoleReader : IReader
    {
        string IReader.ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
