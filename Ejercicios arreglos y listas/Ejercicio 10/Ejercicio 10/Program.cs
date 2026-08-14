using System.Collections;

Console.WriteLine("Ingrese la cantidad de elementos que va a tener la lista");
int cantidad = int.Parse(Console.ReadLine());

List <int> numeros = new List<int>();

for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Ingrese un número");
    int num = int.Parse(Console.ReadLine());
    numeros.Add(num);
}

numeros.RemoveAll(num => num < 0);

Console.WriteLine("Los números positivos de la lista son,");

foreach (int num in numeros)
{
    Console.WriteLine(num);
}

