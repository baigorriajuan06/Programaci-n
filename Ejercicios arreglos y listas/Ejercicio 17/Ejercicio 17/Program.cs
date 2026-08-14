List<int> numeros = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un número");
    numeros.Add(int.Parse(Console.ReadLine()));

}

int contador = 0;

List<int> num = new List<int>();

for (int i = 0;i <10; i++)
{
    contador = 0;
    for (int j = 0; j < 9; j++)
    {
        if (numeros[i] == numeros[j + 1])
        {
            contador++;
        }
    }
     num.Add(contador);
}

int max = num.Max();
int ba = num.IndexOf(max);

Console.WriteLine($"El numero q mas se repite es el, {numeros[ba]}");