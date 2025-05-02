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
    public class LiquidacionesDAO
    {
        public PetaPoco.Database db;
        public LiquidacionesDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public Liquidacion registroLiquidacion(Liquidacion datos)
        {
            Liquidacion response = new Liquidacion();
            try
            {
                response = db.FirstOrDefault<Liquidacion>("CALL RegistroLiquidacion(@0, @1, @2, @3, @4, @5, @6, @7,@8,@9,@10,@11,@12);",
                             datos.IdLiquidacion,
                             datos.IdEmpleado,
                             datos.Periodo,
                             datos.SalarioBase,
                             datos.Bonificaciones,
                             datos.Deducciones,
                             datos.SueldoLiquido,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.IdContrato,
                             datos.year,
                             datos.month,
                             datos.DescripcionBonos,
                             datos.DescripcionDeducciones,
                             Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public List<Liquidacion> GetLiquidacionesEmpresa()
        {
            return db.Fetch<Liquidacion>("CALL GetLiquidacionesByEmpresa(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<Liquidacion> GetLiquidacionesByContrato(int idContrato)
        {
            return db.Fetch<Liquidacion>("CALL GetUltima3Liquidaciones(@0);", idContrato);
        }

        public Liquidacion getLiquidacionPeriodo(string periodo, int idempleado)
        {
            return db.FirstOrDefault<Liquidacion>("CALL GetLiquidacionByPeriodo(@0,@1);", periodo, idempleado);
        }

        public Afp GetAFPById(int IdAfp)
        {
            return db.FirstOrDefault<Afp>("CALL GetAFPById(@0);", IdAfp);
        }

        public List<Afp> GetAFPAll()
        {
            return db.Fetch<Afp>("CALL Getafp();");
        }

        public DocumentosPlantilla GetLiquidacionPlanilla()
        {
            return db.FirstOrDefault<DocumentosPlantilla>("CALL GetLiquidacionPlanilla(@0);", 0);
        }

        public Liquidacion GetLiquidacionById(int ID)
        {
            return db.FirstOrDefault<Liquidacion>("CALL GetLiquidacionById(@0);", ID);
        }
        public List<Liquidacion> GetLiquidacionByTrabajdor(int IdTrabajador)
        {
            return db.Fetch<Liquidacion>("CALL GetLiquidacionByTrabajador(@0);", IdTrabajador);
        }


        public List<Liquidacion> GetLiquidacionesEmpresaPeriodo(string year,string month)
        {
            return db.Fetch<Liquidacion>("CALL GetLiquidacionesEmpresaPeriodo(@0,@1,@2);", Sesion.UsuarioActual.IdEmpresa,year,month);
        }
    }
}
