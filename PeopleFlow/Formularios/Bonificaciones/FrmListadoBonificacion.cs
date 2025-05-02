

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

namespace PeopleFlow.Formularios.Bonificaciones
{
    public partial class FrmListadoBonificacion : Form
    {
        public DTO.Bonificaciones selectBonificacion = new DTO.Bonificaciones();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmListadoBonificacion()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVBonificaciones.BackgroundColor = Color.White;
            DGVBonificaciones.BorderStyle = BorderStyle.None;
            DGVBonificaciones.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVBonificaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVBonificaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVBonificaciones.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVBonificaciones.DefaultCellStyle.BackColor = Color.White;
            DGVBonificaciones.DefaultCellStyle.ForeColor = Color.Black;
            DGVBonificaciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVBonificaciones.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVBonificaciones.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVBonificaciones.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoBonificacion_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarBonificaciones();
        }

        public void CargarBonificaciones()
        {
            List<DTO.Bonificaciones> bonificaciones = new List<DTO.Bonificaciones>();
            try
            {
                bonificaciones = new BO.BOBeneficios().cargarBeneficios();
                DGVBonificaciones.DataSource = bonificaciones;

                DGVBonificaciones.Columns["IdBonificacion"].HeaderText = "N°";
                DGVBonificaciones.Columns["IdEmpresa"].Visible = false;
                DGVBonificaciones.Columns["IdTarea"].Visible = false;

                DGVBonificaciones.Columns["Monto"].DefaultCellStyle.Format = "N0";

                // Primero ajusta al contenido
                DGVBonificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Luego rellena el espacio restante
                DGVBonificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVBonificaciones.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado: FrmListadoBonificacion");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void DGVBonificaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVBonificaciones.Rows[e.RowIndex];
                    ;
                    selectBonificacion = (DGVBonificaciones.DataSource as List<DTO.Bonificaciones>)[e.RowIndex];

                    selectBonificacion.Asignados = new BO.BOBeneficios().cargarBeneficiosEmpleados(selectBonificacion.IdBonificacion);

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Bonificacion seleccionada:\n" +
                                     $"ID: {row.Cells["IdBonificacion"].Value}\n" +
                                     $"Nombre: {row.Cells["Descripcion"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar Bonificacion: FrmListadoBonificacion");
                Mensaje("Error al seleccionar Bonificacion: " + ex.Message);
            }
        }
    }
}
