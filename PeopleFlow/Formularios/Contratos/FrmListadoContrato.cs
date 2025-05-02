using NLog;
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

namespace PeopleFlow.Formularios.Contratos
{
    public partial class FrmListadoContrato : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Contrato.Contrato selecCtontrato = new DTO.Contrato.Contrato();
        public FrmListadoContrato()
        {
            InitializeComponent();
            StyleTable();
        }
        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVContratos.BackgroundColor = Color.White;
            DGVContratos.BorderStyle = BorderStyle.None;
            DGVContratos.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVContratos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVContratos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVContratos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVContratos.DefaultCellStyle.BackColor = Color.White;
            DGVContratos.DefaultCellStyle.ForeColor = Color.Black;
            DGVContratos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVContratos.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVContratos.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVContratos.GridColor = Color.LightGray; // Color de las líneas de separación

        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoContrato_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarContratos();
        }

        public void cargarContratos()
        {
            List<DTO.Contrato.Contrato> contratos = new List<DTO.Contrato.Contrato>();
            try
            {
                contratos = new BO.BOContratos().getContratos();
                DGVContratos.DataSource = contratos;
                DGVContratos.Columns["IdEmpresa"].Visible = false;
                DGVContratos.Columns["IdTarea"].Visible = false;
                DGVContratos.Columns["IdPlazo"].Visible = false;
                DGVContratos.Columns["IdTipoContrato"].Visible = false;
                DGVContratos.Columns["IdEmpleado"].Visible = false;
                DGVContratos.Columns["IdContrato"].HeaderText = "N°";
                DGVContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                DGVContratos.Columns[0].Width = 10;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado contrato: FrmListadoContrato");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }


        }

        private void DGVContratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVContratos.Rows[e.RowIndex];
                    ;
                    selecCtontrato = (DGVContratos.DataSource as List<DTO.Contrato.Contrato>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Contrato seleccionado:\n" +
                                     $"ID: {row.Cells["IdContrato"].Value}\n" +
                                     $"Periodo: {row.Cells["Nombre"].Value}\n" +
                                     $"Emeplado: {row.Cells["Rut"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar contrato: FrmListadoContrato");
                Mensaje("Error al seleccionar contrato: " + ex.Message);
            }
        }
    }
}
