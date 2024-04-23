using System;
using System.Threading.Channels;
namespace Aula11 {
    class Program {
        static void Main(string[] args) {
            int soma, N, num, iCont;
            Console.WriteLine("Quantos números inteiros você  quer digitar? ");
            N = int.Parse(Console.ReadLine());
            soma = 0;

            for(iCont = 1; iCont <= N; iCont++) {
                Console.WriteLine($"Digite o valor {iCont}:");
                num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine($"Soma = {soma}.");
        }
    }
}