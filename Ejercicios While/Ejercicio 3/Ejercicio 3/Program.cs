int cantidad_de_nombres = 0;
Console.WriteLine("Ingrese un nombre. (vacio para terminar)");
string persona = Console.ReadLine();
while (persona != "")
{
    cantidad_de_nombres = cantidad_de_nombres + 1;
    Console.WriteLine("Ingrese otro nombre. (vacio para terminar)");
    persona = Console.ReadLine();
}
Console.WriteLine($"La cantidad de nombres ingresados es de, {cantidad_de_nombres}");