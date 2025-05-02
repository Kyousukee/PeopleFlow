using NLog;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
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

namespace PeopleFlow.Formularios.Dashboard
{
    public partial class FrmListadoRegistrosEmpleados : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        List<RegistroActividad> actividades = new List<RegistroActividad>();
        public FrmListadoRegistrosEmpleados()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVPlanilla.BackgroundColor = Color.White;
            DGVPlanilla.BorderStyle = BorderStyle.None;
            DGVPlanilla.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVPlanilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVPlanilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVPlanilla.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVPlanilla.DefaultCellStyle.BackColor = Color.White;
            DGVPlanilla.DefaultCellStyle.ForeColor = Color.Black;
            DGVPlanilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVPlanilla.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVPlanilla.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVPlanilla.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoRegistrosEmpleados_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarControles();
            CargarTareas();
            CargarTrabajadores();
        }

        private void cargarControles()
        {
            dttFIni.Value = DateTime.Now;
            dttFFin.Value = DateTime.Now;
        }

        private void CargarTareas()
        {

            try
            {
                List<Tareas> tareas = new BO.BOTareas().cargarTareas();

                tareas.Add(new Tareas { IdTarea = 0, Titulo = "Todos" });
                tareas = tareas.OrderBy(x => x.IdTarea).ToList();

                cboTareas.DataSource = tareas;
                cboTareas.DisplayMember = "Titulo";
                cboTareas.ValueMember = "IdTarea";

                //tareas = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar tipo tareas: FrmListadoRegistrosEmpleados");
                Mensaje("Error al cargar tipo tareas: " + ex.Message);

            }
        }

        private void CargarTrabajadores()
        {
            List<EmpleadosContratos> emp = new List<EmpleadosContratos>();
            try
            {
                emp = new BO.BOEmpleados().cargarTrabajadoresContratos();
                emp[0].Descripcion = "Todos";
                cboEmpleados.DataSource = emp;
                cboEmpleados.DisplayMember = "Descripcion";
                cboEmpleados.ValueMember = "Id";

                // Crear una lista de autocompletado personalizada
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                foreach (var empleado in emp)
                {
                    autoCompleteCollection.Add(empleado.Descripcion);
                }
                cboEmpleados.AutoCompleteCustomSource = autoCompleteCollection;

                emp = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar trabajadores: FrmListadoRegistrosEmpleados");
                Mensaje("Error al cargar trabajadores: " + ex.Message);

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int Tarea = Convert.ToInt32(cboTareas.SelectedValue);
                int Empleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                DateTime FIni = dttFIni.Value;
                DateTime FFin = dttFFin.Value;

                actividades = new BO.BOTareas().getRegistroActividades(Tarea, FIni, FFin, Empleado);

                if (actividades.Count > 0)
                {
                    DGVPlanilla.DataSource = actividades;
                    DGVPlanilla.Columns["IdTarea"].Visible = false;
                    DGVPlanilla.Columns["PagoIndividual"].DefaultCellStyle.Format = "N0";
                    DGVPlanilla.Columns["ValorUnitario"].DefaultCellStyle.Format = "N0";
                    DGVPlanilla.Columns["Total"].DefaultCellStyle.Format = "N0";
                    btnexport.Enabled = true;
                    DGVPlanilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    Mensaje("No se encontraron registros de actividades.Favor Validar si trabajador esta asignado a tarea o viceversa");
                    DGVPlanilla.DataSource = null;
                    btnexport.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al generar planilla de Registros: FrmListadoRegistrosEmpleados");
                Mensaje("Error al generar planilla de Registros: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboEmpleados.SelectedIndex = 0;
            cboTareas.SelectedIndex = 0;
            dttFIni.Value = DateTime.Now;
            dttFFin.Value = DateTime.Now;
            DGVPlanilla.DataSource = null;
            btnexport.Enabled = false;

        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividades!=null)
                {
                    BO.BOTareas bo = new BO.BOTareas();
                    string nombre = "PlanillaRegistros" + DateTime.Now.ToString("yyyyMMddHHmmss")+".xlsx";
                    string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string rutaArchivo = Path.Combine(rutaCarpeta, nombre);
                    // Si el archivo ya existe, eliminarlo antes de generar el nuevo
                    if (File.Exists(rutaArchivo))
                    {
                        File.Delete(rutaArchivo);
                    }
                    bo.GenerarExcelRegistroActividades(actividades, rutaArchivo);

                    Mensaje("Excel Generado Correctamente !!");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al generar Excel: FrmListadoRegistrosEmpleados");
                Mensaje("Error al generar Excel: " + ex.Message);
            }
        }
    }
}
