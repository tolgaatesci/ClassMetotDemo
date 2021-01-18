using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri eklendi : " + " " + musteri.Id + " " + " " + musteri.Adi);            
        }

        public void Listele(Musteri[] musteriler) 
        {
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri listesi : " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Cinsiyeti + " " + musteri.Meslegi + " " + musteri.KrediNotu);
            }
        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " numaralı müsteri silindi. Silinen musterinin adi : " + musteri.Adi);            
        }

        public void KrediVerilebilirMi(Musteri musteri)
        {
            int krediNotu = musteri.KrediNotu;
            
            if( krediNotu < 700 )
            {
                Console.WriteLine("Müşterimiz olan " + " " + musteri.Adi + " " + musteri.Soyadi + " kredi almaya elverişli değildir.");
            }
            else
            {
                Console.WriteLine("Müşterimiz olan " + " " + musteri.Adi + " " + musteri.Soyadi + " kredi almaya elverişlidir.");
            }
        }
    }
}
