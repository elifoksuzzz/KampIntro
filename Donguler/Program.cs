using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım geliştirme kampı", "programlama temelleri kursu", "java","phyton"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("*****************************");
            foreach (var herhangiDegisken in kurslar)
            {
                Console.WriteLine(herhangiDegisken);
            }


        }
    }
}

