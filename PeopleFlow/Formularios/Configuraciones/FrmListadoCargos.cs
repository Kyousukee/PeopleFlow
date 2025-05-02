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

namespace PeopleFlow.Formularios.Configuraciones
{
    public partial class FrmListadoCargos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Roles Selectrool = new DTO.Roles();
        public FrmListadoCargos()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVCargos.BackgroundColor = Color.White;
            DGVCargos.BorderStyle = BorderStyle.None;
            DGVCargos.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVCargos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVCargos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVCargos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVCargos.DefaultCellStyle.BackColor = Color.White;
            DGVCargos.DefaultCellStyle.ForeColor = Color.Black;
            DGVCargos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVCargos.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVCargos.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVCargos.GridColor = Color.LightGray; // Color de las líneas de separación

        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmListadoCargos_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarRoles();
        }

        public void CargarRoles()
        {
            List<DTO.Roles> roles = new List<DTO.Roles>();
            try
            {
                roles = new BO.BOCargo().GetRolesByEmpresa();
                DGVCargos.DataSource = roles;

                DGVCargos.Columns["IdRol"].HeaderText = "N°";
                //DGVUsuarios.Columns["IdEmpresa"].Visible = false;
                //DGVUsuarios.Columns["IdTarea"].Visible = false;

                DGVCargos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Primero ajusta al contenido
                DGVCargos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Luego rellena el espacio restante
                DGVCargos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVCargos.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado Roles:: FrmListadoCargos");
                Mensaje("Error al cargar Listado Roles: " + ex.Message);
            }
        }

        private void DGVCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVCargos.Rows[e.RowIndex];
                    ;
                    Selectrool = (DGVCargos.DataSource as List<DTO.Roles>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Rol seleccionado:\n" +
                                     $"ID: {row.Cells["IdRol"].Value}\n" +
                                     $"Nombre: {row.Cells["Descripcion"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar Cargo: FrmListadoCargos");
                Mensaje("Error al seleccionar Cargo: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
