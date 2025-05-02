using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO.Contrato
{
    public class AnexoContrato
    {
        public int idAnexoContrato { get; set; }
        public int IdContrato { get; set; }
        public string Titulo { get; set; }
        public string Archivo { get; set; }
        public byte[] ArchivoB { get; set; }
        public DateTime FechaReg { get; set; }
        public int Usuario { get; set; }
        public int IdEmpresa { get; set; }
    }
}
