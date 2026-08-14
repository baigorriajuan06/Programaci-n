Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
int productos_comprados = int.Parse(Console.ReadLine());
int total_producto = 0;
Console.WriteLine("Ingrese la cantidad de un producto.(0 para terminar)");
int producto = int.Parse(Console.ReadLine());
int total_adeudado = 0;
while (producto != 0)
{
    Console.WriteLine("Ingrese el costo unitario del producto");
    int costo = int.Parse(Console.ReadLine());
    total_adeudado = total_adeudado + (producto * costo);
    Console.WriteLine("Ingrese la cantidad de otro producto.(0 para terminar)");
    producto = int.Parse(Console.ReadLine());
}
Console.WriteLine($"La deuda es de {total_adeudado}");