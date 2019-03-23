using System;
using System.Globalization;

namespace ConsoleApp9 {
    class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            return 60.0 - NotaFinal();
        }

        public override string ToString() {
            return NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }
          
    }
}
