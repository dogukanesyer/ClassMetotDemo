using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler " + musteri.Ad + " " + musteri.Soyad + " isimli müşteri sisteme eklendi!");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri Listelendi: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri Silindi: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
