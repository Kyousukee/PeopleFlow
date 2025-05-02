using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.TareasDTO
{
    public class TareasEmpleadosRegistros
    {
        public int IdTareaEmpleado { get; set; }
        public int IdTarea { get; set; }
        public int IdEmpleado { get; set; }
        public int Cantidad { get; set; }
        public decimal PagoIndividual { get; set; }
        public DateTime FechaAsignacion { get; set; }
    }
}
