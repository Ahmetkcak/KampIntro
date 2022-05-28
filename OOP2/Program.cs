using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ahmet";
            musteri1.SoyAdi = "Kocak";
            musteri1.TcNo = "123456789";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "9876543210";

            //SOLID


            Musteri musteri3 = new GercekMusteri();  // Musteri classı hem GercekMusterinin hem de TuzelMusterinin referansını tutar
            Musteri musteri4= new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);


        }
    }
}
