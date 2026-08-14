using System.Security.Cryptography.X509Certificates;

static string palabramaslarga (string texto)
{
    string[] palabras = texto.Split(' ');
    string mayor = "";

    foreach (string i in palabras)
    {
        if (i.Length > mayor.Length)
        {
            mayor = i;
        }
    }
    return mayor;
}