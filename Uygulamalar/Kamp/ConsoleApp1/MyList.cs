using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyList<T>
    {
        public T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int getLength
        {
            get { return items.Length; }
        }

        public T GetValues(int i)
        {
            return items[i];
        }
    }
}
