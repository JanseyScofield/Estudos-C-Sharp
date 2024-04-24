using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16 {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) { 
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
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
            return Nome + ", " + Quantidade + " unidades, valor do produto R$ " + Preco + ", Total: R$ " + ValorTotalEmEstoque();
        }
    }
}