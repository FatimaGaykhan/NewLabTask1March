using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLabTask1March.Models
{
    internal class User:Account
    {
        public string  FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email,string password)
        {
            Email = email;
            Password = password;
        }


        public void ShowInfo()
        {
            Console.WriteLine(  $"{Email} {FullName} {Password}");

        }


    }
}
