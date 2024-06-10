using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string? Nombre { get; set; }
        public string? Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<LibroAutor>? Libros { get; set; }
    }
}
