using Microsoft.Extensions.Configuration;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.DAO
{
    public class ContratosDAO
    {
        public PetaPoco.Database db;
        public ContratosDAO()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Usar el directorio base de la aplicación
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("MySqlConnection");

            db = new PetaPoco.Database(connectionString, "MySql.Data.MySqlClient"); // Conectar con MySQL
        }

        public List<TipoContrato> GetTipoContratos()
        {
            return db.Fetch<TipoContrato>("CALL GetTipoContrato;");
        }

        public List<Plazos> GetPlazos()
        {
            return db.Fetch<Plazos>("CALL GetPlazos;");
        }

        public Contrato GetContratoTrabajador( int idEmpleador)
        {
            return db.FirstOrDefault<Contrato>("CALL GetContratoByTrabajador(@0);", idEmpleador);
        }

        public List<Bonificaciones> GetBonificacionesEmpresa()
        {
            return db.Fetch<Bonificaciones>("CALL GetBonificacionByEmpresa(@0);", Sesion.UsuarioActual.IdEmpresa);
        }

        public List<Bonificaciones> GetBonificacionesEmpresaEmpleado(int IdEmpleado)
        {
            return db.Fetch<Bonificaciones>("CALL GetBonificacionesEmpleado(@0,@1);", IdEmpleado,Sesion.UsuarioActual.IdEmpresa);
        }

        public List<AnexoContrato> GetAnexosContratos(int IdContrato)
        {
            return db.Fetch<AnexoContrato>("CALL GetAnexosContratos(@0);", IdContrato);
        }

        public List<FiniquitoTipoDetalle> GetTipoDetalleFiniquito()
        {
            return db.Fetch<FiniquitoTipoDetalle>("CALL GetTipoDetalleFiniquito;");
        }

        public List<TipoFiniquito> GetTipoFiniquito()
        {
            return db.Fetch<TipoFiniquito>("CALL GetTipoFiniquito;");
        }




        public List<Contrato> GetContratos()
        {
            return db.Fetch<Contrato>("CALL GetContratos(@0);",Sesion.UsuarioActual.IdEmpresa);
        }

        public Finiquito GetFiniquito(int IdContrato)
        {
            Finiquito resp = new Finiquito();
            resp= db.FirstOrDefault<Finiquito>("CALL GetFiniquitoByContrato(@0);", IdContrato);
            if (resp != null)
            {
                resp.detalleFiniquitos = db.Fetch<DetalleFiniquito>("CALL GetFiniquitoDetalleByID(@0);", resp.idFiniquitos);
            }
            
            return resp;
        }

        public Contrato registroContrato(Contrato datos)
        {
            Contrato response = new Contrato();
            try
            {
                response = db.FirstOrDefault<Contrato>("CALL RegistroContrato(@0, @1, @2, @3, @4, @5, @6, @7,@8,@9,@10);",
                             datos.IdContrato,
                             datos.IdEmpleado,
                             datos.FechaInicio.Date,
                             datos.FechaFin.Date,
                             datos.IdTipoContrato,
                             datos.IdPlazo,
                             datos.NPlazo,
                             datos.Descripcion,
                             datos.Estado,
                             datos.IdTarea,
                             Sesion.UsuarioActual.IdEmpresa,
                             Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;


        }

        public void EliminarAnexo(int idAnexo)
        {
            try
            {
                db.Execute("CALL DeleteAnexosContratos(@0,@1);", idAnexo,Sesion.UsuarioActual.IdUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public AnexoContrato RegistroAnexosContratos(AnexoContrato datos)
        {
            AnexoContrato response = new AnexoContrato();
            try
            {
                response = db.FirstOrDefault<AnexoContrato>("CALL RegistroAnexosContratos(@0, @1, @2, @3, @4,@5,@6);",
                             datos.idAnexoContrato,
                             datos.IdContrato,
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

        public Finiquito RegistroFiniquito(Finiquito datos)
        {
            Finiquito response = new Finiquito();
            List<DetalleFiniquito> detalle = new List<DetalleFiniquito>();
            try
            {
                detalle = datos.detalleFiniquitos;

                response = db.FirstOrDefault<Finiquito>("CALL RegistroFiniquito(@0, @1, @2, @3, @4, @5, @6, @7);",
                             datos.idFiniquitos,
                             datos.IdContrato,
                             datos.FechaFiniquito.Date,
                             datos.IdTipoFiniquito,
                             datos.Observacion,
                             Sesion.UsuarioActual.IdEmpresa,
                             datos.Estado,
                             Sesion.UsuarioActual.IdUsuario);

                if (detalle != null)
                {
                    if (detalle.Count > 0)
                    {
                        response.detalleFiniquitos = new List<DetalleFiniquito>();
                        foreach (DetalleFiniquito item in detalle)
                        {
                            response.detalleFiniquitos = db.Fetch<DetalleFiniquito>("CALL RegistroFiniquitoDetalle(@0, @1, @2, @3, @4);",
                                 0,
                                 response.idFiniquitos,
                                 item.Descripcion,
                                 item.Monto,
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

        public List<DetalleFiniquito> GetDetalleFiniquito(int IdFiniquito)
        {
            return db.Fetch<DetalleFiniquito>("CALL GetDetalleFiniquito(@0);", IdFiniquito);
        }

        public DocumentosPlantilla GetFiniquitoPlanilla()
        {
            return db.FirstOrDefault<DocumentosPlantilla>("CALL GetFiniquitoPlanilla();");
        }
    }
}
