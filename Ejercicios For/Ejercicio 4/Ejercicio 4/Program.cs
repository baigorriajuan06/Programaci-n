Console.WriteLine("Ingrese un número");
int mayor = int.Parse(Console.ReadLine());
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Ingrese un nunmero");
    int numero = int.Parse(Console.ReadLine());
    if (numero > mayor)
    {
        mayor = numero;
    }
}
Console.Write($"El mayor numero es el {mayor}");