using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class EmpleadosDAO
    {
        public PetaPoco.Database db;
        public EmpleadosDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public List<Empleados> GetEmpleados()
        {
            return db.Fetch<Empleados>("CALL GetEmpleados(@0);",Sesion.UsuarioActual.IdEmpresa);
        }

        public List<Empleados> GetEmpleadosContratos()
        {
            return db.Fetch<Empleados>("CALL GetEmpleadosContratos(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<Empleados> GetEmpleadosContratosActivos()
        {
            return db.Fetch<Empleados>("CALL GetEmpleadosContratosActivos(@0);", Sesion.UsuarioActual.IdEmpresa);
        }
        public List<Empleados> GetEmpleadosAll()
        {
            return db.Fetch<Empleados>("CALL GetEmpleadosALL(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public AsignacionFamiliar GetAsignacionFamiliar(int idEmpleado)
        {
            return db.FirstOrDefault<AsignacionFamiliar>("CALL GetCargasByTrabajador(@0);", idEmpleado);
        }

        public List<ValoresCargas> GetValoresCargas()
        {
            return db.Fetch<ValoresCargas>("CALL GetValoresCargas;");
        }

        public void deleteAsignacionFamiliar(int idEmpleado)
        {
            db.Execute("CALL DeleteCargasByTrabajador(@0);", idEmpleado);
        }

        public AsignacionFamiliar saveAsignacionFamiliar(AsignacionFamiliar datos)
        {
            AsignacionFamiliar response = new AsignacionFamiliar();
            try
            {
                response = db.FirstOrDefault<AsignacionFamiliar>("CALL RegistroAsignacionFamiliar(@0, @1, @2, @3, @4);",
                             datos.idCargasEmpleados,
                             datos.IdEmpleado,
                             datos.NCargasHijos,
                             datos.NCargasConguye,
                             datos.NCargasInvalidez,
                             Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }



        public List<RegimenSalud> GetSaludEmpleados()
        {
            return db.Fetch<RegimenSalud>("CALL GetSaludEmpleados(@0);",Sesion.UsuarioActual.IdEmpresa);
        }

        public List<TipoAfp> GetAfpEmpleados()
        {
            return db.Fetch<TipoAfp>("CALL Getafp;");
        }

        public List<EstadoCivil> GetEstadoCivil()
        {
            return db.Fetch<EstadoCivil>("CALL GetEstadoCivil;");
        }


        public Empleados GetEmpleadosRut(string rut)
        {
            return db.FirstOrDefault<Empleados>("CALL GetEmpleadosRut(@0,@1);", rut,Sesion.UsuarioActual.IdEmpresa);
        }

        public Empleados GetEmpleadosByID(int IdEmpleado)
        {
            return db.FirstOrDefault<Empleados>("CALL GetEmpleadosByID(@0,@1);", IdEmpleado, Sesion.UsuarioActual.IdEmpresa);
        }

        public Empleados registroEmpleado(Empleados datos)
        {
            Empleados response = new Empleados();
            try
            {
                response = db.FirstOrDefault<Empleados>("CALL RegistroTrabajador(@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11,@12,@13,@14,@15,@16,@17,@18,@19);",
                             datos.IdEmpleado, 
                             datos.Nombre, 
                             datos.Apellido, 
                             datos.Rut, 
                             datos.FechaNacimiento.Date, 
                             datos.Telefono, datos.Correo, 
                             datos.Direccion, 
                             datos.FechaIngreso, 
                             datos.Estado, 
                             datos.IdRol, 
                             datos.IdEmpresa,
                             datos.IdEstadoCivil,
                             datos.Nacionalidad,
                             datos.Profesion,
                             datos.Banco,
                             datos.TipoCuenta,
                             datos.NumeroCuenta,
                             datos.IdSalud,
                             datos.IdAfp,
                             Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

    }
}
