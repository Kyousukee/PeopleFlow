using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Bonificaciones
    {
        public int IdBonificacion { get; set; }
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public bool Estado { get; set; }
        public bool ParaEmpleado { get; set; }
        public List<EmpleadosContratos> Asignados { get; set; }
        public int IdTarea { get; set; }
        public string Tarea { get; set; }
        public bool Imponible { get; set; }
    }
}
