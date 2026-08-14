using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
     class ProductoElectronico : Producto
    {
        public double Voltaje;
        public bool TieneGarantia;

        public ProductoElectronico(string nombre, double precio, double voltaje, bool tieneGarantia)
            : base(nombre, precio)
        {
            Voltaje = voltaje;
            TieneGarantia = tieneGarantia;
        }
    }
}
