using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Practice
{
    internal class WorkerManager : IUserManager
    {
        public void ShowUserName()
        {
            Console.WriteLine("Taha Doğan");
        }

        public void ShowUserSalary()
        {
            Console.WriteLine(10000);
        }

        public void ShowUserType()
        {
            Console.WriteLine("Computer engineer for company.");
        }
    }
}
