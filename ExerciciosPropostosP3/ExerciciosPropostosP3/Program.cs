using System;

namespace ExerciciosPropostosP3 {
    class Program {
        public static void Main(string[] args) {
            Funcionarios funcionario1, funcionario2;

            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();

            Console.WriteLine("Digite o nome do primeiro funcionário: ");
            funcionario1.nome = Console.ReadLine();
            Console.WriteLine($"Digite o salário de {funcionario1.nome}: ");
            funcionario1.salario = double.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            funcionario2.nome = Console.ReadLine();
            Console.WriteLine($"Digite o salário de {funcionario2.nome}: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (funcionario1.salario + funcionario2.salario) / 2.0;
            Console.WriteLine($"Salário médio = R$ {salarioMedio:F2}.");
        }
    }
}