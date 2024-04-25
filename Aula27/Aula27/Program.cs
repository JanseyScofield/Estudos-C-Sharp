using System;

namespace Aula27 {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime d2 = d1.AddDays(7);
            Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss"));
            TimeSpan t= d2.Subtract(d1);
            Console.WriteLine(t);
        }
    }
}