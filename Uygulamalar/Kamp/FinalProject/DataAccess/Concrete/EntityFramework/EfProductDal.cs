using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //İstersen alanları aynı olan bir product gönder, yine de referanslarına ulaşman lazım.

                var addedEntity = context.Entry(entity); // Bunun anlamı: Git, veri kaynağından benim parametreden gelen değerim olan entity nesnesini bir tane nesneye eşleştir. Referansı yakaladık.
                addedEntity.State = EntityState.Added; //Yakalanan referansa göre ekleme komutunu verdik.
                context.SaveChanges(); //Değişiklikleri kaydet-gerçekleştir.

            }
        }

        public void Delete(Product entity)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public List<Product> GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Set<Product>().ToList();
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
