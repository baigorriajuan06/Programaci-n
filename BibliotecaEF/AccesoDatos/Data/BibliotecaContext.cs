using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Data;

public class BibliotecaContext : DbContext
{
    public DbSet<Autor> Autores { get; set; } = null!;

    public DbSet<Categoria> Categorias { get; set; } = null!;

    public DbSet<Libro> Libros { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string carpetaSolucion = ObtenerCarpetaSolucion();
        string rutaBaseDatos = Path.Combine(carpetaSolucion, "biblioteca.db");

        optionsBuilder.UseSqlite($"Data Source={rutaBaseDatos}");
    }

    private static string ObtenerCarpetaSolucion()
    {
        DirectoryInfo? carpeta = new DirectoryInfo(AppContext.BaseDirectory);

        while (carpeta != null &&
               !File.Exists(Path.Combine(carpeta.FullName, "Biblioteca.slnx")))
        {
            carpeta = carpeta.Parent;
        }

        return carpeta?.FullName ?? Directory.GetCurrentDirectory();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>()
            .ToTable("Autor");

        modelBuilder.Entity<Categoria>()
            .ToTable("Categoria");

        modelBuilder.Entity<Libro>()
            .ToTable("Libro");

        modelBuilder.Entity<Libro>()
            .Property(libro => libro.Activo)
            .HasDefaultValue(true);

        modelBuilder.Entity<Libro>()
            .HasOne(libro => libro.Autor)
            .WithMany(autor => autor.Libros)
            .HasForeignKey(libro => libro.AutorId);

        modelBuilder.Entity<Libro>()
            .HasOne(libro => libro.Categoria)
            .WithMany(categoria => categoria.Libros)
            .HasForeignKey(libro => libro.CategoriaId);
    }
}