using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.TareasDTO
{
    public class EmpleadoProductividad
    {
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public string Descripcion { get; set; }
        public int TotalCantidad { get; set; }
        public decimal TotalPago { get; set; }
    }
}
