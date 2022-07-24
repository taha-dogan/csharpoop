using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class EsnafKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Faiz oranı x kadar.");
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
