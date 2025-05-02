using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BOUsuarios
    {
        public Usuarios login(string user,int idEmpresa)
        {
            DTO.Usuarios Login = new DTO.Usuarios();
            try
            {
                Login = new DAO.UsuariosDAO().login(user, idEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
            return Login;
        }

        public List<DTO.Usuarios> GetUsuariosByEmpresa()
        {
            List<DTO.Usuarios> ListaUsuarios = new List<DTO.Usuarios>();
            try
            {
                ListaUsuarios = new DAO.UsuariosDAO().GetUsuariosByEmpresa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaUsuarios;
        }

        public DTO.Usuarios registroUsuario(DTO.Usuarios datos)
        {
            DTO.Usuarios response = new DTO.Usuarios();
            try
            {
                response = new DAO.UsuariosDAO().registroUsuario(datos);
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
                response = new DAO.UsuariosDAO().registroCargo(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public List<ArchivosEmpresa> GetArchivosEmpresa()
        {
            List<ArchivosEmpresa> response = new List<ArchivosEmpresa>();
            try
            {
                response = new DAO.EmpresasDAO().GetArchivosEmpresa();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<FiniquitosEmpresa> GetFiniquitosEmpresa()
        {
            List<FiniquitosEmpresa> response = new List<FiniquitosEmpresa>();
            try
            {
                response = new DAO.EmpresasDAO().GetFiniquitosEmpresa();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public void EliminarArchivo(int IdArchivo)
        {
            try
            {
                new DAO.EmpresasDAO().EliminarArchivo(IdArchivo);
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
                response = new DAO.EmpresasDAO().RegistroArchivoEmpresa(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }


        public void ResetPassword(int idUsuario, string contraseña)
        {
            try
            {
                new DAO.UsuariosDAO().ResetPassword(idUsuario, contraseña);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool verificaUsuario()
        {
            if (Sesion.UsuarioActual != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
