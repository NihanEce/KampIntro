using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Nihan Ece";
            musteri1.MusteriSoyadi = "Algül";
            musteri1.MusteriKrediLimiti = 100000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.MusteriAdi = "Ufuk";
            musteri2.MusteriSoyadi = "Algül";
            musteri2.MusteriKrediLimiti = 200000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1;
            musteri3.MusteriAdi = "Sinan";
            musteri3.MusteriSoyadi = "Keten";
            musteri3.MusteriKrediLimiti = 50000;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);


            List <string> musteriIsımleri = new List<string> { "Nihan Ece", "Ufuk", "Sinan" };
            Console.WriteLine(musteriIsımleri[0]);
            Console.WriteLine(musteriIsımleri[1]);
            Console.WriteLine(musteriIsımleri[2]);
            



        }
    }
}
