using System.Collections.Generic;

namespace Aula23 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);
            string a1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(a1);
            string aL = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(aL);

            int pos1 = list.FindIndex( x => x[0] == 'A');
            Console.WriteLine(pos1);
            int posL = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(posL);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();
            foreach(var item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.RemoveRange(2, 2);
            foreach(var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.RemoveAll(x => x[0] == 'M');
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}