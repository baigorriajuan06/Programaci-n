using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public abstract class Cuenta
    {
        public string Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; protected set; }

        public Cuenta(string numero, string titular, decimal saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal importe)
        {
            if (importe <= 0)
            {
                Console.WriteLine("El importe debe ser mayor a cero.");
                return;
            }

            Saldo += importe;

            Console.WriteLine("Depósito realizado correctamente.");
        }

        public abstract void Retirar(decimal importe);
    }
}
