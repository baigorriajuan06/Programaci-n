using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class vehiculo
    {
        public string Marca;

        public vehiculo(string marca)
        {
            Marca = marca;
        }

        public void Conducir()
        {
            Console.WriteLine("El vehículo está en movimiento");
        }
    }
}
