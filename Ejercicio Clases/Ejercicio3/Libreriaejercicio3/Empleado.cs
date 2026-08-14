using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreriaejercicio3
{
    public class Empleado: Persona
    {
        public string puesto {  get; set; }

        public Empleado(string nombre, int edad, string puesto)
            :base(nombre, edad)
        {
            this.puesto = "Desarrollador";
        }
    }
}
