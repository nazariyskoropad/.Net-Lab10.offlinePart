using System;

namespace Epam.Logger
{
    public interface ILogger
    {
        void WriteMessage(string message, LogLevel level);
        void WriteMessage(string message, Exception ex, LogLevel level);
    }
}
