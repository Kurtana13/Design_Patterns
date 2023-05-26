using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    public interface Connection
    {
        void Connect();
        void Disconnect();
    }

    public interface Command
    {
        void Execute(string query);
    }

    public class SQLServerConnection : Connection
    {
        public void Connect()
        {
            Console.WriteLine("Connected to SQL Sever!");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from SQL Server");
        }
    }

    public class SQLServerCommand : Command
    {
        public void Execute(string query)
        {
            Console.WriteLine(query);
        }
    }

    public class OracleConnection : Connection
    {
        public void Connect()
        {
            Console.WriteLine("Connected to Oracle!");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from Oracle");
        }
    }

    public class OracleCommand : Command
    {
        public void Execute(string query)
        {
            Console.WriteLine(query);
        }
    }
}
