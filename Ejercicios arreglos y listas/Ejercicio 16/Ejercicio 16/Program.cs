int[] numeros = { 2, 5, 7 };

foreach (int num in numeros)
{
    Console.WriteLine($"Tabla del {num}:");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }

    Console.WriteLine();
}