using System;
namespace ExerciciosPropostosP4 {
    class Program {
        static void Main(string[] args) {
            Funcionario pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Impostos: ");
            pessoa.Impostos = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + pessoa);
            Console.WriteLine();
            Console.Write("Digite a porcentagem de aumento: ");
            double porcentAumento = double.Parse(Console.ReadLine());
            pessoa.AumentarSalario(porcentAumento);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + pessoa);
        }
    }
}
