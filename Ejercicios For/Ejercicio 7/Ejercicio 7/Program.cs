Console.WriteLine("Ingrese un número");
int numero = int.Parse(Console.ReadLine());
string pares = "";
for (int i = 0; i < numero; i++)
{
    if ( i % 2 == 0)
    {
        pares += i + "";
    }
}
Console.WriteLine($"Los númerosm pares son {pares}");