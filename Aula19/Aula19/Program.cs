using System;

namespace Aula19 {
    class Program {
        static void Main(string[] args) {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            
            if (x.HasValue)
                Console.WriteLine(x.HasValue);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.HasValue);
            else 
                Console.WriteLine("Y is null");


        }
    }
}