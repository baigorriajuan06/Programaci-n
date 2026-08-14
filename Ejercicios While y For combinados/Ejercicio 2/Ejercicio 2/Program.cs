int promedio = 0;
int contador = 0;
int suma = 0;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Ingrese el nombre del alumno");
    string alumno = Console.ReadLine();
    Console.WriteLine("Ingrese una nota. (-1 para terminar).");
    int nota = int.Parse(Console.ReadLine());
    while (nota != -1)
    {
        suma = suma + nota;
        contador = contador + 1;
        Console.WriteLine("Ingrese otra nota. (-1 para terminar).");
        nota = int.Parse(Console.ReadLine());
    }
    promedio = suma / contador;
    Console.WriteLine($"El alumno, {alumno}, tiene un promedio de {promedio}.");
}