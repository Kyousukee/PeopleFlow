using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BOEmpleados
    {
        public Empleados registroEmpleado(Empleados datos)
        {
            Empleados response = new Empleados();
            try
            {
                response = new DAO.EmpleadosDAO().registroEmpleado(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Empleados GetEmpleadosRut(string rut)
        {
            Empleados response = new Empleados();
            try
            {
                response = new DAO.EmpleadosDAO().GetEmpleadosRut(rut);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Empleados GetEmpleadosById(int IdEmpleado)
        {
            Empleados response = new Empleados();
            try
            {
                response = new DAO.EmpleadosDAO().GetEmpleadosByID(IdEmpleado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Empleados> cargarTrabajadores()
        {
            List<Empleados> response = new List<Empleados>();
            try
            {
                response = new DAO.EmpleadosDAO().GetEmpleados();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<EmpleadosContratos> cargarTrabajadoresContratos()
        {
            List<EmpleadosContratos> response = new List<EmpleadosContratos>();
            
            try
            {
                List<Empleados> emp = new DAO.EmpleadosDAO().GetEmpleadosContratos();
                response.Add(new EmpleadosContratos()
                {
                    Id = 0,
                    Descripcion = "Seleccione trabajador..."
                });
                foreach (Empleados e in emp) {
                    response.Add(new EmpleadosContratos()
                    {
                        Id = e.IdEmpleado,
                        Descripcion = e.Nombre + " " + e.Apellido + " / " + e.Rut + " / "
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<EmpleadosContratos> cargarTrabajadoresContratosActivos()
        {
            List<EmpleadosContratos> response = new List<EmpleadosContratos>();

            try
            {
                List<Empleados> emp = new DAO.EmpleadosDAO().GetEmpleadosContratosActivos();
                response.Add(new EmpleadosContratos()
                {
                    Id = 0,
                    Descripcion = "Seleccione trabajador..."
                });
                foreach (Empleados e in emp)
                {
                    response.Add(new EmpleadosContratos()
                    {
                        Id = e.IdEmpleado,
                        Descripcion = e.Nombre + " " + e.Apellido + " / " + e.Rut + " / ",
                        IdContrato = e.IdContrato
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Empleados> cargarTrabajadoresAll()
        {
            List<Empleados> response = new List<Empleados>();

            try
            {
                response = new DAO.EmpleadosDAO().GetEmpleadosAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
        
        public AsignacionFamiliar GetAsignacionFamiliar(int IdEmpleado)
        {
            AsignacionFamiliar response = new AsignacionFamiliar();

            try
            {
                response = new DAO.EmpleadosDAO().GetAsignacionFamiliar(IdEmpleado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public AsignacionFamiliar saveAsignacionFamiliar(AsignacionFamiliar datos)
        {
            AsignacionFamiliar response = new AsignacionFamiliar();

            try
            {
                response = new DAO.EmpleadosDAO().saveAsignacionFamiliar(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public void DeleteAsignacionFamiliar(int IdEmpleado)
        {
            

            try
            {
                new DAO.EmpleadosDAO().deleteAsignacionFamiliar(IdEmpleado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public List<EstadoCivil> cargarEstadoCivil()
        {
            List<EstadoCivil> response = new List<EstadoCivil>();

            try
            {
                response = new DAO.EmpleadosDAO().GetEstadoCivil();
                response.Add(new EstadoCivil()
                {
                    idEstado_Civil = 0,
                    Descripcion = "Seleccione estado civil..."
                });
                response = response.OrderBy(x => x.idEstado_Civil).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<RegimenSalud> cargarRegimenSalud()
        {
            List<RegimenSalud> response = new List<RegimenSalud>();

            try
            {
                response = new DAO.EmpleadosDAO().GetSaludEmpleados();
                response.Add(new RegimenSalud()
                {
                    idRegimenSalud = 0,
                    Descripcion = "Seleccione SALUD..."
                });
                response = response.OrderBy(x => x.idRegimenSalud).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TipoAfp> cargarAFP()
        {
            List<TipoAfp> response = new List<TipoAfp>();

            try
            {
                response = new DAO.EmpleadosDAO().GetAfpEmpleados();
                response.Add(new TipoAfp()
                {
                    idAFP = 0,
                    Descripcion = "Seleccione AFP..."
                });
                response = response.OrderBy(x => x.idAFP).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
    }
}
