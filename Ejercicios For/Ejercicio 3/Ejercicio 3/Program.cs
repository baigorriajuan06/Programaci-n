int totaladeudado = 0;
int totalfactura = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese la cantidad comprada");
    int cantidadcomprada = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el costo unitario");
    int costounitario = int.Parse(Console.ReadLine());
    totaladeudado = cantidadcomprada * costounitario;
    totalfactura = totalfactura + totaladeudado;
}
Console.Write($"El total adeudado es {totalfactura}");