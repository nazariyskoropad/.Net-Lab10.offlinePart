using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Logger
{
    public class LoggerCreator
    {
        public ILogger logger;
        public void Log(LogTarget target, string message, LogLevel level)
        {
            switch (target)
            {
                case LogTarget.File:
                {
                    logger = new FileLogger();
                    logger.WriteMessage(message, level);
                    break;
                }
                case LogTarget.Console:
                {
                    logger = new ConsoleLogger();
                    logger.WriteMessage(message, level);
                    break;
                }
            }
        }

        public void Log(LogTarget target, string message, Exception ex, LogLevel level)
        {
            switch (target)
            {
                case LogTarget.File:
                    {
                        logger = new FileLogger();
                        logger.WriteMessage(message, ex, level);
                        break;
                    }
                case LogTarget.Console:
                    {
                        logger = new ConsoleLogger();
                        logger.WriteMessage(message, ex, level);
                        break;
                    }
            }
        }
    }
}
