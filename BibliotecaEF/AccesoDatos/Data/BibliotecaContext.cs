using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Data;

public class BibliotecaContext : DbContext
{
    public DbSet<Autor> Autores { get; set; } = null!;

    public DbSet<Libro> Libros { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=biblioteca.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>()
            .ToTable("Autor");

        modelBuilder.Entity<Libro>()
            .ToTable("Libro");

        modelBuilder.Entity<Libro>()
            .HasOne(libro => libro.Autor)
            .WithMany(autor => autor.Libros)
            .HasForeignKey(libro => libro.AutorId);
    }
}