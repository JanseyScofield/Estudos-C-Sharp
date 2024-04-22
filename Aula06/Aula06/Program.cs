namespace Aula05 {
  class Program {
        static void Main(string[] args) {
            /*int n1 = int.Parse(Console.ReadLine());
             char ch = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(d);*/

            string nome = Console.ReadLine();
            char genero = char.Parse(Console.ReadLine());
            int idade = int.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {genero} {idade} {altura}");
        }
    }       
}