using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rut { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public int IdRol { get; set; }
        public string Cargo { get; set; }
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public int IdTareaEmpl { get; set; }
        public int Idtarea { get; set; }
        public string Nacionalidad { get; set; }
        public string Profesion { get; set; }
        public int IdEstadoCivil { get; set; }
        public string EstadoCivil { get; set; }
        public string Banco { get; set; }
        public string TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public int IdSalud { get; set; }
        public string Salud { get; set; }
        public int IdAfp { get; set; }
        public string AFP { get; set; }
        public string Contrato { get; set; }
        public string IdContrato { get; set; }
    }
}
