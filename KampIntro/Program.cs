﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
