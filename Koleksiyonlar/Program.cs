using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); // Çalışmaz. Çünkü dizi sınırının dışında kaldı!

            // Listeye eleman ekleme 1. Yöntem:
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");

            // Listeye eleman ekleme 2. Yöntem: --> Süslü parantez!
            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
// Gerçek hayat projelerinde c# da array pek kullanmayız. Daha çok koleksiyonlar kullanırız. Çünkü dizilere sonradan eleman eklenemiyor, out of range hatası alınıyor. 
// Yani 4 elemanlı bir arrayi artık 5 elemanlı yapamıyoruz. Yaparsak eski elemanları kaybederiz.