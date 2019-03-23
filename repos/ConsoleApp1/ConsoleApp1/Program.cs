using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            int result2 = Calculator.Sum(2, 3, 4); // params

            Console.WriteLine(result);
            Console.WriteLine(result2);

        }
    }
}
