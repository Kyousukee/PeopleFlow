using PeopleFlow.DTO;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BOBeneficios
    {
        public Bonificaciones registrarBeneficio(Bonificaciones datos)
        {
            Bonificaciones response = new Bonificaciones();
            try
            {
                response = new DAO.BonificacionDAO().registroBonificaciones(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;

        }

        public List<Bonificaciones> cargarBeneficios()
        {
            List<Bonificaciones> response = new List<Bonificaciones>();
            try
            {
                response = new DAO.BonificacionDAO().GetBonificaciones();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<EmpleadosContratos> cargarBeneficiosEmpleados(int IdBeneficio)
        {
            List<EmpleadosContratos> response = new List<EmpleadosContratos>();
            try
            {
                response = new DAO.BonificacionDAO().GetBonificacionesEmpleados(IdBeneficio);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }


    }
}
