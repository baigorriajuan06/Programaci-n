using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            list.Add(new Perro());
            list.Add(new Gato());

            foreach (Animal animal in list) 
            {
                animal.HacerSonido();
            } 
        }
    }
}
