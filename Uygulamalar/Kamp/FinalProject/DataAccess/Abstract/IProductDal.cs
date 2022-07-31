using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    //Veritabanı ile ilgili yapacağım operasyonları içeren interface(ekle,sil güncelle,filtrele) 
    public interface IProductDal : IEntityRepository<Product> // " : IEntityRepository<Product> "  = Sen bir IEntityRepositorysisin ve çalışma tipin Product'tır.
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);





        //List<Product> GetAllByCategory(int categoryID);
        ////Ürünleri kategoriye göre filtreler. E-Ticaret sitesinde solda kategorilerden seçim yapıldığında çalışacak olan buton.
    }
}
