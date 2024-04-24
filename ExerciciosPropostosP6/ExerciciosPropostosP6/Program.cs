using System.Globalization;

namespace ExerciciosPropostosP6 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            double depoInicial;
            if (resposta == 's') {
                Console.Write("Entre com o valor do depósito inicial:");
                depoInicial = double.Parse(Console.ReadLine());
            }
            else {
                depoInicial = 0.0;
            }


            Conta conta = new Conta(numConta, nomeTitular, depoInicial);
            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + conta);

            double movimentacoes;
            Console.Write("Entre com o valor de depósito: ");
            movimentacoes = double.Parse(Console.ReadLine());
            conta.Deposito(movimentacoes);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + conta);
            Console.WriteLine();
            Console.Write("Entre com o valor de saque: ");
            movimentacoes = double.Parse(Console.ReadLine());
            conta.Saque(movimentacoes);
            Console.WriteLine("Dados atualizados: " + conta);
        }
    }
}