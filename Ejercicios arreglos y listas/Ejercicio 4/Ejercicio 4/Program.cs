List<int> numeros = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero");
    int n = int.Parse(Console.ReadLine());
    numeros.Add(n);
}
int aux = 0;
for (int i = 0; i < numeros.Count - 1; i++)
{
    for (int j = 0; j < numeros.Count - 1; j++)
{
        if (numeros[j] > numeros[j + 1])
{
            aux = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = aux;
        }
    }
}
Console.WriteLine("La lista ordenada es: ");
for (int i = 0; i <5; i++)
{
    Console.WriteLine($"{numeros[i]}");
}