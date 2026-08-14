using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
     class Estudiante : Persona
    {
        public string Legajo;

        public Estudiante(string nombre, string dni, string legajo)
            : base(nombre, dni)
        {
            Legajo = legajo;
        }

        public void Estudiar()
        {
            Console.WriteLine(Nombre + " está estudiando.");
        }
    }
}
