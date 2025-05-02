using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.TareasDTO
{
    public class TareasEmpleados
    {
        public int IdTareaEmpl { get; set; }
        public int Idtarea { get; set; }
        public int IdEmpleador { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public string Usuario { get; set; }
        public string NombreCompleto { get; set; }  
    }
}
