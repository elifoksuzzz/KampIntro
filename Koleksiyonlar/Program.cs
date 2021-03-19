using System;
using System.Collections.Generic; //Koleksiyonları kullanmak için ihtiyacımız olan kütüphane

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Elif","Sevval","Lara","Ezgi" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4]="Sena"; durumunda bunu diziye eklememiş olursun çünkü dizilerde
            //new'lediğin zaman belirlediğin eleman dışına çıkamazsın.(her yeni new yeni bir adrestir)
            //bu yüzden bu durumlarda eleman belli değilse list(koleksiyonlar) kullanılır.

            List<string> isimler2 = new List<string> { "Elif", "Sevval", "Lara", "Ezgi" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Sena"); //Add hazır fonksiyondur kütüphane böyle hazır fonk barındırır.
            Console.WriteLine(isimler2[4]); 

        }
    }
}
