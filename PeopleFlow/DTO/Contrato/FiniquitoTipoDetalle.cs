using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Contrato
{
    public class FiniquitoTipoDetalle
    {
        public int idFiniquitosTipoDetalle { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCrea { get; set; }
    }
}
