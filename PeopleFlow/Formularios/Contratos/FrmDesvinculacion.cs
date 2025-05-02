using DocumentFormat.OpenXml.Wordprocessing;
using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFlow.Formularios.Contratos
{
    public partial class FrmDesvinculacion : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Contrato.Contrato _contrato = new DTO.Contrato.Contrato();
        private List<Liquidacion> liquidaciones = new List<Liquidacion>();
        private DTO.Vacaciones _vacaciones = new DTO.Vacaciones();
        private bool cargando = true; // Variable de control
        public FrmDesvinculacion()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmDesvinculacion_Load(object sender, EventArgs e)
        {
            cargando = true;
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarDatosContrato();
            cargarControles();
            cargarEstados();
            CargarTipoFiniquito();
            CargarTipoDetalleFiniquito();
            CargarFiniquito();
            cargarLiquidaciones();
            cargarUltimaVacacion();
            listView1.View = System.Windows.Forms.View.Details;
            listView1.Columns.Add("Detalle", 200);
            listView1.Columns.Add("Monto", 100);
            cargando = false;
        }

        private void cargarUltimaVacacion()
        {
            try
            {
                _vacaciones = new BO.BOVacaciones().GetVacacionesByIDUltima(_contrato.IdEmpleado);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar ultimas vacaciones registrada: FrmDesvinculacion");
                Mensaje("Error al cargar ultimas vacaciones registrada: " + ex.Message);
            }
        }

        private void cargarLiquidaciones()
        {
            try
            {
                liquidaciones = new BO.BOLiquidaciones().GetLiquidacionesByContrato(_contrato.IdContrato);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar liquidaciones: FrmDesvinculacion");
                Mensaje("Error al cargar liquidaciones: " + ex.Message);
            }
        }

        private void CargarFiniquito()
        {
            try
            {
                DTO.Contrato.Finiquito datos = new BO.BOContratos().GetFiniquito(_contrato.IdContrato);
                if (datos != null)
                {
                    CargarFiniquito(datos);
                }
                else
                {
                    btnIngresar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar finiquito: FrmDesvinculacion");
                Mensaje("Error al cargar finiquito: " + ex.Message);
            }
        }

        private void CargarTipoFiniquito()
        {

            try
            {
                List<TipoFiniquito> tipoFiniquitos = new BO.BOContratos().GetTipoFiniquito();

                tipoFiniquitos.Add(new TipoFiniquito { idTipoFiniquito = 0, Descripcion = "Seleccionar..." });
                tipoFiniquitos = tipoFiniquitos.OrderBy(x => x.idTipoFiniquito).ToList();

                cboTipoFiniquito.DataSource = tipoFiniquitos;
                cboTipoFiniquito.DisplayMember = "Descripcion";
                cboTipoFiniquito.ValueMember = "idTipoFiniquito";

                //tareas = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar tipo finiquito: FrmDesvinculacion");
                Mensaje("Error al cargar tipo finiquito: " + ex.Message);

            }
        }

        private void CargarTipoDetalleFiniquito()
        {

            try
            {
                List<FiniquitoTipoDetalle> tipoDetalleFiniquitos = new BO.BOContratos().GetTipoDetalleFiniquito();

                tipoDetalleFiniquitos.Add(new FiniquitoTipoDetalle { idFiniquitosTipoDetalle = 0, Descripcion = "Seleccionar..." });
                tipoDetalleFiniquitos = tipoDetalleFiniquitos.OrderBy(x => x.idFiniquitosTipoDetalle).ToList();

                cboTipoDetalle.DataSource = tipoDetalleFiniquitos;
                cboTipoDetalle.DisplayMember = "Descripcion";
                cboTipoDetalle.ValueMember = "idFiniquitosTipoDetalle";

                //tareas = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar tipo de detalle: FrmDesvinculacion");
                Mensaje("Error al cargar tipo de detalle: " + ex.Message);

            }
        }

        private void cargarDatosContrato()
        {
            txtID.Text = _contrato.IdContrato.ToString();
            txtrut.Text = _contrato.Rut;
            txtTrabajador.Text = _contrato.Nombre + " " + _contrato.Apellido;
            txtcargo.Text = _contrato.Cargo;
            txttipocontrato.Text = _contrato.TipoContrato;
            txtfechaInicio.Text = _contrato.FechaInicio.ToString("dd/MM/yyyy");
            txtrut.Text = _contrato.Rut.Substring(0, _contrato.Rut.Length - 2);
            txtdv.Text = _contrato.Rut.Substring(_contrato.Rut.Length - 1, 1);
        }
        private void cargarControles()
        {
            dtpFFin.Value = DateTime.Now;
            //dttFIngreso.MinDate = DateTime.Now.AddDays(-1);

        }

        private void cargarEstados()
        {
            var estados = new List<Estado>
            {
                new Estado { Id = 1, Nombre = "Activo" },
                new Estado { Id = 0, Nombre = "Inactivo" }
            };

            cboEstado.DataSource = estados;
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "Id";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipoDetalle_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cargando) return;

                int Seleccion = Convert.ToInt32(cboTipoDetalle.SelectedValue);

                switch (Seleccion)
                {
                    case 1:
                        txtDetallenombre.Enabled = false;
                        txtDetallenombre.Text = cboTipoDetalle.Text.ToString();
                        txtMonto.Text = CalculoIndemnizacionAños().ToString("F0");
                        txtMonto.Enabled = true;
                        break;
                    case 2:
                        txtDetallenombre.Enabled = false;
                        txtDetallenombre.Text = cboTipoDetalle.Text.ToString();
                        txtMonto.Text = CalculoIndemnizacionTermino().ToString("F0");
                        txtMonto.Enabled = true;
                        break;
                    case 3:
                        txtDetallenombre.Enabled = false;
                        txtDetallenombre.Text = cboTipoDetalle.Text.ToString();
                        txtMonto.Text = CalculoVacaciones().ToString("F0");
                        txtMonto.Enabled = true;
                        break;
                    case 4:
                        txtDetallenombre.Enabled = false;
                        txtDetallenombre.Text = cboTipoDetalle.Text.ToString();
                        txtMonto.Text = CalculoDiasnoPagados().ToString("F0");
                        txtMonto.Enabled = true;
                        break;
                    case 5:
                        txtDetallenombre.Enabled = false;
                        txtDetallenombre.Text = cboTipoDetalle.Text.ToString();
                        txtMonto.Text = CalculoTareasnoPagados().ToString("F0");
                        txtMonto.Enabled = true;
                        break;
                    case 7:
                        txtDetallenombre.Enabled = false;
                        txtDetallenombre.Text = cboTipoDetalle.Text.ToString();
                        txtMonto.Text = CalculoMesAviso().ToString("F0");
                        txtMonto.Enabled = true;
                        break;
                    case 6:
                        txtDetallenombre.Text = "";
                        txtMonto.Text = "";
                        txtMonto.Enabled = true;
                        txtDetallenombre.Enabled = true;
                        break;
                    case 0:
                        txtDetallenombre.Text = "";
                        txtMonto.Text = "";
                        txtMonto.Enabled = false;
                        txtDetallenombre.Enabled = false;
                        break;
                    default:
                        txtDetallenombre.Text = "";
                        txtMonto.Text = "";
                        txtMonto.Enabled = false;
                        txtDetallenombre.Enabled = false;
                        return;

                }







            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error ingresar el detalle de finiquito: FrmDesvinculacion");
                Mensaje("Error ingresar el detalle de finiquito: " + ex.Message);

            }
        }

        private decimal CalculoIndemnizacionAños()
        {
            decimal Valor = 0;
            decimal SueldoBase = 0;

            if (liquidaciones.Count > 0)
            {
                SueldoBase = liquidaciones.Average(l => l.SalarioBase);

                DateTime fechaInicio = _contrato.FechaInicio;
                DateTime fechaTermino = dtpFFin.Value;

                // Calcular años completos trabajados
                int aniosTrabajados = fechaTermino.Year - fechaInicio.Year;

                // Si no ha cumplido un año completo, no se indemniza por años
                if (fechaTermino.Month < fechaInicio.Month ||
                   (fechaTermino.Month == fechaInicio.Month && fechaTermino.Day < fechaInicio.Day))
                {
                    aniosTrabajados--;
                }

                // El tope legal en Chile es 11 años indemnizados (11 sueldos)
                int topeLegal = 11;

                // Aplicar tope legal
                aniosTrabajados = Math.Min(aniosTrabajados, topeLegal);

                if (aniosTrabajados > 0)
                {
                    Valor = SueldoBase * aniosTrabajados;
                }
            }

            return Valor;
        }

        private decimal CalculoIndemnizacionTermino()
        {
            decimal Valor = 0;
            decimal SueldoBase = 0;

            if (liquidaciones.Count > 0)
            {
                SueldoBase = liquidaciones.Average(l => l.SalarioBase);
                DateTime fechaInicio = _contrato.FechaInicio;
                DateTime fechaTermino = dtpFFin.Value;

                // Calcular total de meses trabajados (redondeado hacia abajo)
                int totalMeses = ((fechaTermino.Year - fechaInicio.Year) * 12) + fechaTermino.Month - fechaInicio.Month;

                if (fechaTermino.Day < fechaInicio.Day)
                {
                    totalMeses--; // aún no completa el mes actual
                }

                if (totalMeses < 0) totalMeses = 0;

                int diasPorMes = totalMeses >= 12 ? 6 : 5;

                // Cálculo de indemnización
                Valor = (SueldoBase / 30) * diasPorMes * totalMeses;
            }

            return Valor;
        }


        private decimal CalculoVacaciones()
        {
            decimal Valor = 0;

            decimal SueldoBase = 0;

            if (_vacaciones !=null && liquidaciones.Count >0)
            {
                SueldoBase = liquidaciones.Average(l => l.SalarioBase);
                if (_vacaciones.SaldoTrabajador > 0)
                {
                    Valor = ((decimal)_vacaciones.SaldoTrabajador / 30) * SueldoBase;
                }
            }

            return Valor;
        }

        private decimal CalculoDiasnoPagados()
        {
            decimal Valor = 0;

            decimal ValorDIA = 0;

            List<TareasEmpleadoAsistencia> asistencias = new BO.BOTareas().GetAsistenciasNoPagadas(_contrato.IdEmpleado, Convert.ToInt32(liquidaciones[0].month) + 1);

            if (asistencias.Count > 0)
            {

                ValorDIA = new BO.BOTareas().cargarTareaByID(_contrato.IdTarea).Valor;

                Valor = ValorDIA * asistencias.Count;

            }
                
            return Valor;
        }

        private decimal CalculoMesAviso()
        {
            decimal Valor = 0;

            decimal SueldoBase = 0;

            if (liquidaciones.Count > 0)
            {
                SueldoBase = liquidaciones.Average(l => l.SalarioBase);
                Valor = SueldoBase;
            }

            return Valor;
        }

        private decimal CalculoTareasnoPagados()
        {
            decimal Valor = 0;

            decimal ValorDIA = 0;

            List<TareasEmpleadosRegistros> tareas = new BO.BOTareas().GetTareasNoPagadas(_contrato.IdEmpleado, Convert.ToInt32(liquidaciones[0].month) + 1);

            if (tareas.Count > 0)
            {
                
                ValorDIA = new BO.BOTareas().cargarTareaByID(_contrato.IdTarea).Valor;

                Valor = ValorDIA * tareas.Sum(o=>o.Cantidad);

            }

            return Valor;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtMonto, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDetallenombre.Text) || string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Debe ingresar un detalle y un monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el ítem principal con el detalle
            ListViewItem nuevoItem = new ListViewItem(txtDetallenombre.Text);

            // Agregar el monto como subitem
            nuevoItem.SubItems.Add(txtMonto.Text);


            // Puedes guardar un objeto personalizado o solo el texto en Tag
            nuevoItem.Tag = new
            {
                Detalle = txtDetallenombre.Text,
                Monto = txtMonto.Text
            };

            listView1.Items.Add(nuevoItem);


            cboTipoDetalle.SelectedIndex = 0; // Reiniciar el combo box a la opción por defecto
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            cboTipoDetalle.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboTipoFiniquito.SelectedIndex = 0;
            txtdescripcion.Text = "";
            listView1.Items.Clear();
            cargarControles();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Contrato.Finiquito datos = new DTO.Contrato.Finiquito();
                if (Validar()) return;
                datos.idFiniquitos = 0;
                datos.IdContrato = _contrato.IdContrato;
                datos.FechaFiniquito = dtpFFin.Value;
                datos.IdTipoFiniquito = Convert.ToInt32(cboTipoFiniquito.SelectedValue);
                datos.Observacion = txtdescripcion.Text;
                datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                datos.detalleFiniquitos = ObtenerDetalleDelListView();

                DTO.Contrato.Finiquito response = new BO.BOContratos().RegistroFiniquito(datos);
                if (response.IdContrato > 0)
                {
                    Mensaje("Finiquito registrado correctamente.");
                    CargarFiniquito(response);
                }
                else
                {
                    Mensaje("Error al registrar el Finiquito.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar el Finiquito: FrmDesvinculacion");
                Mensaje("Error: " + ex.Message);
            }
        }

        private List<DetalleFiniquito> ObtenerDetalleDelListView()
        {
            List<DetalleFiniquito> detallesList = new List<DetalleFiniquito>();

            foreach (ListViewItem item in listView1.Items)
            {
                string detalle = item.Text;
                string monto = item.SubItems[1].Text;

                // O acceder al objeto Tag si lo usaste
                var datos = item.Tag;

                detallesList.Add(new DetalleFiniquito { Descripcion = detalle, Monto = Convert.ToDecimal(monto.Replace("$", "")) });
            }

            return detallesList;
        }


        private void CargarFiniquito(DTO.Contrato.Finiquito datos)
        {
            try
            {
                textBox1.Text = datos.idFiniquitos.ToString();
                dtpFFin.Value = datos.FechaFiniquito;
                cboTipoFiniquito.SelectedValue = datos.IdTipoFiniquito;
                txtdescripcion.Text = datos.Observacion;
                cboEstado.SelectedValue = datos.Estado ? 1 : 0;
                if (datos.detalleFiniquitos != null)
                {
                    listView1.Items.Clear();

                    foreach (DetalleFiniquito item in datos.detalleFiniquitos)
                    {
                        // Crear el ítem principal con la descripción desde el objeto
                        ListViewItem nuevoItem = new ListViewItem(item.Descripcion); // o item.Detalle si usas ese nombre

                        // Agregar el monto como subitem
                        nuevoItem.SubItems.Add(item.Monto.ToString("C")); // formato moneda opcional

                        // Guardar el mismo objeto en Tag
                        nuevoItem.Tag = item;

                        // Agregar al ListView
                        listView1.Items.Add(nuevoItem);
                    }
                }

                btnIngresar.Enabled = false;
                btnActualizar.Enabled = true;
                btnArchivo.Enabled = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar finiquito en formulario: FrmDesvinculacion");
                Mensaje("Error al cargar finiquito en formulario: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Contrato.Finiquito datos = new DTO.Contrato.Finiquito();
                if (Validar()) return;
                datos.idFiniquitos = Convert.ToInt32(textBox1.Text);
                datos.IdContrato = _contrato.IdContrato;
                datos.FechaFiniquito = dtpFFin.Value;
                datos.IdTipoFiniquito = Convert.ToInt32(cboTipoFiniquito.SelectedValue);
                datos.Observacion = txtdescripcion.Text;
                datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                datos.detalleFiniquitos = ObtenerDetalleDelListView();

                DTO.Contrato.Finiquito response = new BO.BOContratos().RegistroFiniquito(datos);
                if (response.IdContrato > 0)
                {
                    Mensaje("Finiquito registrado correctamente.");
                    CargarFiniquito(response);
                }
                else
                {
                    Mensaje("Error al registrar el Finiquito.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar el Finiquito: FrmDesvinculacion");
                Mensaje("Error: " + ex.Message);
            }
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRequerido(txtdescripcion.Text, "Observación", out string mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (Convert.ToInt32(cboTipoFiniquito.SelectedValue) == 0)
            {
                errores.Add("Debe seleccionar el tipo de Finiquito.");
            }

            if (dtpFFin.Value < _contrato.FechaInicio)
            {
                errores.Add("La fecha de Finiquito no puede ser antes que la fecha de inicio.");
            }

            if (listView1.Items.Count == 0)
            {
                errores.Add("Debe ingresar indemnizaciones de Finiquito.");
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // Hay errores
            }

            return false; // Todo válido
        }


        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtID.Text) != 0)
                {
                    DTO.Contrato.Finiquito datos = new DTO.Contrato.Finiquito();
                    datos.idFiniquitos = Convert.ToInt32(textBox1.Text);
                    datos.IdContrato = _contrato.IdContrato;
                    datos.FechaFiniquito = dtpFFin.Value;
                    datos.IdTipoFiniquito = Convert.ToInt32(cboTipoFiniquito.SelectedValue);
                    datos.Observacion = txtdescripcion.Text;
                    datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                    datos.detalleFiniquitos = ObtenerDetalleDelListView();

                    List<TipoFiniquito> lista = (List<TipoFiniquito>)cboTipoFiniquito.DataSource;
                    TipoFiniquito encontrado = lista.FirstOrDefault(x => x.idTipoFiniquito == datos.IdTipoFiniquito);

                    if (_contrato != null)
                    {
                        string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string rutaArchivo = Path.Combine(rutaCarpeta, "Finiquito"+DateTime.Now.ToString("ddMMyyyy")+"_"+_contrato.IdContrato+".pdf");
                        // Si el archivo ya existe, eliminarlo antes de generar el nuevo
                        if (File.Exists(rutaArchivo))
                        {
                            File.Delete(rutaArchivo);
                        }
                        new BO.BOContratos().GENERARPDFFINIQUITO(_contrato, rutaArchivo, datos, encontrado);
                    }
                    else
                    {
                        Mensaje("Error al cargar contrato.");
                        return;
                    }

                }
                else
                {
                    Mensaje("Debe guardar Finiquito antes de generar.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al generar archivo Finiquito en formulario: FrmDesvinculacion");
                Mensaje("Error al generar Finiquito en formulario: " + ex.Message);
            }
        }
    }
}
