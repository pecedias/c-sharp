using System;

namespace ConsoleApp13 {
    class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double ConverterDolar(double c, double qte) {
            return c * (qte + (Iof * qte / 100));
        }

    }
}
