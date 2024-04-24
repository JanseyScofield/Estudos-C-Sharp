using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18 {
    internal class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque() {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int numAdd) {
            _quantidade += numAdd;
        }

        public void RemoverProdutos(int numRmv) {
            _quantidade -= numRmv;
        }

        public override string ToString() {
            return _nome + ", " + _quantidade + " unidades, valor do produto R$ " + _preco + ", Total: R$ " + ValorTotalEmEstoque();
        }
    }
}