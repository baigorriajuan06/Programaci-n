int total_adeudado = 0;
Console.WriteLine("Ingrese el costo unitario. (0 para finalizar)");
int costo_unitario = int.Parse(Console.ReadLine());
while (costo_unitario != 0)
{
    Console.WriteLine("Ingrese la cantidad comprada");
    int cantidad_comprada = int.Parse(Console.ReadLine());
    total_adeudado = total_adeudado + (costo_unitario * cantidad_comprada);
    Console.WriteLine("Ingrese el costo unitario. (0 para finalizar)");
    costo_unitario = int.Parse(Console.ReadLine());
}
Console.WriteLine($"El total adeudado es de; {total_adeudado}");