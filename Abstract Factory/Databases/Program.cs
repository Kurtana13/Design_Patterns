using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseFactory sqlFactory = new SQLServerFactory();
            Connection sqlConnection = sqlFactory.CreateConnection();
            Command sqlCommand = sqlFactory.CreateCommand();

            sqlConnection.Connect();
            sqlCommand.Execute("Select * from Database");

            Console.ReadLine();
        }
    }
}
