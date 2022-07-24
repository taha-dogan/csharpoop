using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericYapilar2
{
    internal class MyList<T>
    {
        public T[] tampon;

        public MyList()
        {
            tampon = new T[0];
        }

        public void Add(T eklenecek)
        {
            T[] yedek = tampon;

            tampon = new T[tampon.Length + 1];

            for (int i = 0; i < yedek.Length; i++)
            {
                tampon[i] = yedek[i];
            }

            tampon[tampon.Length - 1] = eklenecek;
        }

        

        public void Add(T eklenecek1,T eklenecek2)
        {
            T[] yedek = tampon;

            tampon = new T[tampon.Length + 2];

            for(int i = 0; i < yedek.Length;i++)
            {
                tampon[i] = yedek[i];
            }

            tampon[tampon.Length-2] = eklenecek1;
            tampon[tampon.Length-1] = eklenecek2;
        }

        public int getLength
        {
            get { return tampon.Length; }
        }

        public T GetValues(int i)
        {
            return tampon[i];
        }


    }
}
