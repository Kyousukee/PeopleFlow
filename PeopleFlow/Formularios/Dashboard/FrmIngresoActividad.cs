using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace PeopleFlow.Formularios.Dashboard
{
    public partial class FrmIngresoActividad : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public TareasConEmpleados Tarea = new TareasConEmpleados();
        public bool Save = false;
        public FrmIngresoActividad()
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

        private void FrmIngresoActividad_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            txtTitulo.Text = Tarea.Titulo;
            cargarControles();
            cargarTrabajadores();
        }

        private void cargarControles()
        {
            dttFAsignacion.Value = DateTime.Now;
            dttFAsignacion.MaxDate = DateTime.Now;
        }

        private void cargarTrabajadores()
        {
            List<TareasEmpleados> empleados = new List<TareasEmpleados>();
            try
            {
                empleados.Add(new TareasEmpleados()
                {
                    IdEmpleador = 0,
                    Nombre = "Todos",
                    Apellido = ""
                });
                empleados.AddRange(new BO.BOTareas().cargarEmpleadosTareas(Tarea.IdTarea));

                foreach (TareasEmpleados item in empleados)
                {
                    item.NombreCompleto = item.Nombre + " " + item.Apellido;
                }
                //empleados = new BO.BOTareas().cargarEmpleadosTareas(Tarea.IdTarea);
                cboEmpleados.DataSource = empleados;
                cboEmpleados.DisplayMember = "NombreCompleto";
                cboEmpleados.ValueMember = "IdEmpleador";
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado trabajadores: FrmIngresoActividad");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtcantidad, e);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                DTO.TareasDTO.TareasEmpleadosRegistros datos = new DTO.TareasDTO.TareasEmpleadosRegistros();
                if (Validar()) return;
                datos.IdTareaEmpleado = 0;
                datos.IdTarea = Tarea.IdTarea;
                datos.FechaAsignacion = dttFAsignacion.Value;
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.Cantidad = Convert.ToInt32(txtcantidad.Text);
                datos.PagoIndividual = Convert.ToInt32(txtPagoIndividual.Text);
                DTO.TareasDTO.TareasEmpleadosRegistros response = new BO.BOTareas().registroTareaRegistro(datos);
                if (response.IdTareaEmpleado > 0)
                {
                    Save = true;
                    Mensaje("Actividad registrada correctamente.");
                    this.Close();
                }
                else
                {
                    Mensaje("Error al registrar la Actividad.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar la Actividad: FrmIngresoActividad");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPagoIndividual.Enabled = true;
            }
            else
            {
                txtPagoIndividual.Text = "";
                txtPagoIndividual.Enabled = false;
            }
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRequerido(txtcantidad.Text, "Cantidad", out string mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (!Validaciones.ValidarRequerido(txtPagoIndividual.Text, "Pago Individual", out mensajeError) && checkBox1.CheckState == CheckState.Checked)
            {
                errores.Add(mensajeError);
            }

            if (string.IsNullOrWhiteSpace(txtPagoIndividual.Text))
            {
                txtPagoIndividual.Text = "0";
            }

            if (Convert.ToDecimal(txtPagoIndividual.Text) == 0 && checkBox1.CheckState == CheckState.Checked)
            {
                errores.Add("El valor debe ser mayor a 0.");
            }

            if (Convert.ToDecimal(txtcantidad.Text) <= 0)
            {
                errores.Add("La cantidad debe ser mayor a 0.");
            }

            // Validación de existencia
            TareasEmpleadosRegistros validador = new BO.BOTareas().getTareaRegistro(Tarea.IdTarea, Convert.ToInt32(cboEmpleados.SelectedValue), dttFAsignacion.Value);
            if (validador != null)
            {
                DialogResult resultt = MessageBox.Show(
                    "Ya existe un registro con los mismos valores. ¿Desea reemplazarlo?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (resultt != DialogResult.Yes)
                {
                    errores.Add("Registro ya se encuentra existente.");
                }
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // Hay errores
            }

            return false; // Todo válido
        }


        private void txtPagoIndividual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtPagoIndividual, e);
        }
    }
}
