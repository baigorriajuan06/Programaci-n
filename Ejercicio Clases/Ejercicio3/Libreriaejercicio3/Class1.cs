using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Libreriaejercicio3
{
    public class Persona
    {
        public string nombre {  get; set; }
        public int edad {  get; set; }

        public Persona(string nombre, int edad)
        {
            this.nombre = "Juan";
            this.edad = 19;
        }
    }
}
