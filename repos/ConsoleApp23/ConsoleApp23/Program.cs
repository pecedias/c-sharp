using System;
using System.Collections.Generic;

namespace ConsoleApp23 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            A.ExceptWith(B); // Diferença
            A.UnionWith(B); // União
            A.IntersectWith(B); // Intersecção

            //          B.Remove(4);

            foreach (int x in A) {
                Console.WriteLine(x);
            }
/*
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N)) {
                Console.WriteLine(N + " Pertence ao conjunto B!");
            }
            else {
                Console.WriteLine(N + " Não pertence ao conjunto B!");
            }
*/

        }
    }
}
