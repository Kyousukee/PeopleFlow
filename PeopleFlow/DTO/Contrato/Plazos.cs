using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Contrato
{
    public class Plazos
    {
        public int IdPlazo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_creacion { get; set; }
    }
}
