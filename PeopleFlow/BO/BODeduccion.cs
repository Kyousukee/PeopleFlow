using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BODeduccion
    {
        public Deducciones registrarBeneficio(Deducciones datos)
        {
            Deducciones response = new Deducciones();
            try
            {
                response = new DAO.DeduccionesDAO().registroDeducciones(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;

        }

        public List<Deducciones> cargarDeducciones()
        {
            List<Deducciones> response = new List<Deducciones>();
            try
            {
                response = new DAO.DeduccionesDAO().GetDeducciones();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<EmpleadosContratos> cargarBeneficiosEmpleados(int iddeduccion)
        {
            List<EmpleadosContratos> response = new List<EmpleadosContratos>();
            try
            {
                response = new DAO.DeduccionesDAO().GetDeduccionesEmpleados(iddeduccion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
    }
}
