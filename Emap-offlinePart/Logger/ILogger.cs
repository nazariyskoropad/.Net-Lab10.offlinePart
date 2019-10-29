using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Logger
{
    public interface ILogger
    {
        void WriteMessage(string message, LogLevel level);
        void WriteMessage(string message, Exception ex, LogLevel level);
    }
}
