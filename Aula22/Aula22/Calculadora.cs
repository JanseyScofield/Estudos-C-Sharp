using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22 {
    internal class Calculadora {
        public static double Soma(params int[] vet) {
            double soma = 0;
            for (int i = 0; i < vet.Length; i++) {
                soma += vet[i];
            }
            return soma;
        }
    }
}
