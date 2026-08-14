List<string> nombres = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un nombre");
    nombres.Add(Console.ReadLine());
}

List<string> largas = new List<string>();

foreach (string i in nombres)
{
    if (i.Length > 5)
    {
        largas.Add(i);
    }
}

Console.WriteLine("Los nombres con mas de 5 letras son:");

foreach (string i in largas)
{
    Console.WriteLine(i);
}