using ExerciciosPropostosP2;
using System;
namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {pessoa1.nome}: ");
            pessoa1.idade = int.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {pessoa2.nome}: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if(pessoa1.idade < pessoa2.idade)
                Console.WriteLine($"Pessoa mais velha: {pessoa2.nome}");
            else
                Console.WriteLine($"Pessoa mais velha: {pessoa1.nome}");
        }
    }
}