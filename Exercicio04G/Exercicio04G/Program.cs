﻿using System;

namespace Exercicio04G {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("{0} {1} {2}", i, i * i, i * i * i);
            }
        }
    }
}
