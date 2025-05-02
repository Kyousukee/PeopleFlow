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

namespace PeopleFlow.Formularios.Configuraciones
{
    public partial class FrmInformaciones : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmInformaciones()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVAFP.BackgroundColor = Color.White;
            DGVAFP.BorderStyle = BorderStyle.None;
            DGVAFP.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVAFP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVAFP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVAFP.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVAFP.DefaultCellStyle.BackColor = Color.White;
            DGVAFP.DefaultCellStyle.ForeColor = Color.Black;
            DGVAFP.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVAFP.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVAFP.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVAFP.GridColor = Color.LightGray; // Color de las líneas de separación


            DGVFamiliar.BackgroundColor = Color.White;
            DGVFamiliar.BorderStyle = BorderStyle.None;
            DGVFamiliar.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVFamiliar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVFamiliar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVFamiliar.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVFamiliar.DefaultCellStyle.BackColor = Color.White;
            DGVFamiliar.DefaultCellStyle.ForeColor = Color.Black;
            DGVFamiliar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVFamiliar.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVFamiliar.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVFamiliar.GridColor = Color.LightGray; // Color de las líneas de separación
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmInformaciones_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarPrevision();
            CargaFamiliar();
        }

        private void CargarPrevision()
        {
            try
            {
                List<Afp> afps = new BO.BOLiquidaciones().GetAFPAll();
                DGVAFP.DataSource = afps;
                DGVAFP.Columns["idAFP"].HeaderText = "N°";
                DGVAFP.Columns["Estado"].Visible = false;
                //DGVAFP.Columns["IdTarea"].Visible = false;

                //DGVUsuarios.Columns["Monto"].DefaultCellStyle.Format = "N0";
                // Primero ajusta al contenido
                DGVAFP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Luego rellena el espacio restante
                DGVAFP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVAFP.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al listado de Prevision: FrmInformaciones");
                Mensaje("Error al listado de Prevision: " + ex.Message);
            }
        }

        private void CargaFamiliar()
        {
            try
            {
                List<ValoresCargas> valoresCargas = new List<ValoresCargas>();
                valoresCargas = new DAO.EmpleadosDAO().GetValoresCargas();
                DGVFamiliar.DataSource = valoresCargas;
                DGVFamiliar.Columns["idValoresCargas"].HeaderText = "N°";
                DGVFamiliar.Columns["ValorHijos"].HeaderText = "Valor Hijos";
                DGVFamiliar.Columns["ValorConyuge"].HeaderText = "Valor Conyuge";
                DGVFamiliar.Columns["ValorDiscapacidad"].HeaderText = "Valor Hijo con Discapacidad";
                DGVFamiliar.Columns["Tope"].HeaderText = "Tope Sueldo Base";
                DGVFamiliar.Columns["ValorHijos"].DefaultCellStyle.Format = "N0";
                DGVFamiliar.Columns["ValorConyuge"].DefaultCellStyle.Format = "N0";
                DGVFamiliar.Columns["ValorDiscapacidad"].DefaultCellStyle.Format = "N0";
                DGVFamiliar.Columns["Tope"].DefaultCellStyle.Format = "N0";
                DGVFamiliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DGVFamiliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVFamiliar.Columns[0].Width = 25;


                
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al listado de ValoresCargas: FrmInformaciones");
                throw;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
