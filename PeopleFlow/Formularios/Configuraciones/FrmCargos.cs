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
    public partial class FrmCargos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmCargos()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarEstados();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            cboEstado.SelectedIndex = 0;
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void btnListadoCargos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoCargos frmShow = new FrmListadoCargos();
                frmShow.ShowDialog();
                if (frmShow.Selectrool.IdRol != 0)
                {
                    CargarCargo(frmShow.Selectrool);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Cargos en formulario: FrmCargos");
                Mensaje("Error al cargar Listado de Cargos en formulario: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DTO.Roles req = new DTO.Roles();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.IdRol = 0;
                req.Descripcion = txtNombre.Text;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);


                DTO.Roles response = new BOUsuarios().registroCargo(req);
                Mensaje("Cargo registrado con exito.");

                CargarCargo(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al grabar nuevo cargo: FrmCargos");
                Mensaje("Error al grabar nuevo cargo: " + ex.Message);
            }
        }

        private bool Validar()
        {
            bool result = false;

            if (!Validaciones.ValidarRequerido(txtNombre.Text, "Descripcion", out string mensajeError))
            {
                Mensaje(mensajeError);
                result = true;
            }




            return result;
        }

        private void CargarCargo(DTO.Roles datos)
        {
            txtID.Text = datos.IdRol.ToString();
            txtNombre.Text = datos.Descripcion;
            cboEstado.SelectedValue = Convert.ToInt32(datos.Estado);
            btnIngresar.Enabled = false;
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DTO.Roles req = new DTO.Roles();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.IdRol = Convert.ToInt32(txtID.Text);
                req.Descripcion = txtNombre.Text;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);


                DTO.Roles response = new BOUsuarios().registroCargo(req);
                Mensaje("Cargo actualizado con exito.");

                CargarCargo(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al actualizar cargo: FrmCargos");
                Mensaje("Error al actualizar cargo: " + ex.Message);
            }
        }
    }
}
