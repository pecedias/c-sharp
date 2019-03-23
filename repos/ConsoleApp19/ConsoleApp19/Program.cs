using System;
using System.Globalization;

namespace ConsoleApp19 {
    class Program {
        static void Main(string[] args) {

            int C = int.Parse(Console.ReadLine());
            char T = char.Parse(Console.ReadLine());
            double S = 0.0;

            double[,] M = new double[11, 11];

            for (int i = 0; i < 11; i++) {
                for (int j = 0; j < 11; j++) {
                    M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                    if (j == C - 1) {
                        S += M[i, j];
                    }
                }
            }

            if (T == 'S') {
                Console.WriteLine(S.ToString("F1", CultureInfo.InvariantCulture));
            }

            if (T == 'M') {
                S = S / 11.0;
                Console.WriteLine(S.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
