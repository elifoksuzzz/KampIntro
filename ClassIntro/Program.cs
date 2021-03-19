using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "java";
            kurs1.Egitmeni = "Elif";
            kurs1.IzlenmeOrani = 45;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "csharp";
            kurs2.Egitmeni = "Sema";
            kurs2.IzlenmeOrani = 38;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "phyton";
            kurs3.Egitmeni = "Rabia";
            kurs3.IzlenmeOrani =41;

            Kurs[] kurslarım = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var dokul in kurslarım)
            {
                Console.WriteLine(dokul.KursAdi +": " + dokul.Egitmeni);
            }
            
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmeni { get; set; }
            public int IzlenmeOrani { get; set; }
        }

    }
}
