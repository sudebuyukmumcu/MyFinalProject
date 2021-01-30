using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //ınmemory bizim için bellekte sanki data varmış gibi bir ortamı oluşturucaz.
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //bu referans tip tek başına bir anlam ifade etmez. Bu proje başlayınca bellekte bir ürün listesi oluştur.
                                 //cunstructor bellekte referans aldığında çalışacak olan bloktur.
                   //ctor tab tab yparız ve alttaki oluşur.
        public InMemoryProductDal()
        {
            //Oracle,sql server,Postgre,MongoDb,excel den gelen datalarmış gibi;
            _products = new List<Product> {
            new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
            new Product{ProductId=2, CategoryId=1, ProductName ="Kamera", UnitPrice=500, UnitsInStock=3},
            new Product{ProductId=3, CategoryId=1, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
            new Product{ProductId=4, CategoryId=1, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
            new Product{ProductId=5, CategoryId=1, ProductName="Fare", UnitPrice=85,  UnitsInStock=1}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // _products.Remove(product product)  bu şekilde yazarsan productları listeden asla silemem.
            //normalde silinir ama şuan silinmez.Sebebi: senin arayüzden gönderdiğin product ın bilgilerinin aynı olması önemli değil.
            //5 tane adres var referans tipler referas numarı ile gider ve bunların hepsi farklı referans numarıasına sahip. Arayüzü aynı bile olsa
            //sen bu ürünler listesinden silme yapamıyor.String göndersen silerdi ama referans tipi bu şekilde silemezsin.
            //ürünleri silerlken PK yı kullanırız çünkü onun ayırt edilen şeyi Primary key idir.
            //böyle yazarsak çok hataı olur. çünkü boşuna beşşeği yorarsın. new dersen boşuna referans numarası atarsın  
            //Product productToDelete = new Product();
            /*Product productToDelete =null; *///null deriz çünkü suan bir referansı yok hata vermesin diye 
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); //bu işarete lambda deniyor (p=>) //ampulden system link i ekledik.
            //bu kod üsteki işlemi yapıyor foreach if döngülü hali. kodu basitleştirdim.
            //her p için p nin ID si (p o an dolaştığım ürün) benim paremetreyle gönderdiğim ürünün ID sine eşitse onun referansını buna eşitle.
            //yani bunu LINQ ile yapıyoruz. LinQ= Language integrated Query.
            //link ile bu liste bazlı yapıları aynı sql gibi filtreleyebiliyoruz.
        }

        public List<Product> GetAll()
        {
            return _products; //bir veri tabanına olduğu gibi döndürüyorum
        }
        public void Update(Product product)
        {
            //Gönderdiğim ürün Id sine sahip listedeki ürünü bul demek.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
