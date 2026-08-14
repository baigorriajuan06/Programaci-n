Console.WriteLine("Ingrese una frase: ");
string frase = Console.ReadLine();

string [] palabras = frase.Split(' ');

List<string> plsucs = new List<string>();
List<int> contadores = new List<int>();

for (int i = 0; i < palabras.Length; i++)
{
    int contador = 0;
    for (int j = 0; j < palabras.Length; j++)
    {
        if (palabras[i] == palabras[j])
        {
            contador++;
        }
    }
    if (!plsucs.Contains(palabras[i]))
        {
            plsucs.Add(palabras[i]);
            contadores.Add(contador);
        }
}

for (int i = 0; i < plsucs.Count; i++)
{
    Console.WriteLine($"La palabra {plsucs[i]} se repite {contadores[i]} veces");
}