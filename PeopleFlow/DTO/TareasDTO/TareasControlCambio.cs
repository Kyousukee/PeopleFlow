using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class TareasControlCambio
    {
        public int IdCambioTarea { get; set; }
        public string Tarea { get; set; }
        public string Estado { get; set; }
        public string Pago { get; set; }
        public decimal Valor { get; set; }
        public int IdTarea { get; set; }
        public int IdTipoPago { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        
        public int IdEstadoTarea { get; set; }
        

    }
}
