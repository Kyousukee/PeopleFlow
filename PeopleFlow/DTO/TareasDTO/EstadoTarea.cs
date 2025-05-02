using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Tareas.Tareas
{
    public class EstadoTarea
    {
        public int IdEstadoTarea { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
    }
}
