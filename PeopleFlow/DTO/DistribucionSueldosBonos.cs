using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class DistribucionSueldosBonos
    {
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public decimal SueldoBase { get; set; }
        public decimal Bonos { get; set; }
    }

}
