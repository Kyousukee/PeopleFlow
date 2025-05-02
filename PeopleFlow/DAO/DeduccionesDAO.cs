using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class DeduccionesDAO
    {
        public PetaPoco.Database db;
        public DeduccionesDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public Deducciones registroDeducciones(Deducciones datos)
        {
            Deducciones response = new Deducciones();
            List<EmpleadosContratos> Asignados = new List<EmpleadosContratos>();
            try
            {
                Asignados = datos.Asignados;
                response = db.FirstOrDefault<Deducciones>("CALL RegistroDeducciones(@0, @1, @2, @3, @4, @5,@6);",
                             datos.IdDeduccion,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.Descripcion,
                             datos.Monto,
                             datos.FechaAplicacion,
                             datos.Estado,
                             datos.ParaEmpleado,
                             Sesion.UsuarioActual.IdUsuario
                             );

                if (Asignados != null)
                {
                    if (Asignados.Count > 0)
                    {
                        response.Asignados = new List<EmpleadosContratos>();
                        foreach (EmpleadosContratos item in Asignados)
                        {
                            response.Asignados = db.Fetch<EmpleadosContratos>("CALL RegistroDeduccionesEmpleados(@0, @1, @2, @3, @4);",
                                 0,
                                 response.IdDeduccion,
                                 item.Id,
                                 Sesion.UsuarioActual.NombreUsuario,
                                 datos.Estado,
                                 Sesion.UsuarioActual.IdUsuario
                                 );
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Deducciones> GetDeducciones()
        {
            return db.Fetch<Deducciones>("CALL GetDeduccionByEmpresa(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<EmpleadosContratos> GetDeduccionesEmpleados(int Id_Empleado)
        {
            return db.Fetch<EmpleadosContratos>("CALL GetDeduccionEmpleados(@0);", Id_Empleado);
        }

        public List<Deducciones> GetDeduccionesEmpresaEmpleado(int IdEmpleado)
        {
            return db.Fetch<Deducciones>("CALL GetDeduccionesEmpleado(@0,@1);", IdEmpleado, Sesion.UsuarioActual.IdEmpresa);
        }
    }
}
