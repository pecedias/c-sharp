using System;

namespace Exercicio04E {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int f = 1;
            for (int i = 1; i <= n; i++) {
                f *= i;        
            }
            Console.WriteLine(f);
        }
    }
}
