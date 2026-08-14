using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudiante estudiante = new Estudiante("Juan", "12345678", "4567");

            Profesor profesor = new Profesor("Carlos", "87654321", "Matemática");

            estudiante.Estudiar();
            profesor.Enseñar();
        }
    }
}
