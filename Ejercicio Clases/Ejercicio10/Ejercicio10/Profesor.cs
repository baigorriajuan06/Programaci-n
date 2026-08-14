using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
     class Profesor : Persona
    {
        public string Materia;

        public Profesor(string nombre, string dni, string materia)
            : base(nombre, dni)
        {
            Materia = materia;
        }

        public void Enseñar()
        {
            Console.WriteLine(Nombre + " está enseñando " + Materia);
        }
    }
}
