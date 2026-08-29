using AccesoDatos.Data;
using AccesoDatos.Models;
using AccesoDatos.Repositories;
using Microsoft.EntityFrameworkCore;

using (var context = new BibliotecaContext())
{
    context.Database.Migrate();
}

var autorRepository = new AutorRepository();
var libroRepository = new LibroRepository();

bool continuar = true;

while (continuar)
{
    Console.WriteLine();
    Console.WriteLine("===== BIBLIOTECA =====");
    Console.WriteLine("1. Alta Autor");
    Console.WriteLine("2. Alta Libro");
    Console.WriteLine("3. Ver Libros");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            AltaAutor();
            break;

        case "2":
            AltaLibro();
            break;

        case "3":
            VerLibros();
            break;

        case "0":
            continuar = false;
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("La opción ingresada no es válida.");
            break;
    }

    if (continuar)
    {
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}

void AltaAutor()
{
    Console.WriteLine("--- ALTA DE AUTOR ---");
    Console.Write("Nombre del autor: ");

    string? nombre = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(nombre))
    {
        Console.WriteLine("El nombre no puede estar vacío.");
        return;
    }

    var autor = new Autor
    {
        Nombre = nombre
    };

    autorRepository.Agregar(autor);

    Console.WriteLine($"Autor registrado correctamente con ID {autor.Id}.");
}

void AltaLibro()
{
    Console.WriteLine("--- ALTA DE LIBRO ---");

    List<Autor> autores = autorRepository.ObtenerTodos();

    if (autores.Count == 0)
    {
        Console.WriteLine("Primero debe registrar al menos un autor.");
        return;
    }

    Console.WriteLine("Autores disponibles:");

    foreach (Autor autor in autores)
    {
        Console.WriteLine($"{autor.Id}. {autor.Nombre}");
    }

    Console.Write("Seleccione el ID del autor: ");

    if (!int.TryParse(Console.ReadLine(), out int autorId) ||
        autores.All(autor => autor.Id != autorId))
    {
        Console.WriteLine("El autor seleccionado no es válido.");
        return;
    }

    Console.Write("Título del libro: ");
    string? titulo = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(titulo))
    {
        Console.WriteLine("El título no puede estar vacío.");
        return;
    }

    Console.Write("Año de publicación: ");

    if (!int.TryParse(Console.ReadLine(), out int anioPublicacion) ||
        anioPublicacion <= 0)
    {
        Console.WriteLine("El año de publicación no es válido.");
        return;
    }

    var libro = new Libro
    {
        Titulo = titulo,
        AnioPublicacion = anioPublicacion,
        AutorId = autorId
    };

    libroRepository.Agregar(libro);

    Console.WriteLine($"Libro registrado correctamente con ID {libro.Id}.");
}

void VerLibros()
{
    Console.WriteLine("--- LIBROS REGISTRADOS ---");

    List<Libro> libros = libroRepository.ObtenerTodosConAutor();

    if (libros.Count == 0)
    {
        Console.WriteLine("Todavía no hay libros registrados.");
        return;
    }

    foreach (Libro libro in libros)
    {
        Console.WriteLine(
            $"ID: {libro.Id} | " +
            $"Título: {libro.Titulo} | " +
            $"Año: {libro.AnioPublicacion} | " +
            $"Autor: {libro.Autor.Nombre}"
        );
    }
}