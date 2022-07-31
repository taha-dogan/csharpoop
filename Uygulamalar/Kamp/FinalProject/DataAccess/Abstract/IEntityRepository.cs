using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T: class,IEntities,new()//Buradaki T'ye sadece classlarımızın gelmesini isteriz (int, string, List gelsin istemeyiz). Bu sınırlandırma işine de Generic Constraint(Jenerik Kısıt) denir. Bunu sınırlandırmak için where sorgusu kullanılır. Sonuna yazılan class buraya sadece class gelebileceğini değil, buraya sadece referans gelebilir demektir. ",IEntities" demek ise, IEntities türünde olan classları alabilir demektir. Bunun yapılmasının sebebi de her class türünde olan referansların gelmemesi içindir. Ancak oraya IEntities'de gelebilir :D. IEntities gelmemesi için new() yazarsak newlenebilir bir referans gelmelidir de demiş oluruz. Böylelikle interface classlar da yazılamaz.
    {

        //IProductDal, ICategoryDal gibi sınıflarda tipleri elle değiştirmemek için bu generic yapıyı tanımlıyoruz.
        //GetAll() içerisinde parametre vererek verileri filtrelememize yazayan Expressions tanımlayalım. Çünkü gerçek çalışma ortamında hiçbir zaman verilerin tamamını çekme ihtiyacı duymayacağız.
        
        
        List<T> GetAll(Expression <Func<T,bool>> filter = null); //Filtre zorunlu değil.
        T Get(Expression<Func<T, bool>> filter); //Bu operasyonu da tek bir data getirmek için kullanıyoruz. Filtre zorunlu. 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
