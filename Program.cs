using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Berna";
            musteri1.Soyadi = "Taşdemir";
            musteri1.Id = 1145;
            musteri1.Yasi = 32;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Beyza";
            musteri2.Soyadi = "Somuncu";
            musteri2.Id = 1149;
            musteri2.Yasi = 19;


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Elif Azra";
            musteri3.Soyadi = " Çanga";
            musteri3.Id = 1146;
            musteri3.Yasi = 4;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteri2);
        }
    }
}
