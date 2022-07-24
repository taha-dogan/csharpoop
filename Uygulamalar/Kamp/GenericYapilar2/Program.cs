using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericYapilar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgele;
            MyList<int> veriler = new MyList<int>();

            for (int i = 0; i<10; i++)
            {
                rastgele = rnd.Next(101);
                veriler.Add(rastgele);
            }

            MyList<int> index = new MyList<int>();
            for (int i = 0; i < veriler.getLength; i++)
            {
                index.Add(i);
            }

            Console.WriteLine("İndex - Veriler");

            for (int i = 0; i < index.getLength; i++)
            {
                Console.WriteLine(index.GetValues(i) + " - " + veriler.GetValues(i));
            }

            Console.ReadLine();
        }
    }
}
