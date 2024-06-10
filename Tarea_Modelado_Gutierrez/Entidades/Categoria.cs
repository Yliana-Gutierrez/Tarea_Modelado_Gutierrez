using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Descripcion { get; set; } 
        public ICollection<LibroCategoria>? Libros { get; set; }
    }
}
