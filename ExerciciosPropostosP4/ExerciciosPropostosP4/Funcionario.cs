using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostosP4 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;

        public double SalarioLiquido() {
            return SalarioBruto - Impostos;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * (porcentagem/100));
        }

        public override string ToString() {
            return Nome + ", R$ " +SalarioLiquido(); 
        }
    }
}
