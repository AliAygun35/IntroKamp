using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.MusteriAdi);
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.MusteriAdi);
        }

        public void MusteriListesi(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine("Müşteriler : " + item.MusteriAdi);
            }
        }

        public void MusteriBilgileri(Musteri[] musteriBilgileri) 
        {
            foreach (var item in musteriBilgileri)
            {
                Console.WriteLine("Müşteri adı : " + item.MusteriAdi);
                Console.WriteLine("Müşteri doğum yılı : " + item.MusteriDogumYili);
                Console.WriteLine("Müşteri mesleği : " + item.MusteriMeslegi);
                Console.WriteLine("Müşteri maaşı : " + item.MusteriMaasi);
                Console.WriteLine("      --------      ");
            }
        }
    }
}
