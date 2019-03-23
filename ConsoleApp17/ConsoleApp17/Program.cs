using System;
using System.Globalization;

namespace ConsoleApp17 {
    class Program {
        static void Main(string[] args) {

            //            double deposito = 0.0;
            ContaBancaria c;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre com um valor para depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                c = new ContaBancaria(numero, titular);
            }

            //            ContaBancaria c = new ContaBancaria(numero, titular);
            //            c.ValorDeposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.ValorDeposito(deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.ValorSaque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

        }
    }
}