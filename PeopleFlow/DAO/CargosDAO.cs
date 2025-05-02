using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    
    public class CargosDAO
    {
        public PetaPoco.Database db;
        public CargosDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public List<DTO.Roles> GetCargos()
        {
            return db.Fetch<DTO.Roles>("CALL GetRoles(@0);",Sesion.UsuarioActual.IdEmpresa);
        }
    }
}
