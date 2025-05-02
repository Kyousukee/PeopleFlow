using NLog;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
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
    public partial class FrmListadoFiniquitos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        FiniquitosEmpresa selecFiniquito = new FiniquitosEmpresa();
        public FrmListadoFiniquitos()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVFiniquitos.BackgroundColor = Color.White;
            DGVFiniquitos.BorderStyle = BorderStyle.None;
            DGVFiniquitos.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVFiniquitos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVFiniquitos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVFiniquitos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVFiniquitos.DefaultCellStyle.BackColor = Color.White;
            DGVFiniquitos.DefaultCellStyle.ForeColor = Color.Black;
            DGVFiniquitos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVFiniquitos.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVFiniquitos.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVFiniquitos.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmListadoFiniquitos_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }

            cargarFiniquitos();
        }

        private void cargarFiniquitos()
        {
            List<FiniquitosEmpresa> archivos = new List<FiniquitosEmpresa>();
            try
            {
                archivos = new BO.BOUsuarios().GetFiniquitosEmpresa();

                DGVFiniquitos.DataSource = archivos;
                DGVFiniquitos.Columns["IdEmpleado"].Visible = false;
                DGVFiniquitos.Columns["Usuario"].Visible = false;
                DGVFiniquitos.Columns["IdEmpresa"].Visible = false;
                DGVFiniquitos.Columns["IdTipoFiniquito"].Visible = false;

                DGVFiniquitos.Columns["IdTipoContrato"].Visible = false;
                DGVFiniquitos.Columns["IdPlazo"].Visible = false;
                DGVFiniquitos.Columns["IdTarea"].Visible = false;


                DGVFiniquitos.Columns["idFiniquitos"].HeaderText = "N°";
                DGVFiniquitos.Columns["IdContrato"].HeaderText = "N° Contrato";
                //DGVFiniquitos.Columns["FechaReg"].HeaderText = "Fecha Ingreso";

                DGVFiniquitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                //DGVFiniquitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVFiniquitos.Columns[0].Width = 40;


            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado Finiquitos:: FrmListadoFiniquitos");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void DGVFiniquitos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVFiniquitos.Rows[e.RowIndex];
                    ;
                    selecFiniquito = (DGVFiniquitos.DataSource as List<FiniquitosEmpresa>)[e.RowIndex];

                    // Mostrar los datos del empleado seleccionado (ejemplo)
                    string mensaje = $"Finiquito seleccionado:\n" +
                                     $"ID: {row.Cells["idFiniquitos"].Value}\n" +
                                     $"Contrato: {row.Cells["IdContrato"].Value}\n" +
                                     $"Empleado: {row.Cells["Nombre"].Value + " "+row.Cells["Nombre"].Value}";
                    Mensaje(mensaje);


                    Contrato _contrato = new BO.BOContratos().getContratoTrabajador(selecFiniquito.IdEmpleado);
                    string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string rutaArchivo = Path.Combine(rutaCarpeta, "Finiquito" + DateTime.Now.ToString("ddMMyyyy") + "_" + _contrato.IdContrato + ".pdf");
                    // Si el archivo ya existe, eliminarlo antes de generar el nuevo
                    if (File.Exists(rutaArchivo))
                    {
                        File.Delete(rutaArchivo);
                    }

                    List<TipoFiniquito> lista = new BO.BOContratos().GetTipoFiniquito(); 
                    TipoFiniquito encontrado = lista.FirstOrDefault(x => x.idTipoFiniquito == selecFiniquito.IdTipoFiniquito);


                    DTO.Contrato.Finiquito datos = new DTO.Contrato.Finiquito();
                    datos.idFiniquitos = selecFiniquito.idFiniquitos;
                    datos.IdContrato = _contrato.IdContrato;
                    datos.FechaFiniquito = selecFiniquito.FechaFiniquito;
                    datos.IdTipoFiniquito = selecFiniquito.IdTipoFiniquito;
                    datos.Observacion = selecFiniquito.Observacion;
                    datos.Estado = Convert.ToBoolean(selecFiniquito.Estado);
                    datos.detalleFiniquitos = new BO.BOContratos().GetDetalleFiniquito(selecFiniquito.idFiniquitos);

                    new BO.BOContratos().GENERARPDFFINIQUITO(_contrato, rutaArchivo, datos, encontrado);

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar Finiquito: FrmListadoFiniquitos");
                Mensaje("Error al seleccionar Finiquito: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
