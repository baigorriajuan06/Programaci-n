static void MostrarInverso(int[] numeros)
{
    Array.Reverse(numeros);

    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }
}