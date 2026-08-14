using System.Data;

Console.WriteLine("Ingrese el nomnbre del estudiante");
string alumno1 = Console.ReadLine();
List<int> al1 = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese una nota");
    al1.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("Ingrese el nomnbre del estudiante");
string alumno2 = Console.ReadLine();
List<int> al2 = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese una nota");
    al2.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("Ingrese el nomnbre del estudiante");
string alumno3 = Console.ReadLine();
List<int> al3 = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese una nota");
    al3.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("Ingrese el nomnbre del estudiante");
string alumno4 = Console.ReadLine();
List<int> al4 = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese una nota");
    al4.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("Ingrese el nomnbre del estudiante");
string alumno5 = Console.ReadLine();
List<int> al5 = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese una nota");
    al5.Add(int.Parse(Console.ReadLine()));
}
double promedioal1 = al1.Average();
double promedioal2 = al2.Average();
double promedioal3 = al3.Average();
double promedioal4 = al4.Average();
double promedioal5 = al5.Average();
Console.WriteLine($"El alumno {alumno1}, tiene un promedio de {promedioal1}");
Console.WriteLine($"El alumno {alumno2}, tiene un promedio de {promedioal2}");
Console.WriteLine($"El alumno {alumno3}, tiene un promedio de {promedioal3}");
Console.WriteLine($"El alumno {alumno4}, tiene un promedio de {promedioal4}");
Console.WriteLine($"El alumno {alumno5}, tiene un promedio de {promedioal5}");