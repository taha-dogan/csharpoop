using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //simüle ettiğimiz için nesne varmış gibi bu ürün listesini oluşturduk. Global değişken olduğundan _ kullanıldı.

        public InMemoryProductDal() //Class kullanıldığında simüle edeceğimiz verileri oluşturduğumuz constructor
        {
            _products = new List<Product>()
            {
                new Product() {ProductID = 1, CategoryID = 1, ProductName = "Bardak", UnitPrice = 200, UnitsInStock = 10},
                new Product() {ProductID = 2, CategoryID = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 100 },
                new Product() {ProductID = 3, CategoryID = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 186},
                new Product() {ProductID = 4, CategoryID = 2, ProductName = "Mouse", UnitPrice = 50, UnitsInStock = 154},
                new Product() {ProductID = 5, CategoryID = 2, ProductName = "Bilgisayar", UnitPrice = 3000, UnitsInStock = 70 },

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product) //silinecek olan veriyi parametre olarak verdik
        {
            Product productToDelete = null;

            foreach (var item in _products)
            {
                if (product.ProductID == item.ProductID)
                {
                    productToDelete = item;
                }
            }

            //Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID); (FOREACH YERİNE BU ŞEKİLDE DE YAZILABİLİR)

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products; //Tüm ürün tablosunu direkt olarak döndürür.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID/*istenilen*/)//Ürünleri kategoriye göre filtreler. E-Ticaret sitesinde solda kategorilerden seçim yapıldığında çalışacak olan buton.
        {
            //_products listesinde p'yi her değere gönder, bak. p.CategoryID eşitse, parametre ile istenen değer olan categoryID'ye eşitse, listeye çevir, gönder. 
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }


        /*product parametresini alır. Product sınıfından türetilen productToUpdate adında bir değişken oluşturur. 
          _products listesinin içerisinde gezer ve bu elemanları item ile tutar. Eğer item'ın tuttuğu ProductID eşitse parametre olarak gelen product
          nesnesinin ProductID'sine, başta tanımlanan productToUpdate değişkeni, item değerinde tutulan değere eşitlenir.*/

        public void Update(Product product) 
        {
            Product productToUpdate = null;

            foreach (var item in _products)
            {
                if (product.ProductID == item.ProductID)
                {
                    productToUpdate = item;
                }
            }

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryID = product.CategoryID;
        }
    }
}
