List<int> numeros = new List<int>();

Console.WriteLine("Ingrese la cantidad de numeros q va a ingresar");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Ingrese un número");
    numeros.Add(int.Parse(Console.ReadLine()));
}

List<int> pares = new List<int>();
List<int> impares = new List<int>();

foreach (int i in numeros)
{
    if (i % 2 == 0)
    {
        pares.Add(i);
    }
    else
    {
        impares.Add(i);
    }
}

Console.WriteLine("Los numeros pares son:");
foreach (int i in pares)
    Console.WriteLine($"{i}");

Console.WriteLine("Los numeros impares son:");
foreach (int i in impares)
    Console.WriteLine($"{i}");