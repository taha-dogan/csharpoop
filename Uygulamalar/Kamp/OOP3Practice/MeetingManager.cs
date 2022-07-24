using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Practice
{
    internal class MeetingManager
    {
        public void RememberThePerson(List<IUserManager> person)
        {
            foreach (var item in person)
            {
                item.ShowUserName();
                item.ShowUserType();
                item.ShowUserSalary();
            }
        }

        public void SayHiToThePerson(List<IUserManager> person)
        {
            foreach (var item in person)
            {
                
                Console.Write("Hi ");
                item.ShowUserName();
            }
        }
    }
}
