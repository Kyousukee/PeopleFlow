using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Contrato
{
    public class Finiquito
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
        public List<DetalleFiniquito> detalleFiniquitos { get; set; }
    }
}
