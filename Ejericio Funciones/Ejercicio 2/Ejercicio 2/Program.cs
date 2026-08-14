List<int> numeros = new List<int>();
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);

static int SumarLista(List<int> numeros)
{
    int suma = 0;

    foreach (int numero in numeros)
        suma = (suma + numero);

    return suma;
}

int sumatoria = SumarLista(numeros);