using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16 {
    internal class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
           _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome; 
        }
        
        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1)
                _nome = nome;
        }

        public double GetPreco() { 
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
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