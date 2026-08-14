static int ContarLetra(string texto, char letra)
{
    int contador = 0;

    for (int i = 0; i < texto.Length; i++)
    {
        if (texto[i] == letra)
        {
            contador++;
        }
    }

    return contador;
}