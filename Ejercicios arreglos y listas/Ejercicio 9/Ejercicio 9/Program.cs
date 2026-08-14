List <int> numeros = new List<int> ();

Console.WriteLine("Ingrese la cantidad de elementos q va a ingresar");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Ingrese un número");
    int elemento = int.Parse(Console.ReadLine());
    numeros.Add(elemento);
}

int max = numeros.Max();
int min = numeros.Min();

Console.WriteLine($"El maximo de esta lista es, {max}.");
Console.WriteLine($"Mientras que el minimo de esta lista es, {min}.");