using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın 
   public class Category : IEntitiy //eğer bir class bu şekilde inherit değer almıyorsa biz bunları gruplam eğilimi yaprız.
        //bunlar bir veri tablosuna karşılık geliyor deriz.//IEntitiy diye interface ekliyoruz Abstract klasörüne
        //IEntitiy i tanımlamak için bu classta tanımlamamız lazım.
        //en üste using Entities.Abstract; diye ekleme yaptık. Aynı şeyi Product class ına da yaparız.
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
