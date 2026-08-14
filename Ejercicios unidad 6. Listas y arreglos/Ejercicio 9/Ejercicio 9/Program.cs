using System.ComponentModel.Design;
using System.Globalization;

List<string> estados = new List<string>();

string estado = "";
string opcion;

do
{
    Console.WriteLine("(ver estado) para ver el estado actual, (cambiar estado) para modificar el estado, (eliminar estado) para borrar el estado actual.");
    string accion = Console.ReadLine();
    if (accion == "cambiar estado")
    {
        Console.WriteLine("ingrese un estado");
        estado = Console.ReadLine();
        estados.Add(estado);
    }
    if (accion == "ver estado")
    {
        Console.WriteLine($"El estado es {estado}");
    }
    if (accion == "eliminar estado")
    {
        estado = "eliminado";
    }
    Console.WriteLine("(menu) para realizar una accion, para no hacer nada (salir) ");
    opcion = Console.ReadLine();
} while (opcion != "salir");

Console.WriteLine("Si desea ver el historual de estados ingrese (si), sino (no)");
string estadoslist = Console.ReadLine();

if  (estadoslist == "si")
{
    Console.WriteLine("El historial de estados es: ");
    for (int i = 0; i < estados.Count; i++)
    {
        Console.WriteLine(estados[i]);
    }
}
