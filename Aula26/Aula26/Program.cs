using System;

namespace Aula26 {
    class Program {
        static void Main(string[] args) {

            /*TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1);
            TimeSpan t2 = new TimeSpan(900000000L);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(2, 30, 00);
            Console.WriteLine(t3);*/

            TimeSpan t1 = TimeSpan.FromDays(1.5);//Existe o FromHours, FromMinutes...
            Console.WriteLine(t1);
        }
    }
}
