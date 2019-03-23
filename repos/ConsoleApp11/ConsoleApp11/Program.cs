using System;

namespace ConsoleApp11 {
    class Program {
        static void Main(string[] args) {

            int[] n = new int[20];

            for (int i = 0; i < n.Length; i++) {
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------");
            for (int i = 19; i >= 0; i--) {
                Console.WriteLine(n[i]);
            }

        }
    }
}
