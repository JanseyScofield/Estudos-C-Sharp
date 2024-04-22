using System.Globalization;

namespace Aula05Execicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantas quartos tem sua casa ? ");
            int qtdDeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome + qtdDeQuartos + preco + lastName+ idade+ altura);
        }
    }
}