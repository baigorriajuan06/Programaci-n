using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace EjercicioLibreria2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();

            empleado1.Nombre = "Juan";
            empleado1.Edad = 19;
            empleado1.Puesto = "Programador";

            empleado1.Trabajar();
        }
    }
}



