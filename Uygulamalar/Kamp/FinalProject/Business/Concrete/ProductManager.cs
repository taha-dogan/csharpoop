using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService //Repository ile business katmanının iş kodları zamanla birbirinden ayrılabildiğinden IEntityRepository ile çağırma yapmadık.
    {
        //İş için verilen şartlar burada olacak(kullanıcı ilk 1 ay en fazla 10 ürün satabilir gibi)
        
        
        IProductDal _productDal; //Tüm DataAccess verileri bu değişkende. GetAll() metodunun içerisinde ilk yorumda açıklanan sebepten ötürü dependency injection yaparız. Bu nesne ile DataAccess sınıfını kullanan bir nesne tanımlamış olduk.

        public ProductManager(IProductDal productDal) //Bildiğimiz temel constructor mantığını burada çalıştırdık.productDal nesnesini constructor metod ile ilişkilendirdik. Böylece program.cs ile bu sınıf nesnesini çağırdığımızda parametre olarak verilere hangi yöntem ile erişmek istediğimizi belirteceğiz(örneğin InMemory, EntityFramework vb.).
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Aşağıdaki gibi yazıldığında iş kodlarının tamamı bellek ile çalışır.InMemoryProductDal bağımlı oluruz. Bir iş sınıfı başka sınıfları newlemez.
            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            return _productDal.GetAll();
        
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
