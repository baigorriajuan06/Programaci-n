Console.WriteLine("Ingrese la cantidad de numeros q desea poner en el arreglo");
int elemento = int.Parse(Console.ReadLine());
int [] a = new int [elemento];

for (int i = 0; i < elemento; i++) 
{
    Console.WriteLine("Ingrese un elemento");
    a[i] = int.Parse(Console.ReadLine());
}

Array.Reverse (a);

Console.WriteLine($"El array inverso es,");
for (int i = 0;i < elemento; i++)
{
    Console.WriteLine($"{a[i]}");
}