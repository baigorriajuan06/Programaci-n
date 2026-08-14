using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class camion : automovil
    {
        public double CapacidadCarga;

        public camion(string marca, int puertas, double carga)
            : base(marca, puertas)
        {
            CapacidadCarga = carga;
        }
    }
}
