using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Vacaciones
    {
        public int idVacaciones { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime Fecha_Retorno { get; set; }
        public int CantDias { get; set; }
        public int SaldoTrabajador { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Usuario { get; set; }
        public int IdEmpresa { get; set; }
        

    }
}
