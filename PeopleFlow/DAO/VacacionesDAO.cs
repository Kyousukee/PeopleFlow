using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PeopleFlow.DTO;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class VacacionesDAO
    {
        public PetaPoco.Database db;
        public VacacionesDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public Vacaciones registroVacaciones(Vacaciones datos)
        {
            Vacaciones response = new Vacaciones();
            try
            {
                response = db.FirstOrDefault<Vacaciones>("CALL RegistroVacaciones(@0, @1, @2, @3, @4, @5, @6, @7,@8);",
                             datos.idVacaciones,
                             datos.IdEmpleado,
                             datos.FechaIni,
                             datos.FechaFin,
                             datos.CantDias,
                             datos.SaldoTrabajador,
                             Sesion.UsuarioActual.IdUsuario,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.Fecha_Retorno);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public List<Vacaciones> GetVacacionesEmpresa()
        {
            return db.Fetch<Vacaciones>("CALL GetVacacionesByEmpresa(@0);", Sesion.UsuarioActual.IdEmpresa);
        }


        public Vacaciones GetVacacionesByID(int IDVacacion)
        {
            return db.FirstOrDefault<Vacaciones>("CALL GetVacacionesByID(@0);", IDVacacion);
        }

        public Vacaciones GetVacacionesByIDUltima(int IDEmpleado)
        {
            return db.FirstOrDefault<Vacaciones>("CALL GetUltimaVacacion(@0);", IDEmpleado);
        }

        public DocumentosPlantilla GetVacacionesPlanilla()
        {
            return db.FirstOrDefault<DocumentosPlantilla>("CALL GetVacacionesPlanilla(@0);", 0);
        }

        public SaldoVacacionesResult GetSaldoVacaciones(int idEmpleado)
        {
            SaldoVacacionesResult saldoVacacionesResult = new SaldoVacacionesResult();
            try
            {
                saldoVacacionesResult=db.FirstOrDefault<SaldoVacacionesResult>("CALL ObtenerSaldoVacacionesChile(@0);", idEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saldoVacacionesResult;
        }

        public void EliminarVacaciones(int IDVacaciones)
        {
            db.Execute("CALL EliminarVacaciones(@0);", IDVacaciones);
        }
    }
}
