using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP3_Interface
{
    interface IKrediManager // -> okunurluğu arttırmak için interfacelerin başına "I" harfi konur. Arayüz demektir yani şablon. Mirasçılar şablona uymak zorunda!
    {
        void Hesapla(); // Interface içinde sadece imza metotları olur, içi dolu olamaz. Yani düz void ... .
        void BiseyYap();
    }
}

// Interface içindeki metotlar mirasçılarda da bulunmak zorunda! 
// Interfaceleri genellikle operasyonel metotlarda kullanıyoruz.
// Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
// Interfacelerimize Service deriz.
// Interfaceler bir referans tutucudur. Bizim için bir must yani zorunluluk olmalıdır!
