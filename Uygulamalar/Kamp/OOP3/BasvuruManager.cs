using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            foreach (var item in loggerService)
            {

                krediManager.Hesapla();
                item.Log();
            }
        }

        public void BasvuruOnBilgilendirmesiYap(List<IKrediManager> krediManager)
        {
            foreach (var item in krediManager)
            {
                item.Hesapla();
                item.BiseyYap();
            }
        }
    }
}
