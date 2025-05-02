using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Contrato
{
    public class TipoFiniquito
    {
        public int idTipoFiniquito { get; set; } 
        public int Articulo { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
