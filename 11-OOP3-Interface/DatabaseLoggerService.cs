using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP3_Interface
{
    internal class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
}

// Loglama alternatifleri yapıyoruz. Veritabanına, Dosyaya, ... .