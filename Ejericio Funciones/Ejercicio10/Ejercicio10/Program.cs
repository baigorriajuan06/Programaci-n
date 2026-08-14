static void MostrarPares(int inicio, int fin)
{
    for (int i = inicio; i <= fin; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}