namespace Aula22 {
    class Program {
        static void Main(string[] args) {

            double soma = Calculadora.Soma(1,2,3,4,5);
            double soma2 = Calculadora.Soma(12, 1);

            Console.WriteLine(soma);
            Console.WriteLine(soma2);
        }
    }
}