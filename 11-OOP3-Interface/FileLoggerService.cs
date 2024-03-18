namespace _11_OOP3_Interface
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");
        }
    }
}

// Loglama alternatifleri yapıyoruz. Veritabanına, Dosyaya, ... .