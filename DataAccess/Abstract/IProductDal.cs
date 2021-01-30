﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal //operasyonları yapacağım interface
        //interfacein kendisi değil operasyonları public
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);//ürünleri kategoriye göre filtrele demek
        
    }
}