using System.ComponentModel;
using System.Globalization;

namespace ExerciciosPropostosP7 {
    class Program {
        public static void Main(string[] args) { 
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Quantos funcionários serão registrados? ");
            int numRegist = int.Parse(Console.ReadLine());

            for(int iCont = 1; iCont <= numRegist; iCont++) {
                Console.WriteLine($"Funcionário #{iCont}: ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
            Console.Write("Digite o ID do funcionário que vai receber o aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario fun = funcionarios.Find(x => x.Id == idAumento);

            if(fun != null) {
                Console.Write("Digite o a porcentagem do aumento: ");
                double aumentoPercent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.AumentarSalario(aumentoPercent);
            } else {
                Console.WriteLine("O funcionário não existe!");
            }
            Console.WriteLine("Funcionários: ");
            foreach(var item in funcionarios) {
                Console.WriteLine(item);
            }
        }
    }
}