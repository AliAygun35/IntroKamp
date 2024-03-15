namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "C# Kursu";
            string kurs2 = "Pyton Kursu";
            string kurs3 = "Java Kursu";

            string[] kurslar = new string[] { "C# Kursu", "Pyton Kursu", "Java Kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            // Diziler için foreach döngüsü kullanılır. 
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
