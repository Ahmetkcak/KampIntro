using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Ahmet","Burak","Halil" }; // array
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];   // Bunu dediğimiz an başka adreste yeni dizi oluşturulur.
            //isimler[4] = "İlker";      
            //Console.WriteLine(isimler[4]);  // Burası ilker yazar ama isimler[0] ahmet yazmaz çünkü yeni adreste bir array oluşmuştur ve atama yapılmamıştır.
            //console.writeline(isimler[0]);


            List<string> isimler2 = new List<string> { "Ahmet", "Burak", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
        }
    }
}
