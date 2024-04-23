using System;
namespace Aula08 {
    class Program {
        static int Maior(int x1, int x2, int x3) {
            if (x1 > x2 && x1 > x3)
                return x1;
            else if (x2 > x1 && x2 > x3)
                return x2;
            else
                return x3;
        }
        static void Main(string[] args) {
            int[] num = new int[3];
            int resultado;

            Console.WriteLine("Digite o primeiro número: ");
            num[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            num[2] = int.Parse(Console.ReadLine());
            
            resultado = Maior(num[0], num[1], num[2]);
            Console.WriteLine(resultado);
        }
    }
}