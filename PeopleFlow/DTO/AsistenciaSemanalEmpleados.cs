using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class AsistenciaSemanalEmpleados
    {
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; } 
        public string Semana { get; set; }
        public int HorasEsperadas { get; set; }
        public int HorasTrabajadas { get; set; }
    }
}
