using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDataBase
{

    public interface IUserDatabase
    {
        User FindUser(string username);
        void AddUser(User user);
        void AddBalance(string username,double balance);
        void RemoveBalance(string username, double balance);
    }

    public class UserDatabase:IUserDatabase
    {
        private List<User> _users = new List<User>();

        public User FindUser(string username)
        {
            return _users.FirstOrDefault(x => x.Username == username);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void AddBalance(string username,double balance)
        {
            FindUser(username).Balance += balance;
        }

        public void RemoveBalance(string username, double balance)
        {
            FindUser(username).Balance -= balance;
        }

    }
    
}
