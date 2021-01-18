using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Adi = "Tolga";
            musteri1.Soyadi = "Ateşci";
            musteri1.Cinsiyeti = "E";
            musteri1.Meslegi = "Elektronik Mühendisi";
            musteri1.KrediNotu = 500;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Ateşci";
            musteri2.Cinsiyeti = "E";
            musteri2.Meslegi = "Kamyon Şoförü";
            musteri2.KrediNotu = 1600;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 789;
            musteri3.Adi = "Banu";
            musteri3.Soyadi = "Ateşci";
            musteri3.Cinsiyeti = "K";
            musteri3.Meslegi = "Ev Hanımı";
            musteri3.KrediNotu = 710;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Listele(musteriler);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            musteriManager.KrediVerilebilirMi(musteri2);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            musteriManager.Silme(musteri1);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");

        }
    }
}
