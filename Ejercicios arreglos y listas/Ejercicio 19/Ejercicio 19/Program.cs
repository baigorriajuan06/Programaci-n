
List<string> resultado = new List<string>();

Console.WriteLine("Ingrese un nombre, (fin para terminar)");
string nombre = Console.ReadLine();

while (nombre != "fin")
{
    char primera = char.ToLower(nombre[0]);
    if ("aeiou".Contains(primera))
    {
        resultado.Add(nombre);
    }
    Console.WriteLine("Ingrese un nombre, (fin para terminar)");
    nombre = Console.ReadLine();
}

Console.WriteLine("Los nombres q comienzan con vocal son:");

foreach (string i in resultado)
{
    Console.WriteLine(i);
}