int factorial = 1;

Console.WriteLine("Ingrese un número");
int numero = int.Parse(Console.ReadLine());
for (int i = 1; i < numero; i++)
{ 
    factorial *= i;
}
Console.Write($"El factorial de {numero} es {factorial}");