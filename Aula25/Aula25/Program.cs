using System;
using System.Globalization;

namespace Aula25 {
    class Program {
        static void Main(string[] args) {

            /*DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            DateTime d2 = DateTime.UtcNow;
            Console.WriteLine(d2);*/

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d1);

            DateTime d2 = DateTime.ParseExact(DateTime.Now.ToString() ,"dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture );
            Console.WriteLine(d2);
        }
    }
}