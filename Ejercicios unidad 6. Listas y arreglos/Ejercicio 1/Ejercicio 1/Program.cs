int[] contador = new int[5];
int total = 0;

Console.WriteLine("Ingrese una calificación del 1 al 5 (0 para terminar)");
int calificacion = int.Parse(Console.ReadLine());

while (calificacion != 0)
{
    contador[calificacion - 1]++;
    total++;  
    Console.WriteLine("Ingrese otra calificación (0 para terminar)");
    calificacion = int.Parse(Console.ReadLine());
}

Console.WriteLine("Los porcentajes son");

for (int i = 0; i < 5; i++)
{
    double porcentaje = (contador[i] * 100) / total;
    Console.WriteLine($"Calificación {i + 1}: {porcentaje}%");
}