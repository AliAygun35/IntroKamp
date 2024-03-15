using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) // metota parametre verdik o parametrenin tiri Urun ürün, adını da urun koyduk.
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}

//Bir classın sonunda yer alan manager, servis, dal?, data access, controller gibi ifadeler bir operasyon tutarlar.