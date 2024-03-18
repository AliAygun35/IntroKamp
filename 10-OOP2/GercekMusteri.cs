using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP2
{
    internal class GercekMusteri: Musteri // Gerçek kişi bir müşteridir diyoruz. Bu olaya inheritance denir. Miras! Yani GercekMusteri miras alır Musteri'den.  Ebeveyni Musteri'dir.
    {               // Individual
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
