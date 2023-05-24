using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactoryLogger loggerFactory = new FileLoggerFactory();
            ILogger logger1 = loggerFactory.CreateLogger();
            logger1.Info("This is a txt file!");
            logger1.Error("Error Text");

            loggerFactory = new ConsoleLoggerFactory();
            logger1 = loggerFactory.CreateLogger();
            logger1.Info("This is a txt file!");
            logger1.Error("Error Text");
            Console.ReadLine();
        }
    }
}
