namespace _11_OOP3_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. Yöntem
            //IhtiyacKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();

            //// 2. Yöntem
            //IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager2.Hesapla();
            //// Interface'ler de o interfaceyi imlemente eden sınıfların referans numaralarını tutabilir! Aynı sonucu verir. Önemli bilgidir.

            //TasitKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager1 .Hesapla();

            //IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager2.Hesapla();

            //KonutKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            //IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager2.Hesapla();

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService(); // böyle de instance oluşturabiliriz veya aşağıda parantezin içine de direk new'leyebiliriz.
            ILoggerService fileLoggerService = new FileLoggerService(); 

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService()); // Hangi krediyi verirsek onun hesaplası çalışır.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager}; // hesaplanmasını istediğimiz kredileri yazıyoruz.

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
