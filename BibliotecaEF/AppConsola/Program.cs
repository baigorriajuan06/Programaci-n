using AccesoDatos.Data;
using AccesoDatos.Models;
using AccesoDatos.Repositories;
using Microsoft.EntityFrameworkCore;

using (var context = new BibliotecaContext())
{
    context.Database.Migrate();
}

var autorRepository = new AutorRepository();
var categoriaRepository = new CategoriaRepository();
var libroRepository = new LibroRepository();

bool continuar = true;

while (continuar)
{
    Console.WriteLine();
    Console.WriteLine("===== BIBLIOTECA =====");
    Console.WriteLine("1. Alta Autor");
    Console.WriteLine("2. Alta Categoría");
    Console.WriteLine("3. Alta Libro");
    Console.WriteLine("4. Ver Autores");
    Console.WriteLine("5. Ver Categorías");
    Console.WriteLine("6. Ver Libros");
    Console.WriteLine("7. Modificar Libro");
    Console.WriteLine("8. Eliminar Libro");
    Console.WriteLine("9. Modificar Autor");
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
            AltaCategoria();
            break;

        case "3":
            AltaLibro();
            break;

        case "4":
            VerAutores();
            break;

        case "5":
            VerCategorias();
            break;

        case "6":
            VerLibros();
            break;

        case "7":
            ModificarLibro();
            break;

        case "8":
            EliminarLibro();
            break;

        case "9":
            ModificarAutor();
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

void AltaCategoria()
{
    Console.WriteLine("--- ALTA DE CATEGORÍA ---");
    Console.Write("Nombre de la categoría: ");

    string? nombre = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(nombre))
    {
        Console.WriteLine("El nombre no puede estar vacío.");
        return;
    }

    var categoria = new Categoria
    {
        Nombre = nombre
    };

    categoriaRepository.Agregar(categoria);

    Console.WriteLine(
        $"Categoría registrada correctamente con ID {categoria.Id}."
    );
}

void AltaLibro()
{
    Console.WriteLine("--- ALTA DE LIBRO ---");

    List<Autor> autores = autorRepository.ObtenerTodos();
    List<Categoria> categorias = categoriaRepository.ObtenerTodos();

    if (autores.Count == 0)
    {
        Console.WriteLine("Primero debe registrar al menos un autor.");
        return;
    }

    if (categorias.Count == 0)
    {
        Console.WriteLine("Primero debe registrar al menos una categoría.");
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

    Console.WriteLine();
    Console.WriteLine("Categorías disponibles:");

    foreach (Categoria categoria in categorias)
    {
        Console.WriteLine($"{categoria.Id}. {categoria.Nombre}");
    }

    Console.Write("Seleccione el ID de la categoría: ");

    if (!int.TryParse(Console.ReadLine(), out int categoriaId) ||
        categorias.All(categoria => categoria.Id != categoriaId))
    {
        Console.WriteLine("La categoría seleccionada no es válida.");
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
        AutorId = autorId,
        CategoriaId = categoriaId,
        Activo = true
    };

    libroRepository.Agregar(libro);

    Console.WriteLine($"Libro registrado correctamente con ID {libro.Id}.");
}

void VerAutores()
{
    Console.WriteLine("--- AUTORES REGISTRADOS ---");

    List<Autor> autores = autorRepository.ObtenerTodos();

    if (autores.Count == 0)
    {
        Console.WriteLine("Todavía no hay autores registrados.");
        return;
    }

    foreach (Autor autor in autores)
    {
        Console.WriteLine($"ID: {autor.Id} | Nombre: {autor.Nombre}");
    }
}

void VerCategorias()
{
    Console.WriteLine("--- CATEGORÍAS REGISTRADAS ---");

    List<Categoria> categorias = categoriaRepository.ObtenerTodos();

    if (categorias.Count == 0)
    {
        Console.WriteLine("Todavía no hay categorías registradas.");
        return;
    }

    foreach (Categoria categoria in categorias)
    {
        Console.WriteLine(
            $"ID: {categoria.Id} | Nombre: {categoria.Nombre}"
        );
    }
}

void VerLibros()
{
    Console.WriteLine("--- LIBROS ACTIVOS ---");

    List<Libro> librosActivos = libroRepository
        .ObtenerTodosConRelaciones()
        .Where(libro => libro.Activo)
        .ToList();

    if (librosActivos.Count == 0)
    {
        Console.WriteLine("Todavía no hay libros activos.");
        return;
    }

    foreach (Libro libro in librosActivos)
    {
        Console.WriteLine(
            $"ID: {libro.Id} | " +
            $"Título: {libro.Titulo} | " +
            $"Año: {libro.AnioPublicacion} | " +
            $"Autor: {libro.Autor.Nombre} | " +
            $"Categoría: {libro.Categoria.Nombre}"
        );
    }
}

void ModificarLibro()
{
    Console.WriteLine("--- MODIFICAR LIBRO ---");

    List<Libro> librosActivos = libroRepository
        .ObtenerTodosConRelaciones()
        .Where(libro => libro.Activo)
        .ToList();

    if (librosActivos.Count == 0)
    {
        Console.WriteLine("No hay libros activos para modificar.");
        return;
    }

    foreach (Libro libro in librosActivos)
    {
        Console.WriteLine($"{libro.Id}. {libro.Titulo}");
    }

    Console.Write("Ingrese el ID del libro: ");

    if (!int.TryParse(Console.ReadLine(), out int libroId) ||
        librosActivos.All(libro => libro.Id != libroId))
    {
        Console.WriteLine("El libro seleccionado no es válido.");
        return;
    }

    Console.Write("Ingrese el nuevo título: ");
    string? nuevoTitulo = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(nuevoTitulo))
    {
        Console.WriteLine("El título no puede estar vacío.");
        return;
    }

    bool modificado = libroRepository.ModificarTitulo(
        libroId,
        nuevoTitulo
    );

    Console.WriteLine(
        modificado
            ? "Libro modificado correctamente."
            : "No se encontró el libro."
    );
}

void EliminarLibro()
{
    Console.WriteLine("--- ELIMINAR LIBRO ---");

    List<Libro> librosActivos = libroRepository
        .ObtenerTodosConRelaciones()
        .Where(libro => libro.Activo)
        .ToList();

    if (librosActivos.Count == 0)
    {
        Console.WriteLine("No hay libros activos para eliminar.");
        return;
    }

    foreach (Libro libro in librosActivos)
    {
        Console.WriteLine($"{libro.Id}. {libro.Titulo}");
    }

    Console.Write("Ingrese el ID del libro: ");

    if (!int.TryParse(Console.ReadLine(), out int libroId) ||
        librosActivos.All(libro => libro.Id != libroId))
    {
        Console.WriteLine("El libro seleccionado no es válido.");
        return;
    }

    Console.Write("¿Confirma la eliminación lógica? (S/N): ");
    string? confirmacion = Console.ReadLine();

    if (!string.Equals(
            confirmacion,
            "S",
            StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Operación cancelada.");
        return;
    }

    bool eliminado = libroRepository.EliminarLogicamente(libroId);

    Console.WriteLine(
        eliminado
            ? "Libro eliminado lógicamente."
            : "No se encontró el libro."
    );
}

void ModificarAutor()
{
    Console.WriteLine("--- MODIFICAR AUTOR ---");

    List<Autor> autores = autorRepository.ObtenerTodos();

    if (autores.Count == 0)
    {
        Console.WriteLine("No hay autores para modificar.");
        return;
    }

    foreach (Autor autor in autores)
    {
        Console.WriteLine($"{autor.Id}. {autor.Nombre}");
    }

    Console.Write("Ingrese el ID del autor: ");

    if (!int.TryParse(Console.ReadLine(), out int autorId) ||
        autores.All(autor => autor.Id != autorId))
    {
        Console.WriteLine("El autor seleccionado no es válido.");
        return;
    }

    Console.Write("Ingrese el nuevo nombre: ");
    string? nuevoNombre = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(nuevoNombre))
    {
        Console.WriteLine("El nombre no puede estar vacío.");
        return;
    }

    bool modificado = autorRepository.ModificarNombre(
        autorId,
        nuevoNombre
    );

    Console.WriteLine(
        modificado
            ? "Autor modificado correctamente."
            : "No se encontró el autor."
    );
}