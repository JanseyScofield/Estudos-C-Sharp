using System;

namespace Aula14 {
    class Program {
        static void Main(string[] args) {
            Produto p1;
            p1 = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

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