﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Faiz oranı x kadar.");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı.");
        }
    }
}
