using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Liquidacion
    {
        public int IdLiquidacion { get; set; }
        public int IdEmpleado { get; set; }
        public string Periodo { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal Deducciones { get; set; }
        public decimal SueldoLiquido { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdContrato { get; set; }
        public string year {get;set;}
        public string month { get; set; }
        public string DescripcionBonos { get; set; }
        public string DescripcionDeducciones { get; set; }
        public string NombreEmpleado { get; set; }
    }
}
