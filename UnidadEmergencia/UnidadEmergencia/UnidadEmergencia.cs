using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiatemaEmergencia
{
    public abstract class UnidadEmergencia
    {
        public string Identificador { get; private set; }
        public string Estado { get; protected set; }
        public Radio Radio { get; private set; }

        public UnidadEmergencia(string identificador)
        {
            Identificador = identificador;
            Estado = "Disponible";
            Radio = null;
        }

        public void InstalarRadio(Radio radio)
        {
            Radio = radio;
            Console.WriteLine("Radio instalada correctamente.");
        }

        public abstract void EjecutarProtocolo();
    }
}