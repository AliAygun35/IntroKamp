namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(); // -> Class'ın instance'sini oluşturduk. Yani bir örneğini. New'leyerek!
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriDogumYili = 1975;
            musteri1.MusteriMeslegi = "Öğretmen";
            musteri1.MusteriMaasi = 20.000;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Zeynep";
            musteri2.MusteriDogumYili = 1980;
            musteri2.MusteriMeslegi = "Mühendis";
            musteri2.MusteriMaasi = 35.000;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Ali";
            musteri3.MusteriDogumYili = 1993;
            musteri3.MusteriMeslegi = "Yazılımcı";
            musteri3.MusteriMaasi = 50.000;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("-------------------------");
            musteriManager.MusteriSilme(musteri2);
            Console.WriteLine("-------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            Console.WriteLine("----Müşteri İsim Listesi----");
            musteriManager.MusteriListesi(musteriler);

            Musteri[] musteriBilgileri = new Musteri[] { musteri1, musteri2, musteri3 };
            Console.WriteLine("----Müşteri Bilgileri----");
            musteriManager.MusteriBilgileri(musteriBilgileri);
        }
    }
}
