int promedio = 0;
int suma = 0;
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingrese un numero");
    int numero = int.Parse(Console.ReadLine());
    suma += numero;
}
promedio = suma / 8;
Console.WriteLine($"El promedio es {promedio}");