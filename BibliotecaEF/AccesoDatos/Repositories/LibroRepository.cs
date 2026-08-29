using AccesoDatos.Data;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories;

public class LibroRepository
{
    public void Agregar(Libro libro)
    {
        using var context = new BibliotecaContext();

        context.Libros.Add(libro);
        context.SaveChanges();
    }

    public List<Libro> ObtenerTodosConAutor()
    {
        using var context = new BibliotecaContext();

        return context.Libros
            .Include(libro => libro.Autor)
            .OrderBy(libro => libro.Titulo)
            .ToList();
    }
}