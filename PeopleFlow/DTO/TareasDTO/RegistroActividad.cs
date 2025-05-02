using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.TareasDTO
{
    public class RegistroActividad
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Cantidad { get; set; }
        public decimal PagoIndividual { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Total { get; set; }
        public int IdTarea { get; set; }
        public string Horario { get; set; }
    }
}
