using System;
namespace ExerciciosPropostosP5 {
    class Program {
        public static void Main(string[] args) {
            Alunos aluno1 = new Alunos();

            Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            aluno1.Nota3 = double.Parse(Console.ReadLine());
            double notaFinal = aluno1.NotaFinal();
            Console.WriteLine($"NOTA FINAL = {notaFinal}");
            aluno1.Resultado(notaFinal);
        }
    }
}
