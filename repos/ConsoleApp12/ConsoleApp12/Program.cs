using System;

namespace ConsoleApp12 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            string[] x = Console.ReadLine().Split(' ');
            int[] y = new int[n];
            
            for (int i = 0; i < n; i++ ) {
                y[i] = int.Parse(x[i]);
            }

            int menor = 0;
            int pos = 0;

            for (int i = 0; i < 2; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (y[i] < y[j]) {
                        menor = y[i];
                    }
                    else {
                        menor = y[j];
                        y[i] = y[j];
                        pos = j;
                    } 
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posição: " + pos);

        }
    }
}
