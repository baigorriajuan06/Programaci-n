using System.Security.Cryptography.X509Certificates;

string nombreMayor = "";
int mayorGasto = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese el nombre del cliente");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el total gastado");
    int gasto = int.Parse(Console.ReadLine());

    if (i == 0 || gasto > mayorGasto)
    {
        mayorGasto = gasto;
        nombreMayor = nombre;
    }
}
Console.Write($"El que mas gasto es {nombreMayor}");