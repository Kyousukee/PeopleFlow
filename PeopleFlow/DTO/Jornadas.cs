using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Jornadas
    {
        public int idJornadas { get; set; }
        public string Descripcion { get; set; }
        public string DiaComienzo { get; set; }
        public string DiaTermino { get; set; }
        public string HoraInSemana { get; set; }
        public string HoraOutSemana { get; set; }
        public string HoraInFinSemana { get; set; }
        public string HoraOutFinSemana { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public string Usuario { get; set; }
        public string DescripcionDiaComienzo { get; set; }
        public int HorasSemanales { get; set; }
    }
}
