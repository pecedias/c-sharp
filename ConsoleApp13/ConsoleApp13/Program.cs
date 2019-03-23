using System;
using System.Globalization;

namespace ConsoleApp13 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorReal = ConversorDeMoeda.ConverterDolar(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + valorReal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
