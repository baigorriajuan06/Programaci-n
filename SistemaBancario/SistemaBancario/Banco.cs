using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Banco
    {
        private List<Cuenta> cuentas = new List<Cuenta>();

        public bool AgregarCuenta(Cuenta cuenta)
        {
            foreach (Cuenta c in cuentas)
            {
                if (c.Numero == cuenta.Numero)
                {
                    return false;
                }
            }

            cuentas.Add(cuenta);
            return true;
        }
        public Cuenta BuscarCuenta(string numero)
        {
            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.Numero == numero)
                {
                    return cuenta;
                }
            }

            return null;
        }

        public List<Cuenta> ObtenerCuentas()
        {
            return cuentas;
        }
    }
}
