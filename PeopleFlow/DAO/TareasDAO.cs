using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Tareas.Tareas;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class TareasDAO
    {
        public PetaPoco.Database db;
        public TareasDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public List<Tareas> GetTareas()
        {
            return db.Fetch<Tareas>("CALL GetTareas(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public Tareas GetTareasByID(int ID)
        {
            return db.FirstOrDefault<Tareas>("CALL GetTareasByID(@0);", ID);
        }

        public List<Tareas> GetTareasALL()
        {
            return db.Fetch<Tareas>("CALL GetTareasALL(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<TareasEmpleadoAsistencia> GetAsistenciasNoPagadas(int IdEmpleado, int mes)
        {
            return db.Fetch<TareasEmpleadoAsistencia>("CALL GetAsistenciasNoPagada(@0,@1);", IdEmpleado,mes);
        }
        public List<TareasEmpleadosRegistros> GetTareasNoPagadas(int IdEmpleado, int mes)
        {
            return db.Fetch<TareasEmpleadosRegistros>("CALL GetTareasNoPagada(@0,@1);", IdEmpleado, mes);
        }

        public List<Jornadas> GetJornadas()
        {
            return db.Fetch<Jornadas>("CALL GetJornadas(@0);", Sesion.UsuarioActual.IdEmpresa);
        }
        public Jornadas GetJornadasID(int idJornada)
        {
            return db.FirstOrDefault<Jornadas>("CALL GetJornadasID(@0);", idJornada);
        }

        public List<TareasConEmpleados> GetTareasConEmpleados()
        {
            return db.Fetch<TareasConEmpleados>("CALL GetTareasConEmpleados(@0);", Sesion.UsuarioActual.IdEmpresa);
        }



        public List<EstadoTarea> GetEstadosTareas()
        {
            return db.Fetch<EstadoTarea>("CALL GetTareasEstados;");
        }

        public List<TareasControlCambio> GetControlTareas(int idTarea)
        {
            return db.Fetch<TareasControlCambio>("CALL GetControlCambiosTareas(@0);", idTarea);
        }

        public List<TareasEmpleados> GetEmpleadosTareas(int idTarea)
        {
            return db.Fetch<TareasEmpleados>("CALL GetEmpleadosTareas(@0);", idTarea);
        }

        public List<RegistroActividad> GetRegistroActividades(int idTarea, DateTime fini, DateTime fter, int idEmpleado)
        {
            return db.Fetch<RegistroActividad>("CALL GetRegistroActividades(@0,@1,@2,@3,@4);", Sesion.UsuarioActual.IdEmpresa, fini, fter, idTarea, idEmpleado);
        }

        public List<Empleados> GetEmpleadosNoTareas(int idTarea)
        {
            return db.Fetch<Empleados>("CALL GetEmpleadosnoTareas(@0,@1);", idTarea, Sesion.UsuarioActual.IdEmpresa);
        }

        public List<EmpleadoProductividad> GetProductividadPorEmpleado()
        {
            return db.Fetch<EmpleadoProductividad>("CALL GetProductividadPorEmpleado(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<AsistenciaSemanalEmpleados> asistenciaSemanalEmpleados()
        {
            return db.Fetch<AsistenciaSemanalEmpleados>("CALL GetHorasTrabajadasVsEsperadas_Semanal(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<TasaAusentismoSemanal> GetTasaAusentismoSemanal()
        {
            return db.Fetch<TasaAusentismoSemanal>("CALL GetTasaAusentismoSemanal(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<DistribucionCostosLaborales> DistribucionCostosLaboralesUltimoMes()
        {
            return db.Fetch<DistribucionCostosLaborales>("CALL sp_DistribucionCostosLaboralesUltimoMes(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<DistribucionSueldosBonos> DistribucionSueldosBonos()
        {
            return db.Fetch<DistribucionSueldosBonos>("CALL sp_ComparacionSueldosBonos(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<ProductividadMensual> GetProductividadPorMes()
        {
            return db.Fetch<ProductividadMensual>("CALL GetProductividadPorMes(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<TipoPago> GetTipoPago()
        {
            return db.Fetch<TipoPago>("CALL GetTipoPago;");
        }

        public Tareas registroTarea(Tareas datos)
        {
            Tareas response = new Tareas();
            try
            {
                response = db.FirstOrDefault<Tareas>("CALL RegistroTarea(@0, @1, @2, @3, @4, @5, @6, @7,@8,@9,@10);",
                             datos.IdTarea,
                             datos.Descripcion,
                             datos.FechaAsignacion.Date,
                             datos.FechaFinalizacion.Date,
                             datos.IdEstadoTarea,
                             datos.IdTipoPago,
                             datos.Valor,
                             datos.Titulo,
                             datos.IdJornada,
                             Sesion.UsuarioActual.IdEmpresa, Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public Jornadas registroJornada(Jornadas datos)
        {
            Jornadas response = new Jornadas();
            try
            {
                response = db.FirstOrDefault<Jornadas>("CALL RegistroJornadas(@0, @1, @2, @3, @4, @5, @6, @7,@8,@9,@10);",
                             datos.idJornadas,
                             datos.Descripcion,
                             datos.DiaComienzo,
                             datos.DiaTermino,
                             datos.HoraInSemana,
                             datos.HoraOutSemana,
                             datos.HoraInFinSemana,
                             datos.HoraOutFinSemana,
                             datos.HorasSemanales,
                             Sesion.UsuarioActual.IdUsuario,
                             Sesion.UsuarioActual.IdEmpresa);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public TareasEmpleadosRegistros GetTareaRegistro(int idTarea,int IdEmpleado,DateTime FechaAsignacion)
        {
            return db.FirstOrDefault<TareasEmpleadosRegistros>("CALL GetTareaRegistro(@0,@1,@2);", idTarea, FechaAsignacion.Date,IdEmpleado);
        }

        public TareasEmpleadoAsistencia GetTareaAsistencia(int idTarea, int IdEmpleado, DateTime FechaAsignacion)
        {
            return db.FirstOrDefault<TareasEmpleadoAsistencia>("CALL GetTareaAsistencia(@0,@1,@2);", idTarea, FechaAsignacion.Date, IdEmpleado);
        }

        public TareasEmpleadosRegistros registroTareaRegistros(TareasEmpleadosRegistros datos)
        {
            TareasEmpleadosRegistros response = new TareasEmpleadosRegistros();
            try
            {

                if (datos.IdEmpleado == 0) {
                    List<TareasEmpleados> empleados = new List<TareasEmpleados>();
                    empleados = GetEmpleadosTareas(datos.IdTarea);

                    foreach (TareasEmpleados item in empleados)
                    {
                        response = db.FirstOrDefault<TareasEmpleadosRegistros>("CALL RegistroTareaRegistro(@0, @1, @2, @3, @4, @5,@06);",
                             datos.IdTareaEmpleado,
                             datos.IdTarea,
                             datos.FechaAsignacion.Date,
                             item.IdEmpleador,
                             datos.Cantidad,
                             datos.PagoIndividual, Sesion.UsuarioActual.IdUsuario);
                    }
                }
                else
                {
                    response = db.FirstOrDefault<TareasEmpleadosRegistros>("CALL RegistroTareaRegistro(@0, @1, @2, @3, @4, @5,@06);",
                             datos.IdTareaEmpleado,
                             datos.IdTarea,
                             datos.FechaAsignacion.Date,
                             datos.IdEmpleado,
                             datos.Cantidad,
                             datos.PagoIndividual, Sesion.UsuarioActual.IdUsuario);
                }

                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public TareasEmpleadoAsistencia registroTareaAsistencia(TareasEmpleadoAsistencia datos)
        {
            TareasEmpleadoAsistencia response = new TareasEmpleadoAsistencia();
            try
            {

                if (datos.IdEmpleado == 0)
                {
                    List<TareasEmpleados> empleados = new List<TareasEmpleados>();
                    empleados = GetEmpleadosTareas(datos.IdTarea);

                    foreach (TareasEmpleados item in empleados)
                    {
                        response = db.FirstOrDefault<TareasEmpleadoAsistencia>("CALL RegistroTareaAsistencia(@0, @1, @2, @3, @4, @5,@6);",
                             datos.IdTareaAsistencia,
                             datos.IdTarea,
                             datos.FechaAsignacion.Date,
                             item.IdEmpleador,
                             datos.HoraInicio,
                             datos.HoraTermino,Sesion.UsuarioActual.IdUsuario);
                    }
                }
                else
                {
                    response = db.FirstOrDefault<TareasEmpleadoAsistencia>("CALL RegistroTareaAsistencia(@0, @1, @2, @3, @4, @5,@6);",
                             datos.IdTareaAsistencia,
                             datos.IdTarea,
                             datos.FechaAsignacion.Date,
                             datos.IdEmpleado,
                             datos.HoraInicio,
                             datos.HoraTermino, Sesion.UsuarioActual.IdUsuario);
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public void registroAsignacionTarea(TareasEmpleados datos)
        {
            try
            {

                DateTime fechFin = datos.FechaFin;
                db.Execute("CALL RegistroAsignacionTarea(@0, @1, @2, @3, @4, @5);",
                             datos.IdTareaEmpl,
                             datos.Idtarea,
                             datos.IdEmpleador,
                             datos.FechaIni,
                             datos.FechaFin,
                             datos.Usuario,
                             Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
