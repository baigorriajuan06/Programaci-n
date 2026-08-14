Console.WriteLine("Ingrese el codigo del producto. (0 para terminar).");
int producto = int.Parse(Console.ReadLine());
int producto_de_mayor_cantidad = 0;
int mayor_cantidad = 0;
while (producto != 0)
{
    Console.WriteLine("Ingrese el precio del producto");
    int precio = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad del producto");
    int cantidad = int.Parse(Console.ReadLine());
    if (cantidad > producto_de_mayor_cantidad)
    {
        producto_de_mayor_cantidad = cantidad;
        mayor_cantidad = producto;
    }
    Console.WriteLine("Ingrese el codigo del producto. (0 para terminar).");
    producto = int.Parse(Console.ReadLine());
}
Console.WriteLine($"El producto de mayor cantidad que se compro es el, {mayor_cantidad}");