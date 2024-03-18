using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP2
{
    internal class TuzelMusteri: Musteri // Tüzel kişi bir müşteridir diyoruz. Bu olaya inheritance denir. Miras! Yani TuzelMusteri miras alır Musteri'den. Ebeveyni Musteri'dir.
    {               // Coorporate

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

// Inheritance, yani Musteri'de olan tüm özellikler artık TuzelMusteri'de de vardır. Ama bu yeterli açıklama değildir.