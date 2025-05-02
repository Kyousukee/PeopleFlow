using PeopleFlow.DTO;
using PeopleFlow.DTO.Tareas.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BOCargo
    {
        public List<DTO.Roles> GetRoles()
        {
            List<DTO.Roles> roles = new List<DTO.Roles>();
            try
            {
                DAO.CargosDAO cargosDAO = new DAO.CargosDAO();
                roles = cargosDAO.GetCargos();
                roles.Add(new Roles { IdRol = 0, Descripcion = "Seleccione" });
                roles = roles.OrderBy(x => x.IdRol).ToList();
                return roles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<DTO.Roles> GetRolesByEmpresa()
        {
            List<DTO.Roles> roles = new List<DTO.Roles>();
            try
            {
                DAO.CargosDAO cargosDAO = new DAO.CargosDAO();
                roles = cargosDAO.GetCargos();
                return roles;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
