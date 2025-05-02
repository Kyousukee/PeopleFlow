using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Contrato
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public int IdEmpleado { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdTipoContrato { get; set; }
        public string TipoContrato { get; set; }
        public int IdPlazo { get; set; }
        public string Plazo { get; set; }
        public int NPlazo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public int IdTarea { get; set; }
        public string Tarea { get; set; }
        public int IdEmpresa { get; set; }
        

    }
}
