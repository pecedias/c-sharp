using System;
using System.Globalization;

namespace ConsoleApp20 {
    class Program {
        static void Main(string[] args) {

            char O = char.Parse(Console.ReadLine());

            double[, ] M = new double[11, 11];

            double S = 0.0; 
            
            for (int i = 0; i < 11; i++) {
                for (int j = 0; j < 11; j++) {
                    M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (j > i) {
                        S += M[i, j];
                    }
                }
            }

            if (O == 'S') {
                Console.WriteLine(S.ToString("F1", CultureInfo.InvariantCulture));
            }

            else if (O == 'M') {
                S = S / 11.0;
                Console.WriteLine(S.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
