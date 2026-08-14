using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
     class Circulo : Figura
    {

        public double radio;

        public Circulo(double r)
        {
            radio = r;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
