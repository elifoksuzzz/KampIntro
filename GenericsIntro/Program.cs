using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>(); //string yerine istediğim tipi verebilirim 
            myList.Add("Esra");

        }
    }
}
