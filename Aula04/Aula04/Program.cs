namespace Aula04 {
    class Program {
        static void Main(string[] args) {
            double a = 1.0, b = -3.0, c = -4.0, delta;

            delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"O x1 é igual a {x1} e o x2 é igual a {x2}.");
        }
    }
}