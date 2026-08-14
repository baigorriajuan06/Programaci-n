List<int> numeros = new List<int>();

for  (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero");
    numeros.Add(int.Parse(Console.ReadLine()));
}

numeros.Reverse();

List<int> invertida = new List<int>();

for  (int i = 0;i < 5;i++)
{
    invertida.Add(numeros[i]);
}

Console.WriteLine("La nueva lista invertida es:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{invertida[i]}");
}
