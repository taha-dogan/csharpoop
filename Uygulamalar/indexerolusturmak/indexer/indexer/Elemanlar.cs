using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //eklenmesi gerekli



/*
 Index operatörleri 3 farklı yerde kullanılabilir:
    -Array
    -Indexer
    -Attributes( [Serializable] gibi)

Indexerlar özel tanımlı bir propertie'dir.

 */
namespace indexer
{
   class Elemanlar
    {
        ArrayList Dizi = new ArrayList();
        public object this[int IndexNo] //indekser tanımlaması yapıldı
        {
            get
            {
                if((IndexNo>0)&&(IndexNo < Dizi.Count))
                {
                    return Dizi[IndexNo]; //varsa
                }
                else
                {
                    return null; //0 indis numarası yok
                }
            }
            set
            {
                if ((IndexNo > 0) && (IndexNo < Dizi.Count))
                {
                    Dizi[IndexNo] = value; //değiştir
                }
                else
                {
                    Dizi.Add(value); //ekle
                }

            }
        }
    }
}
