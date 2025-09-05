using System;
using System.Globalization;

namespace Conta
{
    public class ContaBancaria
    {
        private int _numero;
        public string Titular;
        public double Saldo { get; private set; }

        public int NumConta(int numero)
        {
            return this._numero = numero;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return 
                "Conta: " 
                + _numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
