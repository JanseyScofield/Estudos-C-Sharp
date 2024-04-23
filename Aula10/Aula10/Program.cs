using System;
namespace Aula10 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número: ");
            double n = double.Parse(Console.ReadLine()) ;
            double raizQuad;
            while(n >= 0 ) {
                raizQuad = Math.Sqrt(n) ;
                Console.WriteLine($"A raiz de {n} é {raizQuad:F3}.");
                Console.WriteLine("Digite outro número: ");
                n = double.Parse(Console.ReadLine()) ;
            }
            Console.WriteLine("Número negativo!");
        }
    }
}