using System;
using System.Globalization;

namespace Exercicio04D {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0]);
                double b = double.Parse(valores[1]);

                if (b != 0) {
                    double divisao = a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
