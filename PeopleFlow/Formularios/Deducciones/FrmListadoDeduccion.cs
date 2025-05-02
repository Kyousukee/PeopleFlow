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

namespace PeopleFlow.Formularios.Deducciones
{
    public partial class FrmListadoDeduccion : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Deducciones selectDeduccion = new DTO.Deducciones();
        public FrmListadoDeduccion()
        {
            InitializeComponent();
            StyleTable();
        }
        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVDeducciones.BackgroundColor = Color.White;
            DGVDeducciones.BorderStyle = BorderStyle.None;
            DGVDeducciones.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVDeducciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVDeducciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVDeducciones.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVDeducciones.DefaultCellStyle.BackColor = Color.White;
            DGVDeducciones.DefaultCellStyle.ForeColor = Color.Black;
            DGVDeducciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVDeducciones.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVDeducciones.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVDeducciones.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoDeduccion_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarDeducciones();
        }

        public void CargarDeducciones()
        {
            List<DTO.Deducciones> deducciones = new List<DTO.Deducciones>();
            try
            {
                deducciones = new BO.BODeduccion().cargarDeducciones();
                DGVDeducciones.DataSource = deducciones;


                DGVDeducciones.Columns["IdDeduccion"].HeaderText = "N°";
                DGVDeducciones.Columns["IdEmpresa"].Visible = false;
                DGVDeducciones.Columns["Monto"].DefaultCellStyle.Format = "N0";

                // Primero ajusta al contenido
                DGVDeducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Luego rellena el espacio restante
                DGVDeducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVDeducciones.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void DGVDeducciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVDeducciones.Rows[e.RowIndex];
                    ;
                    selectDeduccion = (DGVDeducciones.DataSource as List<DTO.Deducciones>)[e.RowIndex];

                    selectDeduccion.Asignados = new BO.BODeduccion().cargarBeneficiosEmpleados(selectDeduccion.IdDeduccion);

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Deduccion seleccionada:\n" +
                                     $"ID: {row.Cells["IdDeduccion"].Value}\n" +
                                     $"Nombre: {row.Cells["Descripcion"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar Deduccion: {this.Name}");
                Mensaje("Error al seleccionar Deduccion: " + ex.Message);
            }
        }
    }
}
