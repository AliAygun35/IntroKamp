namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string> (); // String türünde tip verdiğimizde arka plandaki <T> de string oluyor.
            isimler.Add("Engin");

            Console.WriteLine("Hello, World!");
        }
    }
}
