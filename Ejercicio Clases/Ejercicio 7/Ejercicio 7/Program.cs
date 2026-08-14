using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio: ");
            double r = double.Parse(Console.ReadLine());

            Circulo c = new Circulo(r);

            Console.Write("Ingrese la base: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double a = double.Parse(Console.ReadLine());

            Rectangulo rect = new Rectangulo(b, a);

            Console.WriteLine("Área del círculo: " + c.CalcularArea());
            Console.WriteLine("Área del rectángulo: " + rect.CalcularArea());

            Console.ReadKey();
        }
    }
}
