using MySqlX.XDevAPI.Common;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Tareas.Tareas;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.TareasForm;
using PeopleFlow.Formularios.Trabajdores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using NLog;

namespace PeopleFlow.Formularios
{
    public partial class FrmTareas : Form
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmTareas()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmTareas_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }

            cargarControles();
            cargarEstados();
            cargarTipoPago();
            cargarJornada();
        }

        private void cargarControles()
        {
            dttFAsignacion.Value = DateTime.Now;
            dtpFFin.Value = DateTime.Now;
            //dttFIngreso.MinDate = DateTime.Now.AddDays(-1);

        }

        private void cargarEstados()
        {
            List<EstadoTarea> estados = new List<EstadoTarea>();
            try
            {
                estados = new BO.BOTareas().cargarTareasEstados();
                cboEstado.DataSource = estados;
                cboEstado.DisplayMember = "Descripcion";
                cboEstado.ValueMember = "IdEstadoTarea";

                estados = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar roles: FrmTareas");
                Mensaje("Error al cargar roles: " + ex.Message);

            }
        }

        private void cargarJornada()
        {
            List<Jornadas> jornada = new List<Jornadas>();
            try
            {
                jornada = new BO.BOTareas().cargarJornadas();
                cbojornada.DataSource = jornada;
                cbojornada.DisplayMember = "DescripcionDiaComienzo";
                cbojornada.ValueMember = "idJornadas";

                jornada = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Jornadas: FrmTareas");
                Mensaje("Error al cargar Jornadas: " + ex.Message);

            }
        }

        private void cargarTipoPago()
        {
            List<TipoPago> tipoPago = new List<TipoPago>();
            try
            {
                tipoPago = new BO.BOTareas().cargarTipoPago();
                Cbotipopago.DataSource = tipoPago;
                Cbotipopago.DisplayMember = "Descripcion";
                Cbotipopago.ValueMember = "IdTipoPago";

                tipoPago = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Tipo Pago: FrmTareas");
                Mensaje("Error al cargar Tipo Pago: " + ex.Message);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.TareasDTO.Tareas datos = new DTO.TareasDTO.Tareas();
                if (Validar()) return;
                datos.IdTarea = 0;
                datos.Descripcion = txtdescripcion.Text;
                datos.FechaAsignacion = dttFAsignacion.Value;
                datos.FechaFinalizacion = dtpFFin.Value;
                datos.IdEstadoTarea = Convert.ToInt32(cboEstado.SelectedValue);
                datos.IdTipoPago = Convert.ToInt32(Cbotipopago.SelectedValue);
                datos.Valor = Convert.ToDecimal(txtvalor.Text);
                datos.Titulo = txtNombre.Text;
                datos.IdJornada = Convert.ToInt32(cbojornada.SelectedValue);

                DTO.TareasDTO.Tareas response = new BO.BOTareas().registroTarea(datos);
                if (response.IdTarea > 0)
                {
                    Mensaje("Tarea registrada correctamente.");
                    cargarTarea(response);
                }
                else
                {
                    Mensaje("Error al registrar la tarea.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al intentar Grabar tarea: FrmTareas");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.TareasDTO.Tareas datos = new DTO.TareasDTO.Tareas();
                if (Validar()) return;
                datos.IdTarea = Convert.ToInt32(txtID.Text);
                datos.Descripcion = txtdescripcion.Text;
                datos.FechaAsignacion = dttFAsignacion.Value;
                datos.FechaFinalizacion = dtpFFin.Value;
                datos.IdEstadoTarea = Convert.ToInt32(cboEstado.SelectedValue);
                datos.IdTipoPago = Convert.ToInt32(Cbotipopago.SelectedValue);
                datos.Valor = Convert.ToDecimal(txtvalor.Text);
                datos.Titulo = txtNombre.Text;
                datos.IdJornada = Convert.ToInt32(cbojornada.SelectedValue);

                DTO.TareasDTO.Tareas response = new BO.BOTareas().registroTarea(datos);
                if (response.IdTarea > 0)
                {
                    Mensaje("Tarea registrada correctamente.");
                    cargarTarea(response);
                }
                else
                {
                    Mensaje("Error al registrar la tarea.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al intentar editar tarea: FrmTareas");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void cargarTarea(Tareas tarea)
        {
            try
            {
                txtID.Text = tarea.IdTarea.ToString();
                txtNombre.Text = tarea.Titulo;
                txtdescripcion.Text = tarea.Descripcion;
                dttFAsignacion.Value = tarea.FechaAsignacion;
                dtpFFin.Value = tarea.FechaFinalizacion;
                cboEstado.SelectedValue = tarea.IdEstadoTarea;
                Cbotipopago.SelectedValue = tarea.IdTipoPago;
                txtvalor.Text = tarea.Valor.ToString("N0");
                cbojornada.SelectedValue = tarea.IdJornada;

                btnIngresar.Enabled = false;
                btnActualizar.Enabled = true;
                btnControl.Enabled = true;
                btnasignar.Enabled = true;

                //Mensaje("Trabajador cargado correctamente.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, "\"Error al cargar tarea en formulario: FrmTareas");
                Mensaje("Error al cargar tarea en formulario: " + ex.Message);
            }
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtvalor, e);
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRequerido(txtNombre.Text, "Nombre", out string mensajeError))
            {
                errores.Add(mensajeError);
            }
            if (!Validaciones.ValidarRequerido(txtdescripcion.Text, "Descripcion", out mensajeError))
            {
                errores.Add(mensajeError);
            }
            if (!Validaciones.ValidarRequerido(txtvalor.Text, "Valor", out mensajeError))
            {
                errores.Add(mensajeError);
            }
            else if (decimal.TryParse(txtvalor.Text, out decimal valor))
            {
                if (valor <= 0)
                {
                    errores.Add("El valor debe ser mayor a 0.");
                }
            }
            else
            {
                errores.Add("El valor ingresado no es válido.");
            }

            if (cboEstado.SelectedIndex == 0)
            {
                errores.Add("Debe seleccionar un estado.");
            }
            if (cbojornada.SelectedIndex == 0)
            {
                errores.Add("Debe seleccionar una Jornada.");
            }
            if (Cbotipopago.SelectedIndex == 0)
            {
                errores.Add("Debe seleccionar un tipo de pago.");
            }
            if (dttFAsignacion.Value > dtpFFin.Value)
            {
                errores.Add("La fecha de asignación no puede ser mayor a la fecha de finalización.");
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // indica que hubo errores
            }

            return false; // todo válido
        }


        private void btnListadoTrabajadores_Click(object sender, EventArgs e)
        {
            try
            {
                ListadoTareas frmShow = new ListadoTareas();
                frmShow.ShowDialog();
                if (frmShow.selectTarea.IdTarea != 0)
                {
                    cargarTarea(frmShow.selectTarea);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Empleados en formulario: FrmTareas");
                Mensaje("Error al cargar Listado de Empleados en formulario: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtdescripcion.Text = "";
            dttFAsignacion.Value = DateTime.Now;
            dtpFFin.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
            Cbotipopago.SelectedIndex = 0;
            cbojornada.SelectedIndex = 0;
            txtvalor.Text = "";
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;
            btnControl.Enabled = false;
            btnasignar.Enabled = false;

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoControl frmShow = new FrmListadoControl();
                frmShow.idTarea = Convert.ToInt32(txtID.Text);
                frmShow.ShowDialog();

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de cambios en formulario: FrmTareas");
                Mensaje("Error al cargar Listado de Cambios en formulario: " + ex.Message);
            }
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAsignarTarea frmShow = new FrmAsignarTarea();
                frmShow.IdTarea = Convert.ToInt32(txtID.Text);
                frmShow.ShowDialog();

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Cambios en formulario:FrmTareas");
                Mensaje("Error al cargar Listado de Cambios en formulario: " + ex.Message);
            }
        }
    }
}
