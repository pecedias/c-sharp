using System;

namespace ConsoleApp22 {
    class Program {
        static void Main(string[] args) {

            string[] T = Console.ReadLine().Split(' ');

            int M = int.Parse(T[0]);
            int N = int.Parse(T[1]);

            int[,] Mt = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] V = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    Mt[i, j] = int.Parse(V[j]);
                }
            }

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (X == Mt[i, j]) {
                        Console.WriteLine("Position {0},{1}:", i, j);
                        if (j > 0) {
                            Console.WriteLine("Left: " + Mt[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + Mt[i - 1, j]);
                        }
                        if (j < N - 1) {
                            Console.WriteLine("Right: " + Mt[i, j + 1]);
                        }
                        if (i < M - 1 ) {
                            Console.WriteLine("Down: " + Mt[i + 1, j]);
                        }
                    }
                }
            }
        }

    }
}
