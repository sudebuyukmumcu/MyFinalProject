using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //bana hangi veri yöntemiyle çalıştığımı söylemen lazım  o yüzden InMemoryPRodct Dal ı al diyorum. Ben InMEmory çalışıcam demek
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
