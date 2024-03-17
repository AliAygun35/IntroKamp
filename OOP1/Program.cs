namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product oluşturma yöntemi 1:
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Product oluşturma yöntemi 2: (süslü parantez açılır!)
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            //PascalCase    //camelCase
            //stack'te oluşturduk           //heap'te oluşturduk  --->   // Değer tipler stack'ı referans tipler ise hem stack'ı hem de heap'ı kullanır.
            ProductManager productManager = new ProductManager(); // instance creation --> yani örnek oluşturma. Class'ın örneğini oluşturuyoruz. Referans tiplerini heap'de 
            //oluşturabilmemiz için onu new'lememiz gerekiyor.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);
            

            // 3 tane product karışık gibi görünse de aslında şuna benzer:
            // ProductManager productManager;
            // String isim;
        }
    } // int, double, bool ... gibi sayısal veri tipleri = değer tip -> değer tiplerinde atamalar tamamen değeri üzerinden olur ve bütün bağlantı kopar. Değişiklikten etkilenmez.
      // dizi, class, abstract class, interface ... gibi veri tipleri = referans tip -> burada ise atamalar referansın adresi ile yapılır ve bağlantı devam eder. Değişikliklerden etkilenir.
}    

// Ekran görevini gören mainimiz.