using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User : Person
    {
        DateTime signupdate;
        DateTime subscriptionDate;
        string imageName;
        int subscriptionDays;
        public DateTime SignupDate { get => signupdate; set => signupdate = value; }
        public DateTime SubscriptionDate { get => subscriptionDate; set => subscriptionDate = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public int SubscriptionDays { get => subscriptionDays; set => subscriptionDays = value; }

        public User()
        {

        }
        public User(string name, string email, string phonenumber, string password, int balance, string imagename, DateTime Signupdate) : base(name, email, phonenumber, password, balance)
        {
            this.ImageName = imagename;
            this.SignupDate = signupdate;
            this.SubscriptionDays = 30;
            this.SubscriptionDate = SignupDate.AddDays(SubscriptionDays);
        }
    }
}
