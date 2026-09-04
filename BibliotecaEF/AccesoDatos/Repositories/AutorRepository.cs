using AccesoDatos.Data;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories;

public class AutorRepository
{
    public void Agregar(Autor autor)
    {
        using var context = new BibliotecaContext();

        context.Autores.Add(autor);
        context.SaveChanges();
    }

    public List<Autor> ObtenerTodos()
    {
        using var context = new BibliotecaContext();

        return context.Autores
            .AsNoTracking()
            .OrderBy(autor => autor.Nombre)
            .ToList();
    }

    public Autor? ObtenerPorId(int id)
    {
        using var context = new BibliotecaContext();

        return context.Autores
            .AsNoTracking()
            .FirstOrDefault(autor => autor.Id == id);
    }

    public bool ModificarNombre(int id, string nuevoNombre)
    {
        using var context = new BibliotecaContext();

        Autor? autor = context.Autores.Find(id);

        if (autor == null)
        {
            return false;
        }

        autor.Nombre = nuevoNombre;
        context.SaveChanges();

        return true;
    }
}