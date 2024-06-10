using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class LibroAutor
    {
        public int LibroId { get; set; }
        public int AutorId { get; set; }
        public Libro? Libro { get; set; }
        public Autor? Autor { get; set; }
    }
}
