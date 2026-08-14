using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehiculos;



namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehiculo v = new vehiculo("Toyota");
            v.Conducir();

            automovil a = new automovil("Ford", 4);
            a.Conducir();

            camion c = new camion("Volvo", 2, 5000);

            Console.WriteLine("Marca camion: " + c.Marca);
            Console.WriteLine("Puertas camion: " + c.NumeroDePuertas);
            Console.WriteLine("Capacidad de carga: " + c.CapacidadCarga);
        }
    }
}
