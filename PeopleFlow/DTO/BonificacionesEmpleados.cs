using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class BonificacionesEmpleados
    {
        public int idBonificacionesEmpleados { get; set; }
        public int IdBonificacion { get; set; }
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public bool Estado { get; set; }
        public DateTime Fec_Crea { get; set; }
    }
}
