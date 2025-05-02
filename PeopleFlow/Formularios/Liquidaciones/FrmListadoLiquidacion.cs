using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFlow.Formularios.Liquidaciones
{
    public partial class FrmListadoLiquidacion : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Liquidacion selecLiquidacion = new DTO.Liquidacion();
        public FrmListadoLiquidacion()
        {
            InitializeComponent();
            StyleTable();
        }
        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVLiquidacion.BackgroundColor = Color.White;
            DGVLiquidacion.BorderStyle = BorderStyle.None;
            DGVLiquidacion.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVLiquidacion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVLiquidacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVLiquidacion.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVLiquidacion.DefaultCellStyle.BackColor = Color.White;
            DGVLiquidacion.DefaultCellStyle.ForeColor = Color.Black;
            DGVLiquidacion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVLiquidacion.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVLiquidacion.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVLiquidacion.GridColor = Color.LightGray; // Color de las líneas de separación

        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoLiquidacion_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarcontroles();
            cargarLiquidaciones();
        }

        private void cargarcontroles()
        {
            // Configura el DateTimePicker para mostrar solo el año
            // Configura el DateTimePicker para mostrar solo el año
            dttYear.Format = DateTimePickerFormat.Custom;
            dttYear.CustomFormat = "yyyy"; // Solo muestra el año
            dttYear.ShowUpDown = true; // Usa controles de flecha para cambiar el año

            // Establece el año actual como valor inicial
            dttYear.Value = DateTime.Now; // Fecha actual

            // Configurar para mostrar solo el mes
            dttMeses.Format = DateTimePickerFormat.Custom;
            dttMeses.CustomFormat = "MMMM"; // Mostrar el nombre completo del mes (ej: "Enero")
                                            // dateTimePicker1.CustomFormat = "MMM"; // Mostrar el nombre abreviado del mes (ej: "Ene")
                                            // dateTimePicker1.CustomFormat = "MM"; // Mostrar el número del mes (ej: "01")

            dttMeses.ShowUpDown = true; // Usar controles de flecha para cambiar el mes

            // Establecer el mes actual como valor inicial
            dttMeses.Value = DateTime.Now; // Fecha actual
        }

        public void cargarLiquidaciones()
        {
            List<DTO.Liquidacion> liquidaciones = new List<DTO.Liquidacion>();
            try
            {
                liquidaciones = new BO.BOLiquidaciones().GetLiquidacionesEmpresa();
                DGVLiquidacion.DataSource = liquidaciones;
                DGVLiquidacion.Columns["IdLiquidacion"].HeaderText = "N°";
                DGVLiquidacion.Columns["IdContrato"].HeaderText = "N° Contrato";
                DGVLiquidacion.Columns["IdEmpleado"].Visible = false;
                DGVLiquidacion.Columns["IdEmpresa"].Visible = false;
                DGVLiquidacion.Columns["year"].Visible = false;
                DGVLiquidacion.Columns["month"].Visible = false;
                DGVLiquidacion.Columns["DescripcionBonos"].Visible = false;
                DGVLiquidacion.Columns["DescripcionDeducciones"].Visible = false;
                DGVLiquidacion.Columns["DescripcionDeducciones"].Visible = false;
                DGVLiquidacion.Columns["SalarioBase"].DefaultCellStyle.Format = "N0";
                DGVLiquidacion.Columns["Bonificaciones"].DefaultCellStyle.Format = "N0";
                DGVLiquidacion.Columns["Deducciones"].DefaultCellStyle.Format = "N0";
                DGVLiquidacion.Columns["SueldoLiquido"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }


        }

        private void DGVLiquidacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVLiquidacion.Rows[e.RowIndex];
                    ;
                    selecLiquidacion = (DGVLiquidacion.DataSource as List<DTO.Liquidacion>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Liquidacion seleccionada:\n" +
                                     $"ID: {row.Cells["IdLiquidacion"].Value}\n" +
                                     $"Periodo: {row.Cells["Periodo"].Value}\n" +
                                     $"Empleado: {row.Cells["NombreEmpleado"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar Empleado: {this.Name}");
                Mensaje("Error al seleccionar Empleado: " + ex.Message);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DGVLiquidacion.DataSource = null;
            cargarcontroles();
            cargarLiquidaciones();
        }

        private void cargaLiquidacionPeriodo(DateTime year, DateTime month)
        {
            List<DTO.Liquidacion> liquidaciones = new List<DTO.Liquidacion>();
            try
            {
                string yearString = dttYear.Value.Year.ToString();
                string monthString = dttMeses.Value.Month.ToString();
                liquidaciones = new BO.BOLiquidaciones().GetLiquidacionesEmpresaPeriodo(yearString, monthString);
                DGVLiquidacion.DataSource = liquidaciones;
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado Periodo: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DGVLiquidacion.DataSource = null;
            cargaLiquidacionPeriodo(dttYear.Value, dttMeses.Value);
        }
    }
}
