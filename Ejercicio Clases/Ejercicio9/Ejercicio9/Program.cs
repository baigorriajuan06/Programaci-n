using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoPerecedero producto1 = new ProductoPerecedero(
           "Leche",
           1000,
           new DateTime(2026, 8, 20)
       );

            ProductoElectronico producto2 = new ProductoElectronico(
                "Televisor",
                500000,
                220,
                true
            );

            Console.WriteLine("Producto: " + producto1.Nombre);
            Console.WriteLine("¿Está vencido?: " + producto1.EstaVencido());

            Console.WriteLine();

            Console.WriteLine("Producto: " + producto2.Nombre);
            Console.WriteLine("Voltaje: " + producto2.Voltaje);
            Console.WriteLine("¿Tiene garantía?: " + producto2.TieneGarantia);
        }
    }
}
