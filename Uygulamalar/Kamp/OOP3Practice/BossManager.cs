using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Practice
{
    internal class BossManager : IUserManager
    {
        public void ShowUserName()
        {
            Console.WriteLine("Erkan Baran");
        }

        public void ShowUserSalary()
        {
            Console.WriteLine(100000);
        }

        public void ShowUserType()
        {
            Console.WriteLine("Managing the company");
        }
    }
}
