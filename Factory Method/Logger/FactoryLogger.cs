using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    interface IFactoryLogger
    {
        ILogger CreateLogger();
    }

    public class FileLoggerFactory : IFactoryLogger
    {
        ILogger IFactoryLogger.CreateLogger()
        {
            return new FileLogger();
        }
    }

    public class ConsoleLoggerFactory : IFactoryLogger
    {
        ILogger IFactoryLogger.CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}
