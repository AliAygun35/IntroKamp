namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, float, double, decimal, bool = değer tip. Bunlar değer tipleridir.
            // array, class, interface = referans tip. Bunlar referans tipleridir.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 kaçtır?
            // cevap = 30 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] kaçtır?
            // cevap = 999 -------------------------------------------> neden böyle?
            // sebebi birinin değer ve diğerinin referans tipleri olmaları!


            // bellekte stack ve heap adlı 2 alan vardır. Değer tipler sadece stack'te tanımlanır, referans tipler ise heap'de tanımlanır.
            // yani int sayi1 = 10 yazdığımızda stack alanında tanımlanır ve değeri burada tutulur. sayi1 = sayi2 dedikten sonra sayi2'ye 
            // başka bir değer atadığımızda sayi1 bundan etkilenmez.
            // new demek bellekten yeni bir adres oluştur demek! Heap'de!
            // referans tiplerinde adresler kopyalanır. Değer tiplerinde ise sadece değerler kopyalanır.
            // Örneğin  int[] sayilar1 = new int[] { 10, 20, 30 }; dediğimizde stack'te sayilar1 adında bir tanım oluşur,
            // heap'de dizi içinde değerleri tanımlanır ve bu adreste tutulur. sayilar1 = sayilar2 dediğimizde sayilar2'nin
            // adresini sayilar1'e atamış oluruz daha sonra sayilar2[0]'a başka bir değer atadığımızda sayilar1[0]'da da o değer değişir.
            // Çünkü artık sayilar1 sayilar2'nin adresini tutmaktadır! Eski değerleriyle işi kalmadı! O değerler garbage collector tarafından
            // bellekten silinir.

            

        }
    }
}
