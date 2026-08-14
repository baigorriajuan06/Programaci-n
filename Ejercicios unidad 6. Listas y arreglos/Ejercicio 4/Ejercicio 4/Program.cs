List<int> numeros = new List<int>();

Console.WriteLine("Ingrese un numero");
int num = int.Parse(Console.ReadLine());
int contador = 0;

while (num != 0)
{
    contador++;
    numeros.Add(num);
    Console.WriteLine("Ingrese un numero (0 para terminar)");
    num = int.Parse(Console.ReadLine());
}

List<int> sinrep = new List<int>();

for(int i = 0; i < contador; i++)
{
    if (!sinrep.Contains(numeros[i]))
    {
            sinrep.Add(numeros[i]);
    }
}

Console.WriteLine("Los valores ingresados sin repeticiones son: ");

foreach (int i in sinrep)
{
    Console.WriteLine(i);
}