using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    public interface DatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }

    public class SQLServerFactory : DatabaseFactory
    {
        public Command CreateCommand()
        {
            return new SQLServerCommand();
        }

        public Connection CreateConnection()
        {
            return new SQLServerConnection();
        }
    }

    public class OracleFactory : DatabaseFactory
    {
        public Command CreateCommand()
        {
            return new OracleCommand();
        }

        public Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
