using AccesoDatos.Data;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories;

public class CategoriaRepository
{
    public void Agregar(Categoria categoria)
    {
        using var context = new BibliotecaContext();

        context.Categorias.Add(categoria);
        context.SaveChanges();
    }

    public List<Categoria> ObtenerTodos()
    {
        using var context = new BibliotecaContext();

        return context.Categorias
            .AsNoTracking()
            .OrderBy(categoria => categoria.Nombre)
            .ToList();
    }
}