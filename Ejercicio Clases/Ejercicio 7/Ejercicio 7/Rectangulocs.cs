using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
     class Rectangulo : Figura
    {
        public double baseRectangulo;
        public double altura;

        public Rectangulo(double b, double a)
        {
            baseRectangulo = b;
            altura = a;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * altura;
        }
    }
}

