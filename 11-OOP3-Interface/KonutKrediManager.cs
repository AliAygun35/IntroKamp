using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP3_Interface
{
    internal class KonutKrediManager : IKrediManager // IKrediManager'in üstüne gelip ampülden "implement interface" dedikten sonra şablonlarımız mirasçılarda oluşur.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }
    }
}
