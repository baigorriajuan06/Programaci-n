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

    public List<Libro> ObtenerTodosConRelaciones()
    {
        using var context = new BibliotecaContext();

        return context.Set<Libro>()
            .AsNoTracking()
            .Include(libro => libro.Autor)
            .Include(libro => libro.Categoria)
            .OrderBy(libro => libro.Titulo)
            .ToList();
    }

    public bool ModificarTitulo(int id, string nuevoTitulo)
    {
        using var context = new BibliotecaContext();

        Libro? libro = context.Libros
            .FirstOrDefault(libro => libro.Id == id && libro.Activo);

        if (libro == null)
        {
            return false;
        }

        libro.Titulo = nuevoTitulo;
        context.SaveChanges();

        return true;
    }

    public bool EliminarLogicamente(int id)
    {
        using var context = new BibliotecaContext();

        Libro? libro = context.Libros
            .FirstOrDefault(libro => libro.Id == id && libro.Activo);

        if (libro == null)
        {
            return false;
        }

        libro.Activo = false;
        context.SaveChanges();

        return true;
    }
}