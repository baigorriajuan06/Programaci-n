List<int> numeros = new List<int>();

int contador = 0;

while (contador < 5)
{
    Console.WriteLine("Ingrese un numero");
    int n = int.Parse(Console.ReadLine());
    numeros.Add(n);
    if (n > 5 && n< 100)
    {  
        contador = contador +1;
    }

}

Console.WriteLine("Los números de la lista son:");

foreach (int i in numeros)
    Console.WriteLine(i);
