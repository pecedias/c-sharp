using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5 {
    class Triangulo {                // Classe
        public double A;            // Atributo
        public double B;
        public double C;

        public double Area() {      // Método
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
