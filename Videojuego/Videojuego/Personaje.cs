using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
     class Personaje
    {
        public string Nombre;
        public int Nivel;
        public int Vida;
        public int Ataque;
        public int Defensa;

        public int CombatesJugados;
        public int Victorias;
        public int Derrotas;
        public int DañoInfligido;
        public int DañoRecibido;

        public Personaje(string nombre, int nivel, int vida, int ataque, int defensa)
        {
            Nombre = nombre;
            Nivel = nivel;
            Vida = vida;
            Ataque = ataque;
            Defensa = defensa;
        }

        public virtual int Atacar()
        {
            return Ataque;
        }

        public virtual void RecibirDano(int dano)
        {
            int danoFinal = dano - Defensa;

            if (danoFinal < 0)
            {
                danoFinal = 0;
            }

            Vida = Vida - danoFinal;
            DañoRecibido = DañoRecibido + danoFinal;
        }
    }
}
