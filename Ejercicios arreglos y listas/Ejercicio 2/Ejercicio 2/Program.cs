Console.WriteLine("Ingrese la cantidad de calificaciones: ");
int cant_calificaciones = int.Parse(Console.ReadLine());
int[] calificaciones = new int[cant_calificaciones];
int suma = 0;
int promedio = 0;
for ( int i = 0; i < cant_calificaciones; i++)
{
    Console.WriteLine("Ingrese una calificacion: ");
    calificaciones[i] = int.Parse(Console.ReadLine());
    suma += calificaciones[i];
    promedio = suma / cant_calificaciones;
}
Console.WriteLine($"El promedio es de {promedio}");