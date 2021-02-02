using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //Id'si
        public int Id { get; set; }
        //Hangi katogoriye ait olduğunu
        public int CategoryId { get; set; }
        //Ürün ismi
        public string ProductName { get; set; }
        //Ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //Ürünün stok adedi
        public int UnitInStock { get; set; }

        

    }
}
