using System;

namespace ConsoleApp27 {
    class Program {
        static void Main(string[] args) {

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = 10; 
            int total = (valor1 > 20) ? valor1 : valor2;

            Console.WriteLine(total);

        }
    }
}
