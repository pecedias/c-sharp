using System;
using System.Globalization;

namespace ConsoleApp21 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] preco = new double[n];

            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Nome Produto " + i);
                nome[i] = Console.ReadLine();
                Console.WriteLine("Preço Produto " + i);
                preco[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += preco[i];
            }

            double avg = soma / n;

            Console.WriteLine("Preço médio dos Produtos: " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
