using System;

namespace ConsoleApp24 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i);
                int f = 2 * n - 1;
                Console.WriteLine(f);
            }

        }
    }
}
