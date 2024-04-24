using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostosP5 {
    internal class Alunos {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
            
        }

        public void Resultado(double notaFinal) {
            if(notaFinal >= 60.00) {
                Console.WriteLine("APROVADO!");
            } else {
                double notaRestante = 60.00 - notaFinal;
                Console.WriteLine("REPROVADO!");
                Console.WriteLine($"Faltaram {notaRestante} PONTOS");
            }
        }
    }
}
