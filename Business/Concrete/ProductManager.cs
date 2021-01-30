using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları varsa
            //Yetkisi var mı? geçerse bana ürünleri verebilirsin diyor. Çünkü ben kurallardan geçtim diyor.
            
            return _productDal.GetAll();
        }
        //busineesın bilfdiği tek şey IProductDal dır.

    }
}
