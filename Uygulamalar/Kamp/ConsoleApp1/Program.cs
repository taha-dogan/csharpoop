using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Aslı");
            isimler.Add("Ceyda");
            isimler.Add("Emre");
            isimler.Add("Ömer");
            isimler.Add("Taha");
            
            

            MyList<int> numaralar = new MyList<int>();

            for (int i = 0; i < isimler.getLength; i++)
            {
                numaralar.Add(i);
            }

            for(int i = 0; i<numaralar.getLength;i++)
            {
                int sirala = numaralar.GetValues(i) + 1;
                
                Console.WriteLine(sirala + " - " + isimler.GetValues(i));
            }

            Console.ReadLine();
        }
    }
}
