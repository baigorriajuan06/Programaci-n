using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class CuentaEstandar : Cuenta
    {
        private const decimal LIMITE_RETIRO = 50000;
        private const decimal COMISION = 0.05m;

        public CuentaEstandar(string numero, string titular, decimal saldoInicial)
            : base(numero, titular, saldoInicial)
        {
        }

        public override void Retirar(decimal importe)
        {
            if (importe <= 0)
            {
                Console.WriteLine("El importe debe ser mayor a cero.");
                return;
            }

            if (importe > LIMITE_RETIRO)
            {
                Console.WriteLine("No se puede retirar más de $50.000.");
                return;
            }
            decimal comision = importe * COMISION;
            decimal total = importe + comision;

            if (total > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }

            Saldo -= total;

            Console.WriteLine("Retiro realizado correctamente.");
            Console.WriteLine("Comisión: $" + comision);
        }
    }
}
