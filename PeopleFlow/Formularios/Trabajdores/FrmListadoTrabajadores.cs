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

namespace PeopleFlow.Formularios.Trabajdores
{
    public partial class FrmListadoTrabajadores : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Empleados selectEmpleado = new Empleados();
        public FrmListadoTrabajadores()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVEmpleados.BackgroundColor = Color.White;
            DGVEmpleados.BorderStyle = BorderStyle.None;
            DGVEmpleados.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVEmpleados.DefaultCellStyle.BackColor = Color.White;
            DGVEmpleados.DefaultCellStyle.ForeColor = Color.Black;
            DGVEmpleados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVEmpleados.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVEmpleados.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVEmpleados.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoTrabajadores_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarTrabajadores();
        }

        public void cargarTrabajadores()
        {
            List<Empleados> trabajadores = new List<Empleados>();
            try
            {
                trabajadores = new BO.BOEmpleados().cargarTrabajadores();
                DGVEmpleados.DataSource = trabajadores;
                //DGVEmpleados.Columns["IdBonificacion"].HeaderText = "N°";
                DGVEmpleados.Columns["IdEmpleado"].Visible = false;
                DGVEmpleados.Columns["IdRol"].Visible = false;
                DGVEmpleados.Columns["IdEmpresa"].Visible = false;
                DGVEmpleados.Columns["Empresa"].Visible = false;
                DGVEmpleados.Columns["IdTareaEmpl"].Visible = false;
                DGVEmpleados.Columns["Idtarea"].Visible = false;
                DGVEmpleados.Columns["IdEstadoCivil"].Visible = false;
                DGVEmpleados.Columns["EstadoCivil"].Visible = false;
                DGVEmpleados.Columns["IdSalud"].Visible = false;
                DGVEmpleados.Columns["Salud"].Visible = false;
                DGVEmpleados.Columns["IdAfp"].Visible = false;
                DGVEmpleados.Columns["AFP"].Visible = false;
                DGVEmpleados.Columns["Contrato"].Visible = false;
                DGVEmpleados.Columns["IdContrato"].Visible = false;
                DGVEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado trabajadores: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }


        }

        private void DGVEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVEmpleados.Rows[e.RowIndex];
;
                    selectEmpleado = (DGVEmpleados.DataSource as List<Empleados>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Empleado seleccionado:\n" +
                                     $"ID: {row.Cells["IdEmpleado"].Value}\n" +
                                     $"Nombre: {row.Cells["Nombre"].Value}\n" +
                                     $"RUT: {row.Cells["RUT"].Value}";

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
    }
}
