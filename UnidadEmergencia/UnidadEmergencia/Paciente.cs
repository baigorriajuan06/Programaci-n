using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiatemaEmergencia
{
    public class Paciente
    {
        public string Nombre { get; private set; }
        public int Gravedad { get; private set; }

        public Paciente(string nombre, int gravedad)
        {
            Nombre = nombre;
            Gravedad = gravedad;
        }
    }
}
