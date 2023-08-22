using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Person
    {
        string name;
        string phonenumber;
        string password;
        string email;
        int balance;
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public int Balance { get => balance; set => balance = value; }

        public Person()
        {

        }
        public Person (string name, string email, string phonenumber, string password, int balance)
        {
            this.Name = name;
            this.Email = email;
            this.Phonenumber = phonenumber;
            this.Password = password;
            this.Balance = balance;
        }
    }
}
