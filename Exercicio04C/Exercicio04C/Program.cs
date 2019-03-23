﻿using System;
using System.Globalization;

namespace Exercicio04C {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double mp = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(mp.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
