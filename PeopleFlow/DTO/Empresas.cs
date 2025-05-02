using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Empresas
    {
        public int IdEmpresa { get; set; }
        public string RUT { get; set; }
        public string Nombre { get; set; }
        public object Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Direccion { get; set; }
    }
}
