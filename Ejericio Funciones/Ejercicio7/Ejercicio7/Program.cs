static int[] TablaMultiplicar(int numero)
{
    int[] tabla = new int[10];

    for (int i = 1; i <= 10; i++)
    {
        tabla[i - 1] = numero * i;
    }

    return tabla;
}