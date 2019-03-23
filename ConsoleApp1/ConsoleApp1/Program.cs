using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine()); // F9 - BREAKPOINT - F5 - DEBUGGING - F10 - PASSO A PASSO (PULA FUNÇÃO) - SHIFT + F5 INTERROMPE O DEBUGGING
            // F11 - EXECUTAR UM PASSO (ENTRA NA FUNÇÃO)
        
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }
        static int Maior(int n1, int n2, int n3) {
            int m;
            if (n1 > n2 && n1 > n3) {
                m = n1;
            } else if (n2 > n3) {
                m = n2;
            } else {
                m = n3;
            }
            return m;
        }
    }
}
