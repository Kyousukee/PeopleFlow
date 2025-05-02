using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.TareasDTO
{
    public class Tareas
    {
        public int IdTarea { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public int IdEstadoTarea { get; set; }
        public int IdTipoPago { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Pago { get; set; }
        public string Estado { get; set; }
        public int IdJornada { get; set; }
        public string Jornada { get; set; }

    }
}
