using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
     class Mago : Personaje
    {
        public Mago(string nombre, int nivel)
       : base(nombre, nivel, 100 + (10 * (nivel - 1)), 50, 5)
        {
        }
    }
}
