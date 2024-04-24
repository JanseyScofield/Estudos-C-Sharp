using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosPropostosP6 {
    internal class Conta {
        private int _numConta;
        private string _nomeTitular;
        private double _saldo;

        public Conta(int numConta, string nomeTitular, double saldo) {
            _nomeTitular = nomeTitular;
            _numConta = numConta;
            _saldo = saldo;
        }

        public void Deposito(double valor) {
            _saldo += valor;
        }

        public void Saque(double valor) {
            _saldo -= valor+5;
        }

        public override string ToString() {
            return "Conta " + _numConta + ", Ttiular: " + _nomeTitular + ", Saldo: R$ " + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
