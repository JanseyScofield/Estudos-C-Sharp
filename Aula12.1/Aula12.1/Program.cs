using System;
namespace Aula12_1 {
    class Program {
        static void Main(string[] args) {
            double[] tri1 = new double[3];
            double[] tri2 = new double[3];
            double[] p = new double[2];
            double[] area = new double[2];
            int iCont;
            Console.WriteLine("Entre com os lados do triângulo 1: ");
            for (iCont = 0; iCont <= 2; iCont++) {
                Console.WriteLine($"Lado {iCont + 1}:");
                tri1[iCont] = double.Parse(Console.ReadLine());
            }
            p[0] = (tri1[0] + tri1[1] + tri1[2]) / 2.0;

            Console.WriteLine("Entre com os lados do triângulo 2: ");
            for (iCont = 0; iCont <= 2; iCont++) {
                Console.WriteLine($"Lado {iCont + 1}:");
                tri2[iCont] = double.Parse(Console.ReadLine());
            }
            p[1] = (tri2[0] + tri2[1] + tri2[2]) / 2.0;

            area[0] = Math.Sqrt(p[0] * (p[0] - tri1[0]) * (p[0] - tri1[1]) * (p[0] - tri1[2]));
            area[1] = Math.Sqrt(p[1] * (p[1] - tri2[0]) * (p[1] - tri2[1]) * (p[1] - tri2[2]));

            Console.WriteLine($"A área do triângulo 1 é igual a {area[0]:F4} m².");
            Console.WriteLine($"A área do triângulo 2 é igual a {area[1]:F4} m².");
        }
    }
}