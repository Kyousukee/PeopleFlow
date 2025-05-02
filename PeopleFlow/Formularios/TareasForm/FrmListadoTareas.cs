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
    public partial class ListadoTareas : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Tareas selectTarea = new Tareas();
        public ListadoTareas()
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

        private void FrmListadoTareas_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarTareas();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTareas()
        {
            List<Tareas> trabajadores = new List<Tareas>();
            try
            {
                trabajadores = new BO.BOTareas().cargarTareasALL();
                DGVTareas.DataSource = trabajadores;
                DGVTareas.Columns["IdTarea"].HeaderText = "N°";
                DGVTareas.Columns["IdEstadoTarea"].Visible = false;
                DGVTareas.Columns["IdTipoPago"].Visible = false;
                DGVTareas.Columns["IdJornada"].Visible = false;
                DGVTareas.Columns["Valor"].DefaultCellStyle.Format = "N0";
                // Primero ajusta al contenido
                DGVTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                DGVTareas.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }


        }

        private void DGVTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVTareas.Rows[e.RowIndex];
                    ;
                    selectTarea = (DGVTareas.DataSource as List<Tareas>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Tarea seleccionada:\n" +
                                     $"ID: {row.Cells["IdTarea"].Value}\n" +
                                     $"Nombre: {row.Cells["Titulo"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar Tarea: {this.Name}");
                Mensaje("Error al seleccionar Tarea: " + ex.Message);
            }
        }
    }
}
