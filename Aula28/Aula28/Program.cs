using System;

namespace Aula28 {
    class Program {
        static void Main(string[] args) {
            DateTime d1 =  DateTime.Now;
            DateTime d2 = DateTime.Now;
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            d1 = d1.ToUniversalTime();
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));

        }
    }
}