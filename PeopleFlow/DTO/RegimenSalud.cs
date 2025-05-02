using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class RegimenSalud
    {
        public int idRegimenSalud { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
