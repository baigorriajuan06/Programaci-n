List<int> numeros = new List<int>();

Console.WriteLine("Ingresá la cantidad de números q va a ingresar: ");
int cant = int.Parse(Console.ReadLine());

for (int i = 0; i < cant; i++)
{
    Console.WriteLine("Ingrese un número");
    numeros.Add(int.Parse(Console.ReadLine()));
}

int aux;

for (int i = 0; i < cant; i++)
{
    for (int j = 0; j < cant - 1; j++)
    {
        if (numeros[j] > numeros[j + 1])
        {
            aux = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = aux;
        }
    }
}

Console.WriteLine("La lista ordenada es:");

foreach (int i in numeros)
{
    Console.WriteLine(i);
}