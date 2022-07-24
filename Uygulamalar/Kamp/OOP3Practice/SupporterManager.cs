using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Practice
{
    internal class SupporterManager : IUserManager
    {
        public void ShowUserName()
        {
            Console.WriteLine("Emre Değirmenci");
        }

        public void ShowUserSalary()
        {
            Console.WriteLine(2000);
        }

        public void ShowUserType()
        {
            Console.WriteLine("Supporting from outside.");
        }
    }
}
