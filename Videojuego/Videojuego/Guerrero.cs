using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Guerrero : Personaje
    {
        public Guerrero(string nombre, int nivel)
        : base(nombre, nivel, 150 + (15 * (nivel - 1)), 30, 15)
        {

        }
    }
}
