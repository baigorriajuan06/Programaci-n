
static int SumaDigitos(int numero)
{
    int suma = 0;

    while (numero > 0)
    {
        suma = suma + (numero % 10);
        numero = numero / 10;
    }

    return suma;
}