int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un numero");
    numeros[i] = int.Parse(Console.ReadLine());
}

int ultimo = numeros[10 - 1];

for (int i = 9; i > 0; i--)
{
    numeros [i] = numeros [i - 1];
}

numeros [0] = ultimo;

Console.WriteLine("La lista es: ");

foreach (int i in numeros)
{
    Console.WriteLine(i);
}