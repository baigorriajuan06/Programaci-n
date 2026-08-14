using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
     class Arquero : Personaje
    {
        Random random = new Random();

        public Arquero(string nombre, int nivel)
            : base(nombre, nivel, 120 + (12 * (nivel - 1)), 25, 10)
        {
        }

        public override int Atacar()
        {
            int dano = Ataque;

            int numero = random.Next(1, 101);

            if (numero <= 25)
            {
                dano = dano * 2;
            }

            return dano;
        }
    }
}
