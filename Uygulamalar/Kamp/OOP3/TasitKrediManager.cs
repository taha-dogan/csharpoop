using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Faiz oranı x kadar.");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı.");
        }
    }
}
