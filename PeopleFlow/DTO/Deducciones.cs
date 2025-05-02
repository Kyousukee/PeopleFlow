using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Deducciones
    {
        public int IdDeduccion { get; set; }
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public bool Estado { get; set; }
        public bool ParaEmpleado { get; set; }
        public List<EmpleadosContratos> Asignados { get; set; }
    }
}
