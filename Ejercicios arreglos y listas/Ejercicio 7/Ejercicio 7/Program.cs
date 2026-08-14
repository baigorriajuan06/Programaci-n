List<string> nombres = new List<string>();


Console.WriteLine("Ingrese un nombre");
string nombre = Console.ReadLine();

while (nombre != "fin")
{
    nombres.Add(nombre);

    Console.WriteLine("Ingrese otro nombre, (fin para terminar)");
    nombre = Console.ReadLine();
}
Console.WriteLine($" Los nombres ingresados son,");
for (int i = 0; i < nombres.Count; i++)
{
    Console.WriteLine($"{nombres[i]}");
}

foreach (string i in nombres)
{
    Console.WriteLine(i);
}