using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Adi = "Yasin";
            musteri1.Soyadi = "GÜL";
            musteri1.NationalId = 12345678910;
            musteri1.HesapNo = 11111111111111111;
            musteri1.PhoneNumber = 5555555555;
            musteri1.Cuzdan = "15464321,01 TL";

            Musteri musteri2 = new Musteri();

            musteri2.Adi = "Ece";
            musteri2.Soyadi = "Kahramangil";
            musteri2.NationalId = 12345678915;
            musteri2.HesapNo = 11111111111111112;
            musteri2.PhoneNumber = 5555555550;
            musteri2.Cuzdan = "15464321123,01 TL";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.NationalId);
                Console.WriteLine(musteri.HesapNo);
                Console.WriteLine(musteri.PhoneNumber);
                Console.WriteLine(musteri.Cuzdan);

            }

            Console.WriteLine("------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
        }
    }
}
