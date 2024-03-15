namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Ali Aygün";
            kurs3.IzlenmeOrani = 75;

            // Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen + " -> " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen + " -> " + kurs.IzlenmeOrani);
            }

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Kazak";
            urun1.UrunRengi = "Mavi";
            urun1.UrunBedeni = 'S';
            urun1.UrunStogu = 10;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Pantolon";
            urun2.UrunRengi = "Siyah";
            urun2.UrunBedeni = 'M';
            urun2.UrunStogu = 5;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ceket";
            urun3.UrunRengi = "Kırmızı";
            urun3.UrunBedeni = 'L';
            urun3.UrunStogu = 2;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3};

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + ", " + urunler[i].UrunRengi + ", " + urunler[i].UrunBedeni + ", " + urunler[i].UrunStogu);
            }   

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + ", " + urun.UrunRengi + ", " + urun.UrunBedeni + ", " + urun.UrunStogu);
            }

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + ", " + urunler[j].UrunRengi + ", " + urunler[j].UrunBedeni + ", " + urunler[j].UrunStogu);
                j++;
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunRengi { get; set; }
        public char UrunBedeni { get; set; }
        public int UrunStogu { get; set; }
    }
}
