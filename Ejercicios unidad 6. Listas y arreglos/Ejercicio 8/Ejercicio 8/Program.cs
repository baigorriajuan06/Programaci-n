List<int> numeros = new List<int>();
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    int numero = random.Next(1, 21);
    numeros.Add(numero);
}

Console.WriteLine("Los números q se generaron aleatoriamente son: ");

foreach (int i in numeros)
{
    Console.WriteLine(i);
}
