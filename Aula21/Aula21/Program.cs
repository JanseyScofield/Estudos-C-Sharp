using System.Globalization;

namespace Aula21 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produtos[] vet = new Produtos[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vet[i] = new Produtos { Name = name, Valor = valor };  
            }

            double soma = 0;

            for (int i = 0;i < n;i++) {
                soma += vet[i].Valor;
            }

            double media = soma / n;
            Console.WriteLine("Preço médio é igual a " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}