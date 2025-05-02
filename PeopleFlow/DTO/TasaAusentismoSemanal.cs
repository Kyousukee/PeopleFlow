using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class TasaAusentismoSemanal
    {
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public string Semana { get; set; }
        public string Jornada { get; set; }
        public int DiasEsperados { get; set; }
        public int DiasAsistidos { get; set; }
        public double TasaAusentismo { get; set; }
    }
}
