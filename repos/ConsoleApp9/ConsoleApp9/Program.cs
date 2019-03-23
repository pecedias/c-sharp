using System;

namespace ConsoleApp9 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] mat = new int[m, n];

            for (int lin = 0; lin < m; lin++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int col = 0; col < n; col++) {
                    mat[lin, col] = int.Parse(values[col]);
                }
            }

            int pos = int.Parse(Console.ReadLine());
            int left;

            for (int lin = 0; lin < m; lin++) {

                for (int col = 0; col < n; col++) {
                    if (pos == mat[lin, col]) {
                        left = mat[pos, col];
                        
                    }
                }
            }

        }
    }
}
