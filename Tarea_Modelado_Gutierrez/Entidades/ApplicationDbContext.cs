using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Biblioteca;Username=postgres;Password=061022;");

        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<LibroAutor> LibroAutores { get; set; }
        public DbSet<LibroCategoria> LibroCategorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Claves compuestas para LibroAutor
            modelBuilder.Entity<LibroAutor>()
                .HasKey(la => new { la.LibroId, la.AutorId });

            modelBuilder.Entity<LibroAutor>()
                .HasOne(la => la.Libro)
                .WithMany(l => l.Autores)
                .HasForeignKey(la => la.LibroId);

            modelBuilder.Entity<LibroAutor>()
                .HasOne(la => la.Autor)
                .WithMany(a => a.Libros)
                .HasForeignKey(la => la.AutorId);

            // Claves compuestas para LibroCategoria
            modelBuilder.Entity<LibroCategoria>()
                .HasKey(lc => new { lc.LibroId, lc.CategoriaId });

            modelBuilder.Entity<LibroCategoria>()
                .HasOne(lc => lc.Libro)
                .WithMany(l => l.Categorias)
                .HasForeignKey(lc => lc.LibroId);

            modelBuilder.Entity<LibroCategoria>()
                .HasOne(lc => lc.Categoria)
                .WithMany(c => c.Libros)
                .HasForeignKey(lc => lc.CategoriaId);
        }
    }
}
