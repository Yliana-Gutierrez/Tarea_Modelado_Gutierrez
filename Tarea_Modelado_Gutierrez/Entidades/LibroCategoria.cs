using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class LibroCategoria
    {
        public int LibroId { get; set; }
        public int CategoriaId { get; set; }
        public Libro? Libro { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
