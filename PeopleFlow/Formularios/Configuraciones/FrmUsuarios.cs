using MySqlX.XDevAPI.Common;
using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.Formularios.Bonificaciones;
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
    public partial class FrmUsuarios : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListadoTrabajadores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoUsuarios frmShow = new FrmListadoUsuarios();
                frmShow.ShowDialog();
                if (frmShow.Selectusuario.IdUsuario != 0)
                {
                    CargarUsuario(frmShow.Selectusuario);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Usuarios en formulario: FrmUsuarios");
                Mensaje("Error al cargar Listado de Usuarios en formulario: " + ex.Message);
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarEstados();
            cargarRoles();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cargarEstados()
        {
            var estados = new List<Estado>
            {
                new Estado { Id = 1, Nombre = "Activo" },
                new Estado { Id = 0, Nombre = "Inactivo" }
            };

            cboEstado.DataSource = estados;
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "Id";
        }

        private void limpiar()
        {
            txtID.Text = "";
            tztusuario.Text = "";
            txtApellidos.Text = "";
            txtRut.Text = "";
            txtcorreo.Text = "";
            txtID.Text = "";
            tztusuario.Text = "";
            cboCargo.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            txtnombres.Text = "";
            txtpass.Text = "";
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;
            btnArchivo.Enabled = false;

        }

        private void CargarUsuario(DTO.Usuarios datos)
        {
            txtID.Text = datos.IdUsuario.ToString();
            tztusuario.Text = datos.NombreUsuario;
            txtRut.Text = datos.Rut.Replace(".", "").Substring(0, 8);
            txtdv.Text = datos.Rut.Substring(datos.Rut.Length - 1);
            txtnombres.Text = datos.Nombres;
            txtApellidos.Text = datos.Apellidos;
            cboCargo.SelectedValue = datos.IdRol;
            cboEstado.SelectedValue = Convert.ToInt32(datos.Estado);
            txtcorreo.Text = datos.Correo;
            txtpass.Text = BCrypt.Net.BCrypt.HashString(datos.Contraseña);
            btnIngresar.Enabled = false;
            btnActualizar.Enabled = true;
            btnArchivo.Enabled = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarRoles()
        {
            List<Roles> roles = new List<Roles>();
            try
            {
                roles = new BO.BOCargo().GetRoles();
                cboCargo.DataSource = roles;
                cboCargo.DisplayMember = "Descripcion";
                cboCargo.ValueMember = "IdRol";

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar roles: FrmUsuarios");
                Mensaje("Error al cargar roles: " + ex.Message);

            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DTO.Usuarios req = new DTO.Usuarios();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.IdUsuario = 0;
                req.NombreUsuario = tztusuario.Text;

                DTO.Usuarios usuarios = new BO.BOUsuarios().login(tztusuario.Text, Sesion.UsuarioActual.IdEmpresa);

                if (usuarios != null)
                {
                    Mensaje("Nombre de Usuario ya se encuentra en Uso.");
                    return;
                }
                req.Rut = txtRut.Text + "-" + txtdv.Text;
                req.Nombres = txtnombres.Text;
                req.Apellidos = txtApellidos.Text;
                req.IdRol = Convert.ToInt32(cboCargo.SelectedValue);
                req.Correo = txtcorreo.Text;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                req.Contraseña = BCrypt.Net.BCrypt.HashPassword("123456");

                DTO.Usuarios response = new BOUsuarios().registroUsuario(req);
                Mensaje("Usuario registrado con exito.");

                CargarUsuario(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al grabar registro de Usuario: FrmUsuarios");
                Mensaje("Error al grabar registro de Usuario: " + ex.Message);
            }
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRut(txtRut.Text + "-" + txtdv.Text))
            {
                errores.Add("Error: Formato Rut no reconocido.");
            }

            if (!Validaciones.ValidarCorreo(txtcorreo.Text))
            {
                errores.Add("Error: Correo incorrecto.");
            }

            if (!Validaciones.ValidarRequerido(tztusuario.Text, "Usuario", out string mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (!Validaciones.ValidarRequerido(txtnombres.Text, "Nombres", out mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (!Validaciones.ValidarRequerido(txtApellidos.Text, "Apellidos", out mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // hay errores
            }

            return false; // todo válido
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DTO.Usuarios req = new DTO.Usuarios();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.IdUsuario = Convert.ToInt32(txtID.Text);
                req.NombreUsuario = tztusuario.Text;

                DTO.Usuarios usuarios = new BO.BOUsuarios().login(tztusuario.Text, Sesion.UsuarioActual.IdEmpresa);

                if (usuarios != null)
                {
                    Mensaje("Nombre de Usuario ya se encuentra en Uso.");
                    return;
                }

                req.Rut = txtRut.Text + "-" + txtdv.Text;
                req.Nombres = txtnombres.Text;
                req.Apellidos = txtApellidos.Text;
                req.IdRol = Convert.ToInt32(cboCargo.SelectedValue);
                req.Correo = txtcorreo.Text;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);

                DTO.Usuarios response = new BOUsuarios().registroUsuario(req);
                Mensaje("Usuario Actualizado con exito.");

                CargarUsuario(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar registro de Usuario: FrmUsuarios");
                Mensaje("Error al grabar registro de Usuario: " + ex.Message);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            DTO.Usuarios req = new DTO.Usuarios();
            Validaciones validaciones = new Validaciones();
            try
            {

                new BOUsuarios().ResetPassword(Convert.ToInt32(txtID.Text), BCrypt.Net.BCrypt.HashPassword("123456"));
                Mensaje("Contraseña Actualizada con exito.");
                txtpass.Text = BCrypt.Net.BCrypt.HashPassword("123456");

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al grabar contraseña de Usuario: FrmUsuarios");
                Mensaje("Error al grabar contraseña de Usuario: " + ex.Message);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
