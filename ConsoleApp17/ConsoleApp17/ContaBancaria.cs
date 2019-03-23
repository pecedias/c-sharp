using System;
using System.Globalization;

namespace ConsoleApp17 {
    class ContaBancaria {

        public int Numero { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }

        public double Taxa = 5.00;

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            _titular = titular;
            //    Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            //    Saldo = depositoInicial;
            ValorDeposito(depositoInicial);
        }

        public string Nome {
            get { return _titular; }
            set {
                if (value != null && value.Length > 1) {
                    _titular = value;
                }
            }
        }

        public void ValorDeposito(double deposito) {
            Saldo += deposito;
        }

        public void ValorSaque(double saque) {
            Saldo -= saque;
            Saldo -= Taxa;
        }

        public override string ToString() {
            return "Conta "
                   + Numero
                   + ", Titular: "
                   + _titular
                   + ", Saldo: $ "
                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
