﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    /*Business katmanında kurallar yazılır.
     * Entity tüm katmanlara hizmet verir. DataAccess ve Business tarafından kullanılır.
     * Business aynı zamanda DataAccess'i çağırır.
     * Bir class ismi Service ise o Business katmanında demektir.
     */
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryID(int id); //kategori id'sine göre verilerin getirilmesini istedik.
        List<Product> GetByUnitPrice(decimal min, decimal max);

    }
}
