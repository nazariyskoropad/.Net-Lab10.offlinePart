using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
