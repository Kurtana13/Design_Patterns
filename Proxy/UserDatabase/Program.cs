using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserDatabase userDatabase = new UserDatabase();
            IUserDatabase userDatabaseProxy = new UserDatabaseProxy(userDatabase);
            userDatabaseProxy.AddUser(new User("Demetre", 1000));
            userDatabaseProxy.AddUser(new User("Giorgi"));
            userDatabaseProxy.AddUser(new User("Avto", 2000));
            userDatabaseProxy.AddUser(new User("Avto"));

            userDatabaseProxy.RemoveBalance("Avto", 3000);
            userDatabaseProxy.AddBalance("Giorgi", 500);
            
            Console.ReadLine();
        }
    }
}
