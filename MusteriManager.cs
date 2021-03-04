using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Adi + musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} Id'li {1} sistemden silindi.", musteri.Id, musteri.Adi + musteri.Soyadi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adı:" + musteri.Adi);
            Console.WriteLine("Müşterinin Soyadı:" + musteri.Soyadi);
            Console.WriteLine("Müşteri Id:" + musteri.Id);
            Console.WriteLine("Müşterinin Yaşı:" + musteri.Yasi);

        }
    }
}
