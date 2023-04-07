namespace UserDataBase
{
    public class User {
        private readonly string _username;
        private double _balance;
        public User(string username, double balance = 0)
        {
            _username = username;
            _balance = balance;
        }
        public string Username { get { return _username; } }
        public double Balance { get { return _balance; } set { _balance = value; } }
    }
    
}
