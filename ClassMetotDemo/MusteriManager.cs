using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "eklendi.");
            Console.WriteLine("--------------------------------");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "silindi.");
            Console.WriteLine("--------------------------------");
        }
        
    }
}
