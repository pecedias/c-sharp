using System;

namespace ConsoleApp8 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int lin = 0; lin < n; lin++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int col = 0; col < n; col++) {
                    mat[lin, col] = int.Parse(values[col]);      
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;

            for (int lin = 0; lin < n; lin++) {
                for (int col = 0; col < n; col++) {
                    if (mat[lin, col] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers = " + count);

        }
    }
}
