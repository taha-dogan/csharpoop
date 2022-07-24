using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> logIt = new List<ILoggerService>() { smsLoggerService,fileLoggerService,databaseLoggerService};

            basvuruManager.BasvuruYap(esnafKrediManager, logIt);

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //IKrediManager konutKrediManager = new KonutKrediManager();



            //ihtiyacKrediManager.Hesapla();
            //tasitKrediManager.Hesapla();
            //konutKrediManager.Hesapla();




            //DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();




            //List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.BasvuruOnBilgilendirmesiYap(krediler);


            Console.ReadLine();

        }
    }
}
