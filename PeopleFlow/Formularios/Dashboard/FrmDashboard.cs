using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Tareas.Tareas;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.Contratos;
using PeopleFlow.Formularios.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace PeopleFlow.Formularios
{
    public partial class FrmDashboard : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        List<TareasConEmpleados> tareasConEmpleados = new List<TareasConEmpleados>();
        TareasConEmpleados SelectEmplAsig = new TareasConEmpleados();
        public FrmDashboard()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false; // Permite cambiar el header
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            dataGridView1.GridColor = Color.LightGray; // Color de las líneas de separación

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

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarTrabajadores();
            cargarTareasconEmpleados();
            cargarTotales();
        }

        private void cargarTareasconEmpleados()
        {

            try
            {
                tareasConEmpleados = new BO.BOTareas().cargarTareasConEmpleados();
                // Crear columna de imagen
                // Verificar si la columna "ContratoImagen" ya existe
                if (!DGVTareas.Columns.Contains("ContratoImagen"))
                {
                    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                    imgColumn.Name = "ContratoImagen";
                    imgColumn.HeaderText = "";
                    imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen correctamente
                    DGVTareas.Columns.Add(imgColumn);
                    DGVTareas.DataSource = tareasConEmpleados;
                    DGVTareas.RowHeadersVisible = false;

                    //DGVTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    DGVTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGVTareas.Columns[0].Width = 1;
                    DGVTareas.Columns[19].Width = 1;
                    DGVTareas.Columns["Texto2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else
                {
                    DGVTareas.DataSource = tareasConEmpleados;
                }
                // Agregar la lista de empleados al DataGridView


                DGVTareas.DataBindingComplete += (sender, e) =>
                {
                    foreach (DataGridViewRow row in DGVTareas.Rows)
                    {
                        string contrato = row.Cells["EstadoDia"].Value?.ToString();

                        if (contrato == "SI")
                        {
                            row.Cells["ContratoImagen"].Value = Properties.Resources.circuloVerde; // Imagen verde
                        }
                        else
                        {
                            row.Cells["ContratoImagen"].Value = Properties.Resources.circuloRojo; // Imagen roja
                        }
                    }
                };

                DGVTareas.Columns["IdTarea"].Visible = false;
                DGVTareas.Columns["Descripcion"].Visible = false;
                DGVTareas.Columns["FechaAsignacion"].Visible = false;
                DGVTareas.Columns["FechaFinalizacion"].Visible = false;
                DGVTareas.Columns["IdEstadoTarea"].Visible = false;
                DGVTareas.Columns["IdTipoPago"].Visible = false;
                DGVTareas.Columns["Valor"].Visible = false;
                DGVTareas.Columns["FechaModificacion"].Visible = false;
                DGVTareas.Columns["IdJornada"].Visible = false;
                DGVTareas.Columns["IdEmpresa"].Visible = false;
                DGVTareas.Columns["Pago"].Visible = false;
                DGVTareas.Columns["Estado"].Visible = false;
                DGVTareas.Columns["EstadoDia"].Visible = false;
                DGVTareas.Columns["TareasRegistradasHoy"].Visible = false;
                DGVTareas.Columns["TareasFaltantes"].Visible = false;
                DGVTareas.Columns["Titulo"].Visible = false;
                DGVTareas.Columns["TotalEmpleados"].Visible = false;

                //tareasConEmpleados = null;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar tareas con trabajadores: FrmDashboard");
                Mensaje("Error al cargar tareas con trabajadores: " + ex.Message);
            }
        }

        private void cargarTotales()
        {
            try
            {
                if (tareasConEmpleados != null)
                {
                    List<DTO.TareasDTO.Tareas> tareas = new BO.BOTareas().cargarTareas();

                    totalTareas.Text = tareas.Count.ToString();
                    tareasActivas.Text = tareas.Where(o => o.IdEstadoTarea == 2).Count().ToString();


                    List<Empleados> empleados = new BO.BOEmpleados().cargarTrabajadores();

                    TotalTrabajadores.Text = empleados.Count.ToString();
                    trabajadoresActivos.Text = empleados.Where(o => o.Estado == true).Count().ToString();

                    totHoy.Text = tareasConEmpleados.Sum(o => o.TotalEmpleados).ToString();
                    totIng.Text = tareasConEmpleados.Sum(o => o.TareasRegistradasHoy).ToString();

                    if (Convert.ToInt32(totHoy.Text) <= Convert.ToInt32(totIng.Text))
                    {
                        pictureBox4.Visible = true;
                    }
                    else
                    {
                        pictureBox4.Visible = false;
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar totales: FrmDashboard");
                Mensaje("Error al cargar totales: " + ex.Message);
            }
        }

        

        

        private void CargarTrabajadores()
        {
            List<Empleados> emp = new List<Empleados>();
            try
            {
                emp = new BO.BOEmpleados().cargarTrabajadoresAll();

                // Crear columna de imagen
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "ContratoImagen";
                imgColumn.HeaderText = "";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen correctamente
                dataGridView1.Columns.Add(imgColumn);
                dataGridView1.RowTemplate.Height = 20; // Ajusta según el tamaño deseado
                // Agregar la lista de empleados al DataGridView
                dataGridView1.DataSource = emp;
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].Width = 1;
                // Asegúrate de que el DataGridView ya tiene los datos cargados
                dataGridView1.DataBindingComplete += (sender, e) =>
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string contrato = row.Cells["Contrato"].Value?.ToString();

                        if (contrato == "SI")
                        {
                            row.Cells["ContratoImagen"].Value = Properties.Resources.circuloVerde; // Imagen verde
                        }
                        else if (contrato == "Pronto")
                        {
                            row.Cells["ContratoImagen"].Value = Properties.Resources.circuloNaranja; // Imagen naranja
                        }
                        else
                        {
                            row.Cells["ContratoImagen"].Value = Properties.Resources.circuloRojo; // Imagen roja
                        }
                    }
                };

                dataGridView1.Columns["IdEmpleado"].Visible = false;
                dataGridView1.Columns["FechaNacimiento"].Visible = false;
                dataGridView1.Columns["Telefono"].Visible = false;
                dataGridView1.Columns["Correo"].Visible = false;
                dataGridView1.Columns["Direccion"].Visible = false;
                dataGridView1.Columns["FechaIngreso"].Visible = false;
                dataGridView1.Columns["Estado"].Visible = false;
                dataGridView1.Columns["IdRol"].Visible = false;
                dataGridView1.Columns["Cargo"].Visible = false;
                dataGridView1.Columns["IdEmpresa"].Visible = false;
                dataGridView1.Columns["Empresa"].Visible = false;
                dataGridView1.Columns["IdTareaEmpl"].Visible = false;
                dataGridView1.Columns["Idtarea"].Visible = false;
                dataGridView1.Columns["Nacionalidad"].Visible = false;
                dataGridView1.Columns["Profesion"].Visible = false;
                dataGridView1.Columns["IdEstadoCivil"].Visible = false;
                dataGridView1.Columns["EstadoCivil"].Visible = false;
                dataGridView1.Columns["Banco"].Visible = false;
                dataGridView1.Columns["TipoCuenta"].Visible = false;
                dataGridView1.Columns["NumeroCuenta"].Visible = false;
                dataGridView1.Columns["IdSalud"].Visible = false;
                dataGridView1.Columns["Salud"].Visible = false;
                dataGridView1.Columns["IdAfp"].Visible = false;
                dataGridView1.Columns["AFP"].Visible = false;
                dataGridView1.Columns["Contrato"].Visible = false;
                dataGridView1.Columns["IdContrato"].Visible = false;

                emp = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar trabajadores: FrmDashboard");
                Mensaje("Error al cargar trabajadores: " + ex.Message);

            }
        }

        private Image RedimensionarImagen(Image img, int width, int height)
        {
            Bitmap nuevaImagen = new Bitmap(img, new Size(width, height));
            return nuevaImagen;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Evitar encabezados
            {
                string contrato = dataGridView1.Rows[e.RowIndex].Cells["Contrato"].Value?.ToString();

                string mensaje = contrato switch
                {
                    "SI" => "Contrato activo",
                    "Pronto" => "Contrato próximo a vencer",
                    "NO" => "No tiene contrato",
                    _ => ""
                };

                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = mensaje;
            }
        }

        private void DGVTareas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Evitar encabezados
            {
                string contrato = DGVTareas.Rows[e.RowIndex].Cells["EstadoDia"].Value?.ToString();

                string mensaje = contrato switch
                {
                    "SI" => "Tareas Completadas !!",
                    "NO" => "Tareas No Ingresadas Completamente !!",
                    _ => ""
                };

                DGVTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = mensaje;
            }
        }

        private void DGVTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = DGVTareas.Rows[e.RowIndex];
                    SelectEmplAsig = (DGVTareas.DataSource as List<TareasConEmpleados>)[e.RowIndex];

                    btnIngresar.Enabled = true;

                    if (SelectEmplAsig.IdTipoPago == 1 || SelectEmplAsig.IdTipoPago == 2 || SelectEmplAsig.IdTipoPago == 5)
                    {
                        btnIngresar.Text = "Registro Actividades de Trabajador";
                    }

                    if (SelectEmplAsig.IdTipoPago == 3 || SelectEmplAsig.IdTipoPago == 4)
                    {
                        btnIngresar.Text = "Registro Asistencia de Trabajador";
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar Tarea: FrmDashboard");
                Mensaje("Error al seleccionar Tarea: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectEmplAsig.TotalEmpleados == 0)
                {
                    Mensaje("Tarea no contiene trabajadores asignados.");
                }
                else
                {
                    
                    if (SelectEmplAsig.IdTipoPago == 1 || SelectEmplAsig.IdTipoPago == 2 || SelectEmplAsig.IdTipoPago == 5)
                    {
                        FrmIngresoActividad frmShow = new FrmIngresoActividad();
                        frmShow.Tarea = SelectEmplAsig;
                        frmShow.ShowDialog();
                        if (frmShow.Save == true)
                        {
                            cargarTareasconEmpleados();
                            cargarTotales();
                        }
                    }
                    else
                    {
                        FrmIngresoAsistencia frmShow = new FrmIngresoAsistencia();
                        frmShow.Tarea = SelectEmplAsig;
                        frmShow.ShowDialog();
                        if (frmShow.Save == true)
                        {
                            cargarTareasconEmpleados();
                            cargarTotales();
                        }
                    }

                    

                }
                
                //if (frmShow.selecCtontrato.IdContrato != 0)
                //{
                //    cboEmpleados.SelectedValue = frmShow.selecCtontrato.IdEmpleado;
                //    cargarContrato(frmShow.selecCtontrato);
                //}

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar formulario de ingreso de actividades: FrmDashboard");
                Mensaje("Error al cargar formulario de ingreso de actividades: " + ex.Message);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoRegistrosEmpleados frmShow = new FrmListadoRegistrosEmpleados();
                //frmShow.Tarea = SelectEmplAsig;
                frmShow.ShowDialog();
                //if (frmShow.selecCtontrato.IdContrato != 0)
                //{
                //    cboEmpleados.SelectedValue = frmShow.selecCtontrato.IdEmpleado;
                //    cargarContrato(frmShow.selecCtontrato);
                //}

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar formulario de listado de actividades: FrmDashboard");
                Mensaje("Error al cargar formulario de listado de actividades: " + ex.Message);
            }
        }
    }
}
