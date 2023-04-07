using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace UserDataBase
{
    public class UserDatabaseProxy : IUserDatabase
    {
        private readonly IUserDatabase _userDatabase;
        public UserDatabaseProxy(IUserDatabase userDatabase)
        {
            _userDatabase = userDatabase;
        }

        public User FindUser(string username)
        {
            return _userDatabase.FindUser(username);
        }

        public void AddBalance(string username, double balance)
        {
            User user = FindUser(username);
            if (balance > 0 && balance < 1000)
            {
                user.Balance += balance;
            } 
            else
            {
                Console.WriteLine("Amount must be between 0-1000");
            }
        }

        public void AddUser(User user)
        {
            if(FindUser(user.Username) == null)
            {
                _userDatabase.AddUser(user);
                return;
            }
            if (IsValid(user.Username)) 
            {
                _userDatabase.AddUser(user);
            }
            else
            {
                Console.WriteLine($"User exists with the username {user.Username}!");
            }
        }

        public void RemoveBalance(string username, double balance)
        {
            User user = _userDatabase.FindUser(username);
            if(user.Balance >= balance)
            {
                user.Balance -= balance;
            }
            else
            {
                Console.WriteLine($"Your balance: {user.Balance}, Your withdraw amount {balance}.");
            }
        }

        private bool IsValid(string username) { 
            return _userDatabase.FindUser(username) == null;
        }
    }
}
