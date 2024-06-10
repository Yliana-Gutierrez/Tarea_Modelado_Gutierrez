using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string? Titulo { get; set; }
        public int AñoPublicacion { get; set; }
        public string? ISBN { get; set; }
        public int EjemplaresDisponibles { get; set; }
        public ICollection<LibroAutor>? Autores { get; set; }
        public ICollection<LibroCategoria>? Categorias { get; set; }
        public ICollection<Prestamo>? Prestamos { get; set; }
    }
}
