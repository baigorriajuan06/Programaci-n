int[] pares = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingrese un numero");
    pares[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Los números pares son:");
for  (int i = 0;i < 8;i++)
{
    if (pares[i] % 2 == 0)
    {
        Console.WriteLine($"{pares[i]}");
    }
}