using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:IEntitiy //public: bu class a diğer katmanlarda ulaşabilsin demek.
  //enties i bu üç katmanda (DataAccess, ConsolUI, Business) kullanıcak bu yüzden diğer classların buna erişmesi gerekiyor.

    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short MyPropeUnitsInStock { get; set; } //short int in bir küçüğü
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
