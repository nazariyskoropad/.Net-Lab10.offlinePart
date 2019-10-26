using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Printer
{
    public interface IPrinter
    {
        void PrintLine(string text);
        void Print(string text);
    }
}
