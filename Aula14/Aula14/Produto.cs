﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14 {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return Nome + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque();
        }
    }
}