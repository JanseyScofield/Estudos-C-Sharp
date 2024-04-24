using System;

namespace Aula14 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto (nome, preco, quantidade);

            Console.WriteLine($"Dados do produto: {p1}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtdAdicionar = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qtdAdicionar);
            Console.WriteLine($"Dados atualizados: {p1}");

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            int qtdRemover = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qtdRemover);
            Console.WriteLine($"Dados atualizados: {p1}");

        }
    }
}