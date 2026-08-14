using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese la cantidad de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el peso en MB: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el formato: ");
            string formato = Console.ReadLine();

            LibroDigital libro = new LibroDigital(titulo, autor, paginas, peso, formato);

            Console.WriteLine("Libro creado correctamente.");
        }
    }
}
