namespace Aula02 {
    class Program {
        static void Main(string[] args) {
            byte n1 = 126;
            n1++;
            int n2 = 1000;
            int n3 = 2147483647;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n4 = 4.5f;
            double n5 = 4.3;
            string nome = "Maria";
            object obj1 = "Alex";
            object obj2 = 4.2;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}