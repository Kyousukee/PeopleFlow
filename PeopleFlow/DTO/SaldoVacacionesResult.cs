using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class SaldoVacacionesResult
    {
        public int SaldoVacaciones { get; set; }
        public int DiasLegales { get; set; }
        public int DiasProgresivos { get; set; }
        public int DiasTomados { get; set; }
        public string ErrorMessage { get; set; }
        public bool HasError => !string.IsNullOrEmpty(ErrorMessage);
    }
}
