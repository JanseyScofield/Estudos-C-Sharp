using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18 {
    internal class Produto {
        private string _nome;
        public double Preco { get; private set};
        public int Quantidade { get; private set};

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int numAdd) {
            Quantidade += numAdd;
        }

        public void RemoverProdutos(int numRmv) {
            Quantidade -= numRmv;
        }

        public override string ToString() {
            return _nome + ", " + Quantidade + " unidades, valor do produto R$ " + Preco + ", Total: R$ " + ValorTotalEmEstoque();
        }
    }
}