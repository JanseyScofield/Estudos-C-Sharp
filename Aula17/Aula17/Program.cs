using Aula16;
using System;
using System.Globalization;

namespace Aula17 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());

        }
    }
}