using System;
using System.Globalization;

namespace ConsoleApp17 {
    class Program {
        static void Main(string[] args) {

            int L = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();
            double[,] M = new double[11, 11];
            double S = 0.0;
            double Md = 0.0;

            for (int lin = 0; lin < 11; lin++) {
                for (int col = 0; col < 11; col++) {
                    M[lin, col] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (lin == L - 1) {
                        S += M[lin, col];
                    }
                }
            }

            if (T == "S") {
                Console.WriteLine(S.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if (T == "M") {
                Md = S / 11;
                Console.WriteLine(Md.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
