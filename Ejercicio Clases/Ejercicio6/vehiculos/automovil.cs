using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class automovil : vehiculo
    {
        public int NumeroDePuertas;

        public automovil(string marca, int puertas) : base(marca)
        {
            NumeroDePuertas = puertas;
        }
    }
}
