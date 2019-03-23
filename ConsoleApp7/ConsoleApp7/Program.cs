using System;
using System.Globalization;

namespace ConsoleApp7 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            double area = r.Area();
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            double perimetro = r.Perimetro();
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            double diagonal = r.Diagonal();
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
