using System.Globalization;

namespace Aula03 {
    class Program {
        static void Main(string[] args) {
            double saldo = 3.1019;
            string nome = "Maria";
            int idade = 32;
            
            Console.WriteLine(saldo.ToString("F2")); //2 casas decimais
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //para colocar o '.' ao invés da ',' em números decimais
            Console.WriteLine("{0} tem {1} anos e tem saldo = R$ {2}.", nome, idade, saldo.ToString("F2"));
            Console.WriteLine($"{nome} tem {idade} anos e o saldo está de R$ {saldo:F2}.");
        }
    }
}
