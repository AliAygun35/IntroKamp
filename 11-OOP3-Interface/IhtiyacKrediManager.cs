using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP3_Interface
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");
        }
    }
}
