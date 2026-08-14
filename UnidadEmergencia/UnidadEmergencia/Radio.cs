using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiatemaEmergencia
{
    public class Radio
    {
        public string Modelo { get; private set; }
        public bool Encendida { get; private set; }

        public Radio(string modelo)
        {
            Modelo = modelo;
            Encendida = false;
        }

        public void Encender()
        {
            Encendida = true;
            Console.WriteLine("Radio encendida.");
        }

        public void Bip()
        {
            if (Encendida)
            {
                Console.WriteLine("Bip, bip: Cambio y fuera");
            }
            else
            {
                Console.WriteLine("La radio está apagada.");
            }
        }
    }
}
