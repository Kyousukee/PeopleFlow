using NLog;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.MonthCalendar;

namespace PeopleFlow.Formularios.TareasForm
{
    public partial class FrmAsignarTarea : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public int IdTarea = 0;
        Empleados SelectEmplAsig = new Empleados();
        TareasEmpleados SelectEmplQuitar = new TareasEmpleados();
        public FrmAsignarTarea()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVTrabajadores.BackgroundColor = Color.White;
            DGVTrabajadores.BorderStyle = BorderStyle.None;
            DGVTrabajadores.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVTrabajadores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVTrabajadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVTrabajadores.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVTrabajadores.DefaultCellStyle.BackColor = Color.White;
            DGVTrabajadores.DefaultCellStyle.ForeColor = Color.Black;
            DGVTrabajadores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVTrabajadores.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVTrabajadores.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVTrabajadores.GridColor = Color.LightGray; // Color de las líneas de separación

            DGVAsignados.BackgroundColor = Color.White;
            DGVAsignados.BorderStyle = BorderStyle.None;
            DGVAsignados.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVAsignados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVAsignados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVAsignados.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVAsignados.DefaultCellStyle.BackColor = Color.White;
            DGVAsignados.DefaultCellStyle.ForeColor = Color.Black;
            DGVAsignados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVAsignados.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVAsignados.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVAsignados.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmAsignarTarea_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            dttFAsignacion.Value = DateTime.Now;
            dtpFFin.Value = DateTime.Now;
            cargarEmpleados();
            cargarAsignados();

        }



        private void cargarEmpleados()
        {
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                if (IdTarea != 0)
                {
                    empleados = new BO.BOTareas().cargarEmpleadosnoTareas(IdTarea);
                    DGVTrabajadores.DataSource = empleados;

                    DGVTrabajadores.Columns["IdEmpleado"].Visible = false;
                    DGVTrabajadores.Columns["FechaNacimiento"].Visible = false;
                    DGVTrabajadores.Columns["Telefono"].Visible = false;
                    DGVTrabajadores.Columns["Correo"].Visible = false;
                    DGVTrabajadores.Columns["Direccion"].Visible = false;
                    DGVTrabajadores.Columns["FechaIngreso"].Visible = false;
                    DGVTrabajadores.Columns["Estado"].Visible = false;
                    DGVTrabajadores.Columns["IdRol"].Visible = false;
                    DGVTrabajadores.Columns["Cargo"].Visible = false;
                    DGVTrabajadores.Columns["IdEmpresa"].Visible = false;
                    DGVTrabajadores.Columns["Empresa"].Visible = false;
                    DGVTrabajadores.Columns["IdTareaEmpl"].Visible = false;
                    DGVTrabajadores.Columns["Idtarea"].Visible = false;

                    DGVTrabajadores.Columns["IdSalud"].Visible = false;
                    DGVTrabajadores.Columns["Salud"].Visible = false;
                    DGVTrabajadores.Columns["IdAfp"].Visible = false;
                    DGVTrabajadores.Columns["AFP"].Visible = false;
                    DGVTrabajadores.Columns["Contrato"].Visible = false;
                    DGVTrabajadores.Columns["IdContrato"].Visible = false;

                    DGVTrabajadores.Columns["IdEstadoCivil"].Visible = false;
                    DGVTrabajadores.Columns["EstadoCivil"].Visible = false;
                    DGVTrabajadores.Columns["Banco"].Visible = false;
                    DGVTrabajadores.Columns["TipoCuenta"].Visible = false;
                    DGVTrabajadores.Columns["NumeroCuenta"].Visible = false;
                    DGVTrabajadores.Columns["Nacionalidad"].Visible = false;
                    DGVTrabajadores.Columns["Profesion"].Visible = false;




                }
                else
                {
                    Mensaje("Error: No se ha seleccionado una tarea.");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado Empleado: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void cargarAsignados()
        {
            List<TareasEmpleados> tareas = new List<TareasEmpleados>();
            try
            {
                if (IdTarea != 0)
                {
                    tareas = new BO.BOTareas().cargarEmpleadosTareas(IdTarea);
                    DGVAsignados.DataSource = tareas;

                    DGVAsignados.Columns["IdTareaEmpl"].Visible = false;
                    DGVAsignados.Columns["Idtarea"].Visible = false;
                    DGVAsignados.Columns["IdEmpleador"].Visible = false;
                    DGVAsignados.Columns["Usuario"].Visible = false;

                }
                else
                {
                    Mensaje("Error: No se ha seleccionado una tarea.");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado Asignados: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void DGVTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVTrabajadores.Rows[e.RowIndex];
                    SelectEmplAsig = (DGVTrabajadores.DataSource as List<Empleados>)[e.RowIndex];

                    btnIngresar.Enabled = true;
                    chkFechaFin.Enabled = true;
                    dttFAsignacion.Enabled = true;
                    btnQuitar.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar trabajador: {this.Name}");
                Mensaje("Error al seleccionar trabajador: " + ex.Message);
            }

        }

        private void DGVAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVAsignados.Rows[e.RowIndex];
                    SelectEmplQuitar = (DGVAsignados.DataSource as List<TareasEmpleados>)[e.RowIndex];


                    btnIngresar.Enabled = false;
                    chkFechaFin.Enabled = false;
                    dttFAsignacion.Enabled = false;
                    btnQuitar.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar asignado: {this.Name}");
                Mensaje("Error al seleccionar asignado: " + ex.Message);
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TareasEmpleados datos = new TareasEmpleados();
            try
            {
                if (SelectEmplAsig != null)
                {
                    // Obtener la datos
                    datos.IdTareaEmpl = 0;
                    datos.Idtarea = IdTarea;
                    datos.IdEmpleador = SelectEmplAsig.IdEmpleado;
                    datos.FechaIni = dttFAsignacion.Value;
                    datos.Usuario = Sesion.UsuarioActual.NombreUsuario;

                    if (chkFechaFin.Checked)
                        datos.FechaFin = dtpFFin.Value;

                    new BO.BOTareas().registroAsignacionTarea(datos);

                    Mensaje("Trabajador Asignado correctamente.");

                    cargarAsignados();
                    cargarEmpleados();


                    btnIngresar.Enabled = false;
                    chkFechaFin.Enabled = false;
                    dttFAsignacion.Enabled = false;
                    btnQuitar.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al asignar empleado: {this.Name}");
                Mensaje("Error al asignar empleado: " + ex.Message);
            }
        }

        private void chkFechaFin_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFechaFin.Checked)
            {
                dtpFFin.Enabled = false;
            }
            else
            {
                dtpFFin.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectEmplQuitar != null)
                {


                    new BO.BOTareas().registroAsignacionTarea(SelectEmplQuitar);

                    Mensaje("Trabajador quitado correctamente.");

                    cargarAsignados();
                    cargarEmpleados();


                    btnIngresar.Enabled = false;
                    chkFechaFin.Enabled = false;
                    dttFAsignacion.Enabled = false;
                    btnQuitar.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al quitar empleado: {this.Name}");
                Mensaje("Error al quitar empleado: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
