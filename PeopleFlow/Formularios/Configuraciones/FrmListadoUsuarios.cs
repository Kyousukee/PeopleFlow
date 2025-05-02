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
    public partial class FrmListadoUsuarios : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Usuarios Selectusuario = new DTO.Usuarios();
        public FrmListadoUsuarios()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVUsuarios.BackgroundColor = Color.White;
            DGVUsuarios.BorderStyle = BorderStyle.None;
            DGVUsuarios.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVUsuarios.DefaultCellStyle.BackColor = Color.White;
            DGVUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            DGVUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVUsuarios.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVUsuarios.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVUsuarios.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            List<DTO.Usuarios> usuarios = new List<DTO.Usuarios>();
            try
            {
                usuarios = new BO.BOUsuarios().GetUsuariosByEmpresa();
                DGVUsuarios.DataSource = usuarios;

                //DGVUsuarios.Columns["IdBonificacion"].HeaderText = "N°";
                //DGVUsuarios.Columns["IdEmpresa"].Visible = false;
                //DGVUsuarios.Columns["IdTarea"].Visible = false;

                //DGVUsuarios.Columns["Monto"].DefaultCellStyle.Format = "N0";

                // Primero ajusta al contenido
                DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Luego rellena el espacio restante
                DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVUsuarios.Columns[0].Width = 25;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado Usuarios: FrmListadoUsuarios");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void DGVUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVUsuarios.Rows[e.RowIndex];
                    ;
                    Selectusuario = (DGVUsuarios.DataSource as List<DTO.Usuarios>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Usuario seleccionado:\n" +
                                     $"ID: {row.Cells["IdUsuario"].Value}\n" +
                                     $"Nombre: {row.Cells["Nombres"].Value} {row.Cells["Apellidos"].Value}";

                    Mensaje(mensaje);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar Usuario: FrmListadoUsuarios");
                Mensaje("Error al seleccionar Usuario: " + ex.Message);
            }
        }
    }
}
