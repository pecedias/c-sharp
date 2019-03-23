using System;

namespace Exercicio03C {
    class Program {
        static void Main(string[] args) {

            int alcool = 0, gasolina = 0, diesel = 0;
            int tipoComb = int.Parse(Console.ReadLine());

            while (tipoComb != 4) {
                if (tipoComb == 1) {
                    alcool += 1;
                }
                else if (tipoComb == 2) {
                    gasolina += 1;
                }
                else if (tipoComb == 3) {
                    diesel += 1;
                }
                tipoComb = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
