using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserManager emre = new SupporterManager();
            IUserManager taha = new WorkerManager();
            IUserManager erkan = new BossManager();

            emre.ShowUserName();
            taha.ShowUserName();
            erkan.ShowUserName();

            List<IUserManager> toplanti = new List<IUserManager>() { erkan,taha,emre};
            MeetingManager meetingManager = new MeetingManager();
            meetingManager.RememberThePerson(toplanti);
            meetingManager.SayHiToThePerson(toplanti);



            Console.Read();
        }
    }
}
