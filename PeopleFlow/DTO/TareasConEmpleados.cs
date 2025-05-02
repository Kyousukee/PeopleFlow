using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class TareasConEmpleados
    {
        public int IdTarea { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public int IdEstadoTarea { get; set; }
        public int IdTipoPago { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Titulo { get; set; } 
        public int IdJornada { get; set; } 
        public int IdEmpresa { get; set; } 
        public string Pago { get; set; } 
        public string Estado { get; set; } 
        public int TotalEmpleados { get; set; } 
        public int TareasRegistradasHoy { get; set; } 
        public int TareasFaltantes { get; set; }
        public string EstadoDia { get; set; }
        public string Texto { get; set; }
        public string Texto2 { get; set; }
    }
}
