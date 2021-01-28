using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAd = "İshak";
            musteri1.musteriSoyad = "Selvitopu";
            musteri1.musteriYaS = 26;
            musteri1.musteriSehir = "Ankara";
            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAd = "Filiz";
            musteri2.musteriSoyad = "Çelik";
            musteri2.musteriYaS = 25;
            musteri2.musteriSehir = "Ankara";
            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            //foreach (Musteri musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.musteriId);
            //    Console.WriteLine(musteri.musteriAd);
            //    Console.WriteLine(musteri.musteriSoyad);
            //    Console.WriteLine(musteri.musteriYaS);
            //    Console.WriteLine(musteri.musteriSehir);
            //}

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriGetir(musteri1);
            musteriManager.MusteriGetir(musteri2);
            Console.ReadKey();
        }
      
        
    }
}
