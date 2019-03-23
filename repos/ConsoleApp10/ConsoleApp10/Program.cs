using System;

namespace ConsoleApp10 {
    class Program {
        static void Main(string[] args) {

            int[] n = new int[10];

            int v = int.Parse(Console.ReadLine());
            n[0] = v;
            Console.WriteLine("n[0] = {0}", n[0]);
            for (int i = 1; i < n.Length; i++) {
                v = v * 2;
                Console.WriteLine("n[{0}] = {1}", i, v);
            }

        }
    }
}
