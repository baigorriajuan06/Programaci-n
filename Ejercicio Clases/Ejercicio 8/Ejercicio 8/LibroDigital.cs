using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
     class LibroDigital : Libro
    {
        public double PesoEnMB;
        public string Formato;

        public LibroDigital(string titulo, string autor, int paginas, double pesoEnMB, string formato)
            : base(titulo, autor, paginas)
        {
            PesoEnMB = pesoEnMB;
            Formato = formato;
        }
    }
}
