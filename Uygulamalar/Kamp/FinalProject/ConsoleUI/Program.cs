using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ConsoleUI referans olarak tüm sınıları alır. (ConsoleUI / sağ tık / Add / Project referance / hepsi seçilir). DataAccess'e direkt bağlantı kurmayacağız ama IOC Container'dan ötürü bu yordam izlenir.*/
            //ProductManager productManager = new ProductManager(new EfProductDal() /*InMemoryProductDal referansını vererek hafızada çalışacağımızı belirttik*/);
            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);

            //}

            ProductManager productManager = new ProductManager(new EfProductDal() /*InMemoryProductDal referansını vererek hafızada çalışacağımızı belirttik*/);
            foreach (var item in productManager.GetAllByCategoryID(2))
            {
                Console.WriteLine("Product ID : " + item.ProductID + "  ==== Product name : " + item.ProductName + "  ==== Unit price : " + item.UnitPrice);
            }
        }
    }
}