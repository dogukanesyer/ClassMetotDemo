using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Ad = "Doğukan";
            musteri1.Soyad = "Eşyer";
            musteri1.TcNo ="38083684564";
            musteri1.Email = "dogukanesyer@gmail.com";
            musteri1.Adres = "İzmir";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 4;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Yılmaz";
            musteri2.TcNo = "38083684585";
            musteri2.Email = "ahmetyilmaz@gmail.com";
            musteri2.Adres = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 6;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Demir";
            musteri3.TcNo = "38083684596";
            musteri3.Email = "mehmetdemir@gmail.com";
            musteri3.Adres = "Samsun";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.Email);
                Console.WriteLine(musteri.Adres);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.List(musteri1);
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri3);

            Console.ReadKey();
        }

        
    }
}
