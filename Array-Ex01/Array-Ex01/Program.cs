using System;

namespace Array_Ex01 {
    class Program {
        static void Main(string[] args) {

            int[] x = new int[10];

            for (int i = 0; i < x.Length; i++) {
                x[i] = int.Parse(Console.ReadLine());
                if (x[i] == 0 || x[i] < 0) {
                    x[i] = 1;
                }
            }

            for (int i = 0; i < x.Length; i++) {
                Console.WriteLine("x[{0}] = {1}", i, x[i]);
            }

        }
    }
}
