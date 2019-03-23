using System;

namespace ConsoleApp14 {
    class Program {
        static void Main(string[] args) {

            int[] n = new int[10];

            int t = int.Parse(Console.ReadLine());

            int j = 0;

            for (int i = 0; i < n.Length; i++) {
                if (j >= t) {
                    j = 0;
                }
                n[i] = j;
                Console.WriteLine("n[{0}] = {1}", i, n[i]);
                j++;
            }

        }
    }
}
