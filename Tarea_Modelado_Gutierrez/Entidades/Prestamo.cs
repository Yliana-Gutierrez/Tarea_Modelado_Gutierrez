using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Modelado_Gutierrez.Entidades
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }
        public Libro? Libro { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
