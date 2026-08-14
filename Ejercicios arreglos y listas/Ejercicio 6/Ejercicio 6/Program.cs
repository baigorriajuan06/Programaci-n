List<int> numeros = new List<int>();

numeros.Add(1);
numeros.Add(20);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5); 
numeros.Add(6);
numeros.Add(7);
numeros.Add(8); 
numeros.Add(9);
numeros.Add(10);
numeros.Add(11);
numeros.Add(12);

int contador = 0;

Console.WriteLine("Ingrese el numero q desea buscar dentro de la lista");
int numeroDadoPorUsuario = int.Parse(Console.ReadLine());

if (numeros.Contains(numeroDadoPorUsuario))
{
    contador = contador + 1;
}

Console.WriteLine($"El número {numeroDadoPorUsuario}, aparece {contador} vez en la lista");