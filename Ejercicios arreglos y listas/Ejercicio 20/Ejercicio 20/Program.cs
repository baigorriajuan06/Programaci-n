int contador1 = 0;
int contador2 = 0;
int contador3 = 0;

Console.WriteLine("Ingrese su voto, (0 = fina; 1=tomas; 2=juan; 3=daniel)");
int voto = int.Parse(Console.ReadLine());

while (voto != 0)
{
    if (voto == 1)
    {
        contador1 += 1;  
    }
    if (voto == 2)
    {
        contador2 += 1;
    }
    if (voto == 3)
    {  
        contador3 += 1;
    }
    Console.WriteLine("Ingrese su voto");
    voto = int.Parse(Console.ReadLine());
}

Console.WriteLine($"El candidato tomas tiene {contador1} votos, el candidato juan tiene {contador2} votos y el candidato daniel tiene {contador3} votos");