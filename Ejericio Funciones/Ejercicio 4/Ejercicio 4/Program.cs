static int nombres (string nombre)
{
    int contador = 0;
    foreach (char i in nombre)
    {
        if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
        {
            contador++;
        }
    }
    return contador;
}

int vocales = nombres("juan, tomas, daniel");

Console.WriteLine(vocales);