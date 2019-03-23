using System;
using System.Globalization;

namespace ConsoleApp15 {
    class Program {
        static void Main(string[] args) {

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] n = new double[100];

            double j = x;

            for (int i = 0; i < n.Length; i++) {
                if (i == 0) {
                    n[0] = x;
                }
                else {
                    j /= 2;
                    n[i] = j;
                }
                Console.WriteLine("n[{0}] = {1}", i, n[i].ToString("F4", CultureInfo.InvariantCulture));
            }

        }
    }
}
