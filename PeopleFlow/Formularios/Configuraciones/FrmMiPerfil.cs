using Microsoft.VisualBasic.Logging;
using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFlow.Formularios.Configuraciones
{
    public partial class FrmMiPerfil : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        DTO.Usuarios Login = new DTO.Usuarios();
        public FrmMiPerfil()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmMiPerfil_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarMiPerfil();
        }

        private void CargarMiPerfil()
        {
            try
            {
                Login = new BO.BOUsuarios().login(Sesion.UsuarioActual.NombreUsuario, Sesion.UsuarioActual.IdEmpresa);
                CargarUsuario(Login);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al informacion de perfil: FrmMiPerfil");
                Mensaje("Error al informacion de perfil: " + ex.Message);
            }
        }

        private void CargarUsuario(DTO.Usuarios datos)
        {
            txtID.Text = datos.IdUsuario.ToString();
            tztusuario.Text = datos.NombreUsuario;
            txtRut.Text = datos.Rut.Replace(".", "").Substring(0, 8);
            txtdv.Text = datos.Rut.Substring(datos.Rut.Length - 1);
            txtnombres.Text = datos.Nombres;
            txtApellidos.Text = datos.Apellidos;
            txtCargo.Text = datos.Cargo;
            txtcorreo.Text = datos.Correo;
            panelControles.Enabled = true;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                if (BCrypt.Net.BCrypt.Verify(txtpassactual.Text, Login.Contraseña))
                {
                    if (txtpassnew.Text == "" || txtpassconfirm.Text == "")
                    {
                        Mensaje("Error: Debe ingresar la nueva contraseña.");
                        return;

                    }
                    if (txtpassnew.Text == txtpassconfirm.Text)
                    {
                        actualizarContraseña();
                    }
                    else
                    {
                        // Contraseñas no coinciden
                        Mensaje("Error: Contraseñas no coinciden.");
                    }
                }
                else
                {
                    // Contraseña incorrecta
                    Mensaje("Error: Contraseña Actual incorrecta.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cambiar contraseña: FrmMiPerfil");
                Mensaje("Error al cambiar contraseña: " + ex.Message);
            }
        }

        private void actualizarContraseña()
        {
            DTO.Usuarios req = new DTO.Usuarios();
            Validaciones validaciones = new Validaciones();
            try
            {
                new BOUsuarios().ResetPassword(Login.IdUsuario, BCrypt.Net.BCrypt.HashPassword(txtpassnew.Text) );
                Mensaje("Contraseña Actualizada con exito.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al grabar nueva contraseña: FrmMiPerfil");
                Mensaje("Error al grabar nueva contraseña: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
