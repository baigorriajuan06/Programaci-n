using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
     class Combate
    {
        public Personaje Personaje1;
        public Personaje Personaje2;
        public Personaje Ganador;
        public int Turnos;

        public Combate(Personaje personaje1, Personaje personaje2)
        {
            Personaje1 = personaje1;
            Personaje2 = personaje2;
        }

        public void Iniciar()
        {
            Turnos = 0;

            while (Personaje1.Vida > 0 && Personaje2.Vida > 0)
            {
                Turnos++;

                int dano = Personaje1.Atacar();
                Personaje2.RecibirDano(dano);
                Personaje1.DañoInfligido += dano;

                if (Personaje2.Vida <= 0)
                {
                    Ganador = Personaje1;
                    break;
                }

                dano = Personaje2.Atacar();
                Personaje1.RecibirDano(dano);
                Personaje2.DañoInfligido += dano;

                if (Personaje1.Vida <= 0)
                {
                    Ganador = Personaje2;
                    break;
                }
            }

            Personaje1.CombatesJugados++;
            Personaje2.CombatesJugados++;

            Ganador.Victorias++;

            if (Ganador == Personaje1)
            {
                Personaje2.Derrotas++;
            }
            else
            {
                Personaje1.Derrotas++;
            }
        }
    }
}
