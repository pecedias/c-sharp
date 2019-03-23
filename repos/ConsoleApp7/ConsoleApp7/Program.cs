using System;

namespace ConsoleApp7 {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank); // n linha

            Console.WriteLine(mat.GetLength(0)); // 1a dimensao qtd linha

            Console.WriteLine(mat.GetLength(1)); // 2a dimensao qtd coluna

        }
    }
}
