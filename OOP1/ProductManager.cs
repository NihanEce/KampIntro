using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)//101

        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        


        //encapsulation
        //public void Add(Product product) //101
        //{
        //    product.ProductName = " Kamera";
        //}

        //public void BiseyYap ( int sayi ) 
        //{
        //    sayi = 99;
        //}
    }
}

