using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class User
    {
        List<User> users = new List<User>();
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public static User Login()
        {
            string email = Console.ReadLine();
            string password = Console.ReadLine();
            User user = new User(email, password);
            Console.WriteLine($"Welcome {user.Username}");
            return new User(email, password);
        }
        public static User Register(List<User> users)
        {
            
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            User user = new User(username, password);
            if (username == user.Username)
            {
                Console.WriteLine("You cant have same names");
                return null;
            }
            
            users.Add(user);
            return user;
            
        }
        public static bool PasswordChecker(string password)
        {
            bool haveUpper = false;
            bool haveLower = false;
            //bool haveSymbol = false;
            if (password.Length < 8)
            {
                return false;
            }
            
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    haveUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    haveLower = true;
                }
            }
            if(haveUpper && haveLower)
            {
                return true;
            }
            return false;
        }
    }
    
}
