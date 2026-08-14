using System.ComponentModel.Design;

Console.WriteLine("Ingrese un numero");
String entrada = Console.ReadLine();
int numero;


if (int.TryParse(entrada,out numero))
{
    Console.WriteLine($"Ingresaste el número {numero}");
}
else
{
    Console.WriteLine("No ingresaste un número");
}
    