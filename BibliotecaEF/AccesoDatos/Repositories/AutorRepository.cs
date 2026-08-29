using AccesoDatos.Data;
using AccesoDatos.Models;

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
            .OrderBy(autor => autor.Nombre)
            .ToList();
    }

    public Autor? ObtenerPorId(int id)
    {
        using var context = new BibliotecaContext();

        return context.Autores.Find(id);
    }
}