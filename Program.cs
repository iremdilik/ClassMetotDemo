using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Yıldız";
            musteri1.Yas = 36;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ayşe";
            musteri2.Soyad = "Kaya";
            musteri2.Yas = 25;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Merve";
            musteri3.Soyad = "Çelik";
            musteri3.Yas = 29;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Liste(musteri2);
            musteriManager.Sil(musteri3);


        }
    }
}
