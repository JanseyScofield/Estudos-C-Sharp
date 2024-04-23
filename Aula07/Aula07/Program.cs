using System;
    namespace Aula07 {
    class Program {
        static void Main(string[] args) {
            /*Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.Write("O número é par!");
            } else {
                Console.Write("O número é ímpar!");
            }*/
            Console.WriteLine("Digite o horário: ");
            int hora = int.Parse(Console.ReadLine());
            if(hora <= 12 && hora > 4) {
                Console.WriteLine("Bom dia.");
            }
            else if(hora >= 13 && hora <=17 ){
                Console.WriteLine("Boa tarde!");
            } else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
