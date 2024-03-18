namespace _10_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gerçek müşteri = Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "7777777777";

            // Tüzel müşteri = Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "33333333";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            // Musteri sınıfı hem GercekMusteri'nin hem de TuzelMusteri'nin referansını tutabiliyor. New gördüğümüzde refarans adresi aklımıza gelmeli!

            MusteriManager musteriManager = new MusteriManager(); // instance oluşturuyoruz. 
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            // Dolayısıyla musteriManager'e hem gerçek hem de tuzel müşterileri yollayabiliriz. Çünkü MusteriManager base class olan Musteri'yi miras alıyor. Referansını tutuyor.


            
        }
    }
}
      
//Gerçek ve Tüzel Müşteriler sektördeki veritabanlarında çok hatalı girilirler. 