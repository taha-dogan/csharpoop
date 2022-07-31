using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    /*Veritabanındaki tablolar(örneğin product) ile Entities/Concrete klasörünün içindeki sınıfları (örneğin Product.cs) ilişkilendirmek için bu sınıfı kullanacağız (db tabloları ile proje classlarını ilişkilendirmek = context). İşte bu ilişkilendirme için Context denilen yapıyı kullanacağız.*/

    public class NorthwindContext : DbContext //EntityFramework ile DbContext adında base bir sınıf gelir.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override dedikten sonra on yazdık ve IDE bize önerdi.
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
            //Hangi veritabanı
        
        }

        public DbSet<Product>? Products { get; set; } //Hangi classı hangi tabloya
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Customer>? Customers { get; set; }

        //BİR HATA ÇIKARSA BURADAN KAYNAKLI OLABİLİR!!!!

    }
}
