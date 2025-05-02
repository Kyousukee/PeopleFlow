using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class FiniquitosEmpresa
    {
        public int idFiniquitos { get; set; }
        public int IdContrato { get; set; }
        public DateTime FechaFiniquito { get; set; }
        public int IdTipoFiniquito { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Usuario { get; set; }
        public int IdEmpresa { get; set; }
        public bool Estado { get; set; }

        // Propiedades relacionadas al contrato (duplicadas en tu lista)
        public int IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdPlazo { get; set; }
        public string NPlazo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string EstadoContrato { get; set; } // Renombrado para evitar conflicto con Estado del finiquito
        public int IdTarea { get; set; }

        // Propiedades del empleado
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string TipoContrato { get; set; } // Descripción del tipo de contrato
        public string Plazo { get; set; } // Descripción del plazo
        public string Tarea { get; set; } // Descripción de la tarea
    }
}
