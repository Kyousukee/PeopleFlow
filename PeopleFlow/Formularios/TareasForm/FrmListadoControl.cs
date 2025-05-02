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

namespace PeopleFlow.Formularios.TareasForm
{
    public partial class FrmListadoControl : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public int idTarea = 0;
        public FrmListadoControl()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVTareas.BackgroundColor = Color.White;
            DGVTareas.BorderStyle = BorderStyle.None;
            DGVTareas.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVTareas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVTareas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVTareas.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVTareas.DefaultCellStyle.BackColor = Color.White;
            DGVTareas.DefaultCellStyle.ForeColor = Color.Black;
            DGVTareas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVTareas.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVTareas.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVTareas.GridColor = Color.LightGray; // Color de las líneas de separación

        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarControles()
        {
            List<TareasControlCambio> controles = new List<TareasControlCambio>();
            try
            {
                if (idTarea!=0)
                {
                    controles = new BO.BOTareas().cargarControlTareas(idTarea);
                    DGVTareas.DataSource = controles;

                    DGVTareas.Columns["IdEstadoTarea"].Visible = false;
                    DGVTareas.Columns["IdTarea"].Visible = false;
                    DGVTareas.Columns["IdTipoPago"].Visible = false;
                    DGVTareas.Columns["IdCambioTarea"].HeaderText = "N°";
                    DGVTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGVTareas.Columns[0].Width = 25;

                }
                else
                {
                    Mensaje("Error: No se ha seleccionado una tarea.");
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void FrmListadoControl_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarControles();
        }
    }
}
