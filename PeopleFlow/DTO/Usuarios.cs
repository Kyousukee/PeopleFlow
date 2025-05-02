using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DTO
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdRol {get;set;}
        public int IdEmpresa {get;set;}
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Rut { get; set; }
        public string Correo { get; set; }

    }
}
