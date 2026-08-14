List<string> cursoa = new List<string>();
List<string> cursob = new List<string>();
List<string> cursoc = new List<string>();

Console.WriteLine("Ingrese un alumno al curso A");
string alumnoa = Console.ReadLine();

while (alumnoa != "fin")
{
    cursoa.Add(alumnoa);
    Console.WriteLine("Ingrese un alumno al curso A (fin para terminar)");
    alumnoa = Console.ReadLine();
}

Console.WriteLine("Ingrese un alumno al curso B");
string alumnob = Console.ReadLine();

while (alumnob != "fin")
{
    cursob.Add(alumnob);
    Console.WriteLine("Ingrese un alumno al curso B (fin para terminar)");
    alumnob = Console.ReadLine();
}

Console.WriteLine("Ingrese un alumno al curso C");
string alumnoc = Console.ReadLine();

while (alumnoc != "fin")
{
    cursoc.Add(alumnoc);
    Console.WriteLine("Ingrese un alumno al curso C (fin para terminar)");
    alumnoc = Console.ReadLine();
}

Console.WriteLine($"El curso A tiene {cursoa.Count}");Console.WriteLine($"El curso B tiene {cursob.Count}"); Console.WriteLine($"El curso C tiene {cursoc.Count}");