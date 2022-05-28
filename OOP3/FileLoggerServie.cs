using System;

namespace OOP3
{
    class FileLoggerServie : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
