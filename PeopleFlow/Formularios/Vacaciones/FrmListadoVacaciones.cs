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

namespace PeopleFlow.Formularios.Vacaciones
{
    public partial class FrmListadoVacaciones : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Vacaciones selectedVacacion = new DTO.Vacaciones();
        public FrmListadoVacaciones()
        {
            InitializeComponent();
            StyleTable();
        }
        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVVacaciones.BackgroundColor = Color.White;
            DGVVacaciones.BorderStyle = BorderStyle.None;
            DGVVacaciones.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVVacaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVVacaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVVacaciones.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVVacaciones.DefaultCellStyle.BackColor = Color.White;
            DGVVacaciones.DefaultCellStyle.ForeColor = Color.Black;
            DGVVacaciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVVacaciones.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVVacaciones.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVVacaciones.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmListadoVacaciones_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarVacaciones();
        }

        public void cargarVacaciones()
        {
            List<DTO.Vacaciones> vacaciones = new List<DTO.Vacaciones>();
            try
            {
                vacaciones = new BO.BOVacaciones().GetVacacionesEmpresa();
                DGVVacaciones.DataSource = vacaciones;
                DGVVacaciones.Columns["idVacaciones"].HeaderText = "N°";
                DGVVacaciones.Columns["FechaIni"].HeaderText = "Fecha Inicio";
                DGVVacaciones.Columns["FechaFin"].HeaderText = "Fecha Termino";
                DGVVacaciones.Columns["Fecha_Retorno"].HeaderText = "Fecha Retorno";
                DGVVacaciones.Columns["IdEmpleado"].Visible = false;
                DGVVacaciones.Columns["IdEmpresa"].Visible = false;
                DGVVacaciones.Columns["Usuario"].Visible = false;
                //DGVVacaciones.Columns["IdJornada"].Visible = false;
                DGVVacaciones.Columns["FechaIni"].DefaultCellStyle.Format = "dd/MM/yyyy";
                DGVVacaciones.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                DGVVacaciones.Columns["Fecha_Retorno"].DefaultCellStyle.Format = "dd/MM/yyyy";
                // Primero ajusta al contenido
                DGVVacaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                DGVVacaciones.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado Vacaciones: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }


        }

        private void DGVVacaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVVacaciones.Rows[e.RowIndex];
                    ;
                    selectedVacacion = (DGVVacaciones.DataSource as List<DTO.Vacaciones>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Vacacion seleccionada:\n" +
                                     $"ID: {row.Cells["idVacaciones"].Value}\n" +
                                     $"Saldo: {row.Cells["SaldoTrabajador"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar Vacacion: {this.Name}");
                Mensaje("Error al seleccionar Vacacion: " + ex.Message);
            }
        }
    }
}
