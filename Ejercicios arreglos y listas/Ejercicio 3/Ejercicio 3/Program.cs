Console.WriteLine("Ingrese el numero q desea buscar");
int numero = int.Parse(Console.ReadLine());
int[] num = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    num[i] = int.Parse(Console.ReadLine());
    do
    {
        if (num[i] == numero)
        {
            Console.WriteLine($" el numero {numero}, si esta en el arreglo");
        }
    } while (num[i] != numero);
}

List<int> numeros = new List<int>();

numeros.Add(1);
numeros.Add(20);
numeros.Add(3);

Console.WriteLine("Ingrese el numero q desea buscar dentro de la lista");
int numeroDadoPorUsuario = int.Parse(Console.ReadLine());

if (numeros.Contains(numeroDadoPorUsuario))
{
    Console.WriteLine($" el numero {numeroDadoPorUsuario}, si esta en la lista");
}
else
{
    Console.WriteLine($" el numero {numeroDadoPorUsuario}, no esta en la lista");
}