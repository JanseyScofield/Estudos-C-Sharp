using System;

namespace Aula20 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o número de termos do vetor: ");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for(int iCont = 0; iCont < n; iCont ++) {
                vet[iCont] = 0.0;
                Console.WriteLine(vet[iCont]);
            }
            


        }
    }
}