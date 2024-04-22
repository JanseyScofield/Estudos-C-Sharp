namespace Aula05 {
    class Program {
        static void Main(string[] args) {
            string frase = Console.ReadLine();

            Console.WriteLine($"Você digitou: {frase}.");

            string x, y, z, s;

            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            s = Console.ReadLine();

            string[] v = s.Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}