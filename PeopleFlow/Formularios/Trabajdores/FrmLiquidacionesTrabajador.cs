using DocumentFormat.OpenXml.Wordprocessing;
using NLog;
using PeopleFlow.BO;
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
    public partial class FrmLiquidacionesTrabajador : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Empleados selectEmpleado = new Empleados();
        public FrmLiquidacionesTrabajador()
        {
            InitializeComponent();
            StyleTable();
        }
        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVLiquidacion.BackgroundColor = System.Drawing.Color.White;
            DGVLiquidacion.BorderStyle = BorderStyle.None;
            DGVLiquidacion.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVLiquidacion.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243); // Azul Material
            DGVLiquidacion.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DGVLiquidacion.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVLiquidacion.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            DGVLiquidacion.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            DGVLiquidacion.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVLiquidacion.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            DGVLiquidacion.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVLiquidacion.GridColor = System.Drawing.Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLiquidacionesTrabajador_Load(object sender, EventArgs e)
        {

            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }

            cargarLiquidaciones();

        }


        public void cargarLiquidaciones()
        {
            List<DTO.Liquidacion> liquidaciones = new List<DTO.Liquidacion>();
            try
            {
                liquidaciones = new BO.BOLiquidaciones().GetLiquidacionByTrabajdor(selectEmpleado.IdEmpleado);
                DGVLiquidacion.DataSource = liquidaciones;

                DGVLiquidacion.Columns["IdLiquidacion"].HeaderText = "N°";
                DGVLiquidacion.Columns["IdContrato"].HeaderText = "N° Contrato";
                DGVLiquidacion.Columns["IdEmpleado"].Visible = false;
                DGVLiquidacion.Columns["IdEmpresa"].Visible = false;
                DGVLiquidacion.Columns["year"].Visible = false;
                DGVLiquidacion.Columns["month"].Visible = false;
                DGVLiquidacion.Columns["DescripcionBonos"].Visible = false;
                DGVLiquidacion.Columns["DescripcionDeducciones"].Visible = false;
                DGVLiquidacion.Columns["DescripcionDeducciones"].Visible = false;
                DGVLiquidacion.Columns["SalarioBase"].DefaultCellStyle.Format = "N0";
                DGVLiquidacion.Columns["Bonificaciones"].DefaultCellStyle.Format = "N0";
                DGVLiquidacion.Columns["Deducciones"].DefaultCellStyle.Format = "N0";
                DGVLiquidacion.Columns["SueldoLiquido"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado liquidacion: {this.Name}");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }


        }

        private void DGVLiquidacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Liquidacion datos = new Liquidacion();
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVLiquidacion.Rows[e.RowIndex];
                    ;
                    datos = (DGVLiquidacion.DataSource as List<DTO.Liquidacion>)[e.RowIndex];

                    if (datos != null)
                    {
                        datos = new BO.BOLiquidaciones().GetLiquidacionById(datos.IdLiquidacion);

                        if (datos.IdLiquidacion != 0)
                        {
                            string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            string rutaArchivo = Path.Combine(rutaCarpeta, "Liquidacion_" + datos.Periodo + "_" + datos.NombreEmpleado + ".pdf");
                            // Si el archivo ya existe, eliminarlo antes de generar el nuevo
                            if (File.Exists(rutaArchivo))
                            {
                                File.Delete(rutaArchivo);
                            }
                            new BO.BOLiquidaciones().GENERARPDFLiquidacion(datos, rutaArchivo);
                        }
                        else
                        {
                            Mensaje("Error al cargar liquidacion.");
                            return;
                        }

                    }
                    else
                    {
                        Mensaje("Debe seleccionar un empleado.");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar liquidacion: {this.Name}");
                Mensaje("Error al seleccionar Empleado: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
