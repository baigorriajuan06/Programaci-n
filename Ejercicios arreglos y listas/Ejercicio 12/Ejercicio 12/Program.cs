List<int> numeros = new List<int>();
Console.WriteLine("Ingrese la cantidad de numero que desea ingresar");
int cant = int.Parse(Console.ReadLine());
int contador = 0;
for  (int i = 0; i < cant; i++)
{
    Console.WriteLine("Ingrese un numero");
    numeros.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < numeros.Count; i++)
{
    for (int j = i +1; j < numeros.Count; j++)
    {
        if (numeros[j] == numeros[i])
        {
            contador = contador + 1;
        }
    }
}
Console.WriteLine($"Los numeros se repiten {contador}, veces");