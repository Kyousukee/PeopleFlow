using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class UsuariosDAO
    {
        public PetaPoco.Database db;
        public UsuariosDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public List<DTO.Usuarios> GetUsuarios()
        {
            return db.Fetch<DTO.Usuarios>("SELECT * FROM Usuarios");
        }

        public DTO.Usuarios login(string user,int idEmpresa)
        {
            return db.FirstOrDefault<DTO.Usuarios>("CALL Login(@0, @1)", user,idEmpresa);
        }

        public List<DTO.Usuarios> GetUsuariosByEmpresa()
        {
            return db.Fetch<DTO.Usuarios>("CALL GetUsuariosByEmpresa(@0)",Sesion.UsuarioActual.IdEmpresa);
        }

        public void ResetPassword(int idUsuario,string contraseña)
        {
            db.Execute("CALL ResetPassUsuarios(@0,@1)", idUsuario,contraseña);
        }

        public DTO.Usuarios registroUsuario(DTO.Usuarios datos)
        {
            DTO.Usuarios response = new DTO.Usuarios();
            try
            {
                response = db.FirstOrDefault<DTO.Usuarios>("CALL RegistroUsuarios(@0, @1, @2, @3, @4, @5, @6, @7,@8,@9);",
                             datos.IdUsuario,
                             datos.NombreUsuario,
                             datos.Contraseña,
                             datos.IdRol,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.Estado,
                             datos.Nombres,
                             datos.Apellidos,
                             datos.Rut,
                             datos.Correo, Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public DTO.Roles registroCargo(DTO.Roles datos)
        {
            DTO.Roles response = new DTO.Roles();
            try
            {
                response = db.FirstOrDefault<DTO.Roles>("CALL RegistroCargos(@0, @1, @2, @3);",
                             datos.IdRol,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.Descripcion,
                             datos.Estado,
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
