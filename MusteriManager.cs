using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Ad );
        }

        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi: " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad);
        }
    }
}
