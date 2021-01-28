using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MusteriManager
    {
        public void MusteriGetir(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID:"+musteri.musteriId+"\n" + "Müşteri Adı Soyadı:"+musteri.musteriAd+musteri.musteriSoyad+ "\n" + "Müşterinin Yaşı:"+musteri.musteriYaS+ "\n" + "Müşterinin Yaşadığı Şehir"+musteri.musteriSehir);
        }
    }
}
