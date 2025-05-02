using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.TareasDTO
{
    public class TareasEmpleadoAsistencia
    {
        public int IdTareaAsistencia { get; set; }
        public int IdTarea { get; set; }
        public int IdEmpleado { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public DateTime FechaAsignacion { get; set; }
    }
}
