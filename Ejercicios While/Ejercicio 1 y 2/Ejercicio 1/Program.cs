int suma = 0;
Console.WriteLine("Ingrese un numero positivo. (0 para terminar).");
int numero = int.Parse(Console.ReadLine());
int cantidad = 0;

while (numero != 0)
{
    suma = suma + numero;
    cantidad = cantidad + 1;
    Console.WriteLine("Ingrese otro numero positivo. (0 para terminar).");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine($"La suma de los números es, {suma}");
int promedio;
promedio = suma / cantidad;
Console.WriteLine($"El promedio es; {promedio}");