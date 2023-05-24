using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    interface ILogger
    {
        void Info(string message);
        void Warn(string message);  
        void Error(string message);
    }

    public class FileLogger : ILogger
    {
        private string path = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "FileLog.txt");
        public void Error(string message)
        {
            Write("Error", message);
        }

        public void Info(string message)
        {
            Write("Info", message);
        }

        public void Warn(string message)
        {
            Write("Warning", message);
        }

        private void Write(string level,string message) 
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"Error Level:{level}, {message}");
            }
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine($"Error Level: Error, {message}");
        }

        public void Info(string message)
        {
            Console.WriteLine($"Error Level: Info, {message}");
        }

        public void Warn(string message)
        {
            Console.WriteLine($"Error Level: Warning, {message}");
        }
    }
}
