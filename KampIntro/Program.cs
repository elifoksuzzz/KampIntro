using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoricigim.....";
            //değişkenler birer değer tutucudur
            int ogrencSayisi = 5;
            float ogrencilerinOrtalamaları = 65.4f; //sonuna f koyulmazsa hata verir
            bool girisYapildiMi = false;

            if (girisYapildiMi)
            {
                Console.WriteLine("Giris Yapildi");
            }
            else
            {
                Console.WriteLine("Giris Basarisiz");
            }
           
        }
    }
}
