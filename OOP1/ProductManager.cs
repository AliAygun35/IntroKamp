using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager  // buradan çağırılacak.
    {
        // Encapsulation
        public void Add(Product product) // metodumuzun nasıl çağılacağını anlattığı yer. 
        {             //Product türünde bir şey ver. Adı product olsun. İstersek x diyebiliriz. Tıpkı "String isim" der gibi. 
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2) // Return, değer döndüren metotlardır. Sonucunda oluşan değeri tekrar kullanabiliriz. Üzerinde çalışabilir ve işlemlere sokabiliriz.
        {
            return sayi1 + sayi2;  
        }

        public void Topla2(int sayi1, int sayi2) // Tek seferlik iş yapan metotlardır. Sonucu tekrar kullanamayız. Başka işleme sokamayız.
        {
            Console.WriteLine(sayi1 + sayi2); 
        }
    }
}

// Bu tür classlarda operasyonlar yapılır. Yani metotlar içerirler.
// İş yapan manager classımız.