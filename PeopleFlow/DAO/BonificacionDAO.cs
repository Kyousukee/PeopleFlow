using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class BonificacionDAO
    {
        public PetaPoco.Database db;
        public BonificacionDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public Bonificaciones registroBonificaciones(Bonificaciones datos)
        {
            Bonificaciones response = new Bonificaciones();
            List<EmpleadosContratos> Asignados = new List<EmpleadosContratos>();
            try
            {
                Asignados = datos.Asignados;
                response = db.FirstOrDefault<Bonificaciones>("CALL RegistroBonificaciones(@0, @1, @2, @3, @4, @5,@6,@7,@8,@9);",
                             datos.IdBonificacion,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.Descripcion,
                             datos.Monto,
                             datos.FechaAplicacion,
                             datos.Estado,
                             datos.ParaEmpleado,
                             datos.IdTarea,
                             datos.Imponible,
                             Sesion.UsuarioActual.IdUsuario
                             );

                if (Asignados!=null)
                {
                    if (Asignados.Count > 0)
                    {
                        response.Asignados = new List<EmpleadosContratos>();
                        foreach (EmpleadosContratos item in Asignados)
                        {
                            response.Asignados = db.Fetch<EmpleadosContratos>("CALL RegistroBonificacionesEmpelados(@0, @1, @2, @3, @4);",
                                 0,
                                 response.IdBonificacion,
                                 item.Id,
                                 Sesion.UsuarioActual.NombreUsuario,
                                 datos.Estado,
                                 Sesion.UsuarioActual.IdUsuario
                                 );
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public List<Bonificaciones> GetBonificaciones()
        {
            return db.Fetch<Bonificaciones>("CALL GetBonificacionByEmpresa(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<EmpleadosContratos> GetBonificacionesEmpleados(int Id_Empleado)
        {
            return db.Fetch<EmpleadosContratos>("CALL GetBonificacionEmpleados(@0);", Id_Empleado);
        }
    }
}
