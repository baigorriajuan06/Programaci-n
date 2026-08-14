using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
     class ProductoPerecedero : Producto
    {
        public DateTime FechaCaducidad;

        public ProductoPerecedero(string nombre, double precio, DateTime fechaCaducidad)
            : base(nombre, precio)
        {
            FechaCaducidad = fechaCaducidad;
        }

        public bool EstaVencido()
        {
            return DateTime.Now > FechaCaducidad;
        }
    }
}
