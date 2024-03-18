using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP3_Interface
{
    internal class BasvuruManager
    {
        // Method injection -> Yani BaşvuruYap metodunun kullanacağı KrediManager'in ve LoggerService'nin ne olacağını yani hangi kredi türü ve loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // IKrediManager tüm kredileri kapsar. Aynı zamanda bu metodu loglamak için ILoggerService interfacesini veriyoruz.
                                                                                         // Başvuru işlemlerinde hangi kredi ve loglayıcı olduğuna dair bilgimiz yok, sadece soyut halleri var. Somut hallerini enjekte ediyoruz.
        {
            // Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla(); // O yüzden buraya hangisini verirsek onun hesapla'sı çalışır.
            loggerService.Log(); // Hesaplamayı yaptıktan sonra hangi loggerService gönderilmişse/seçilmişse onu logla diyoruz.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // List kullanıyoruz çünkü veri 0 tane de olabilir 1000 tane de! Birden fazla kredinin hesabını yapmak istiyoruz.
                                                                            // Bu sebeple bana bir liste ver ama bu listenin türü IKrediManager olsun diyoruz.
        {
            foreach (var kredi in krediler) // Birden fazla veri varsa her birini tek tek dolaş ve hesapla!
            {
                kredi.Hesapla();
            }
        }
    }
}

// Çok önemli konu.
// Teknik mülakatta mutlaka karşımıza çıkar ve bizi o işe sokar.
// Soyutlama önemlidir.
// Polimorfizm önemlidir.