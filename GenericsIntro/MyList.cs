using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<MyType> //benim istediğim tipe dönüşebilir bunun adını kendim koydum
    {
        MyType[] elemanlar;
        public MyList() //constructor (class'ı newleyince direkt çalışan blok)
        {
            elemanlar = new MyType[0];
            //koleksiyonları ilk newlediğimizde 0 elemanlı dizi gibi 
            //davranır bu özelliği kendi listeme de eklemiş oldum
        }

        public void Add(MyType eleman)
        {
            MyType[] geciciArray = elemanlar; //ikinci newlemeyi yaptığımda ilk adresteki
            //değer gitmemesi için eklemeden önceki halini geciciArray'e aktardım
            elemanlar = new MyType[elemanlar.Length+1]; //dizimin eleman sayısını 1 arttırdım.
            for (int i = 0; i < geciciArray.Length; i++)
            {
                elemanlar[i] = geciciArray[i]; //elemanı 1 arttırdıktan sonra newlediğimden 
                //ötürü kaybettiğim elemanları kendime geri almış oldum
            }
            elemanlar[elemanlar.Length - 1] = eleman; //son elemana yeni elemanı eklemiş oldum


        }
    }
}
