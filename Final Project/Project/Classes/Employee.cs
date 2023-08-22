using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Employee : Person
    {
        int salary;
        string imageFileName;
        public int Salary { get => salary; set => salary = value; }
        public string ImageFileName { get => imageFileName; set => imageFileName = value; }
        public Employee()
        {

        }
        public Employee(string name, string phonenumber, string email, string password, int salary, string imageFileName) : base(name, phonenumber, email, password, 0)
        {
            Salary = salary;
            ImageFileName = imageFileName;
        }
        public void addMember()
        {
            throw new System.NotImplementedException();
        }
        
    }
}
