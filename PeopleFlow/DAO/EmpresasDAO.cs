using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class EmpresasDAO
    {
        public PetaPoco.Database db;
        public EmpresasDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public List<DTO.Empresas> GetEmpresas()
        {
            return db.Fetch<DTO.Empresas>("CALL GetEmpresas;");
        }
        public DTO.Empresas GetEmpresasbyID(int id)
        {
            return db.FirstOrDefault<DTO.Empresas>("CALL GetEmpresasById(@0);",id);
        }

        public List<ArchivosEmpresa> GetArchivosEmpresa()
        {
            return db.Fetch<ArchivosEmpresa>("CALL GetArchivosEmpresas(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<FiniquitosEmpresa> GetFiniquitosEmpresa()
        {
            return db.Fetch<FiniquitosEmpresa>("CALL GetFiniquitos(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public void EliminarArchivo(int idArchivo)
        {
            try
            {
                db.Execute("CALL DeleteArchivosEmpresa(@0,@1);", idArchivo, Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ArchivosEmpresa RegistroArchivoEmpresa(ArchivosEmpresa datos)
        {
            ArchivosEmpresa response = new ArchivosEmpresa();
            try
            {
                response = db.FirstOrDefault<ArchivosEmpresa>("CALL RegistroArchivosEmpresa(@0, @1, @2, @3, @4,@5);",
                             datos.idArchivos,
                             datos.Titulo,
                             datos.Archivo,
                             Sesion.UsuarioActual.IdEmpresa,
                             Sesion.UsuarioActual.IdUsuario,
                             datos.ArchivoB);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }
    }
}
