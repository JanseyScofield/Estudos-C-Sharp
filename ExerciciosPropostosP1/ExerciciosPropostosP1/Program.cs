namespace ExerciciosPropostosP1 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Digite dois números inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int soma = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {soma}.");
        }
    }
}