using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.Contratos;
using PeopleFlow.Formularios.Liquidaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFlow.Formularios
{
    public partial class FrmLiquidaciones : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        List<EmpleadosContratos> HistorialEmpleado = new List<EmpleadosContratos>();
        public FrmLiquidaciones()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLiquidaciones_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarTrabajadores();
            cargarcontroles();
        }

        private void cargarcontroles()
        {
            // Configura el DateTimePicker para mostrar solo el año
            // Configura el DateTimePicker para mostrar solo el año
            dttYear.Format = DateTimePickerFormat.Custom;
            dttYear.CustomFormat = "yyyy"; // Solo muestra el año
            dttYear.ShowUpDown = true; // Usa controles de flecha para cambiar el año

            // Establece el año actual como valor inicial
            dttYear.Value = DateTime.Now; // Fecha actual

            // Configurar para mostrar solo el mes
            dttMeses.Format = DateTimePickerFormat.Custom;
            dttMeses.CustomFormat = "MMMM"; // Mostrar el nombre completo del mes (ej: "Enero")
                                            // dateTimePicker1.CustomFormat = "MMM"; // Mostrar el nombre abreviado del mes (ej: "Ene")
                                            // dateTimePicker1.CustomFormat = "MM"; // Mostrar el número del mes (ej: "01")

            dttMeses.ShowUpDown = true; // Usar controles de flecha para cambiar el mes

            // Establecer el mes actual como valor inicial
            dttMeses.Value = DateTime.Now; // Fecha actual
        }

        private void CargarTrabajadores()
        {
            List<EmpleadosContratos> emp = new List<EmpleadosContratos>();
            try
            {
                emp = new BO.BOEmpleados().cargarTrabajadoresContratosActivos();
                HistorialEmpleado = emp;
                cboEmpleados.DataSource = emp;
                cboEmpleados.DisplayMember = "Descripcion";
                cboEmpleados.ValueMember = "Id";

                // Crear una lista de autocompletado personalizada
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                foreach (var empleado in emp)
                {
                    autoCompleteCollection.Add(empleado.Descripcion);
                }
                cboEmpleados.AutoCompleteCustomSource = autoCompleteCollection;

                emp = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar trabajadores: {this.Name}");
                Mensaje("Error al cargar trabajadores: " + ex.Message);

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboEmpleados_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEmpleados.SelectedValue != null && cboEmpleados.SelectedIndex != 0)
                {
                    pLiquidacion.Enabled = true;


                }
                else
                {
                    pLiquidacion.Enabled = false;
                    //limpiar();
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar trabajadores: {this.Name}");
                Mensaje("Error: " + ex.Message);

            }
        }

        private bool Validar()
        {
            bool result = false;

            Liquidacion datos = new BO.BOLiquidaciones().getLiquidacionPeriodo(dttMeses.Value.ToString("MMMM") + " de " + dttYear.Value.ToString("yyyy"), Convert.ToInt32(cboEmpleados.SelectedValue));
            if (datos != null)
            {
                Mensaje("Este empleado ya cuenta con su liquidacion para este periodo.");
                result = true;
            }


            return result;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidacion datos = new Liquidacion();
                decimal sueldoBase = 0;
                decimal sueldoLiquido = 0;
                decimal bonificacion = 0;
                decimal deduccion = 0;
                if (Validar()) return;
                datos.IdLiquidacion = 0;
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.Periodo = dttMeses.Value.ToString("MMMM") + " de " + dttYear.Value.ToString("yyyy");
                DateTime primerDia = new DateTime(dttYear.Value.Year, dttMeses.Value.Month, 1);
                DateTime ultimoDia = new DateTime(dttYear.Value.Year, dttMeses.Value.Month, DateTime.DaysInMonth(dttYear.Value.Year, dttMeses.Value.Month), 23, 59, 59);

                List<RegistroActividad> actividads = new BO.BOTareas().getRegistroActividades(0, primerDia, ultimoDia, datos.IdEmpleado);

                sueldoBase = actividads.Sum(a => a.Total);
                datos.SalarioBase = sueldoBase;

                List<DTO.Bonificaciones> bonificaciones = new DAO.ContratosDAO().GetBonificacionesEmpresaEmpleado(datos.IdEmpleado);

                bonificacion = bonificaciones.Sum(a => a.Monto);

                datos.Bonificaciones = bonificacion;

                List<DTO.Deducciones> deducciones = new DAO.DeduccionesDAO().GetDeduccionesEmpresaEmpleado(datos.IdEmpleado);

                deduccion = deducciones.Sum(a => a.Monto);

                datos.Deducciones = deduccion;

                sueldoLiquido = sueldoBase + bonificacion - deduccion;

                datos.SueldoLiquido = sueldoLiquido;

                datos.IdContrato = Convert.ToInt32(HistorialEmpleado.Where(a => a.Id == datos.IdEmpleado).FirstOrDefault().IdContrato);
                datos.year = dttYear.Value.Year.ToString();
                datos.month = dttMeses.Value.Month.ToString();

                datos.DescripcionBonos = ReturnDescripcionBonificaciones(bonificaciones,bonificacion, sueldoBase);


                datos.DescripcionDeducciones = ReturnDescripcionDeducciones(deducciones,deduccion);

                DTO.Liquidacion response = new BO.BOLiquidaciones().registroLiquidacion(datos);

                if (response.IdLiquidacion > 0)
                {
                    Mensaje("Liquidacion registrada correctamente.");
                    CargarLiquidacion(response);
                }
                else
                {
                    Mensaje("Error al registrar la Liquidacion.");
                }

                //datos.FechaFinalizacion = dtpFFin.Value;
                //datos.IdEstadoTarea = Convert.ToInt32(cboEstado.SelectedValue);
                //datos.IdTipoPago = Convert.ToInt32(Cbotipopago.SelectedValue);
                //datos.Valor = Convert.ToDecimal(txtvalor.Text);
                //datos.Titulo = txtNombre.Text;
                //datos.IdJornada = Convert.ToInt32(cbojornada.SelectedValue);

                //DTO.TareasDTO.Tareas response = new BO.BOTareas().registroTarea(datos);

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al registrar la Liquidacion: {this.Name}");
                Mensaje("Error: " + ex.Message);
            }
        }

        private string ReturnDescripcionBonificaciones(List<DTO.Bonificaciones> bonificaciones,decimal bonificacion,decimal sueldoBase)
        {
            string descripcion = "";
            // Generar el contenido en formato HTML
            descripcion = "<table style='border-collapse: collapse; font-family: monospace; width: 100%;'>[[SUELDOBASE]]";

            List<DTO.Bonificaciones> bonificacionesImponibles = bonificaciones.Where(b => b.Imponible).ToList();
            List<DTO.Bonificaciones> bonificacionesNoImponibles = bonificaciones.Where(b => !b.Imponible).ToList();

            // Encabezado
            //descripcion += @"
            //<tr>
            //    <th style='border-bottom: 2px solid black; text-align: left;' colspan='2'>HABERES</th>
            //</tr>";

            // Bonificaciones Imponible
            foreach (var b in bonificacionesImponibles)
            {
                descripcion += $@"
                <tr>
                    <td style='text-align: left;'>{b.Descripcion}</td>
                    <td style='text-align: right;'>{b.Monto:N0}</td>
                </tr>";
            }

            // Total imponible
            descripcion += $@"
            <tr>
                <td style='text-align: left; font-weight: bold;'>TOTAL IMPONIBLE</td>
                <td style='text-align: right; font-weight: bold;'>[[TOTALIMPONIBLE]]</td>
            </tr>";

            // Bonificaciones Imponible
            foreach (var b in bonificacionesNoImponibles)
            {
                descripcion += $@"
                <tr>
                    <td style='text-align: left;'>{b.Descripcion}</td>
                    <td style='text-align: right;'>{b.Monto:N0}</td>
                </tr>";
            }

            // Total no imponible
            descripcion += $@"
            [[CARGASFAMILIARES]]
            <tr>
                <td style='text-align: left; font-weight: bold;'>TOTAL NO IMPONIBLE</td>
                <td style='text-align: right;font-weight: bold;'>[[TOTALNOIMPONIBLE]]</td>
            </tr>";

            // Cerrar la tabla
            descripcion += "</table>";
            return descripcion;
        }

        private string ReturnDescripcionDeducciones(List<DTO.Deducciones> deducciones, decimal deduccion)
        {
            string descripcion = "";
            // Generar el contenido en formato HTML
            descripcion = "<table style='border-collapse: collapse; font-family: monospace; width: 100%;'>[[HFALTANTES]]";

            // Encabezado
            //descripcion += @"
            //<tr>
            //    <th style='border-bottom: 2px solid black; text-align: left;' colspan='2'>DESCUENTOS</th>
            //</tr>";

            // Bonificaciones
            foreach (var b in deducciones)
            {
                descripcion += $@"
                <tr>
                    <td style='text-align: left;'>{b.Descripcion}</td>
                    <td style='text-align: right;'>{b.Monto:N0}</td>
                </tr>";
            }

            // Otros Descuentos
            descripcion += $@"
            <tr>
                <td style='text-align: left; font-weight: bold;'>TOTAL OTROS DESC.</td>
                <td style='text-align: right; font-weight: bold;'>{deduccion:N0}</td>
            </tr>";

            // Descuentos Legales
            descripcion += @"
            [[DESCUENTOSLEGALES]]
            <tr>
                <td style='text-align: left; font-weight: bold;'>TOTAL DESC. LEGALES</td>
                <td style='text-align: right;'>[[TOTALDESCLEGALES]]</td>
            </tr>";

            

            

            // Cerrar la tabla
            descripcion += "</table>";
            return descripcion;
        }

        private void CargarLiquidacion(Liquidacion datos)
        {
            try
            {


                txtID.Text = datos.IdLiquidacion.ToString();
                cboEmpleados.SelectedValue = datos.IdEmpleado;
                dttYear.Value = new DateTime(Convert.ToInt32(datos.year), 1, 1);
                dttMeses.Value = new DateTime(DateTime.Now.Year, Convert.ToInt32(datos.month), 1);
                txtcontrato.Text = datos.IdContrato.ToString();
                txtperiodo.Text = datos.Periodo;

                txtsueldobase.Text = datos.SalarioBase.ToString("N0");
                txtbonos.Text = datos.Bonificaciones.ToString("N0");
                txtdeducciones.Text = datos.Deducciones.ToString("N0");
                txtsueldoliquido.Text = datos.SueldoLiquido.ToString("N0");
                txtdescbono.Text = datos.DescripcionBonos;
                txtdescdedu.Text = datos.DescripcionDeducciones;

                pLiquidacion.Enabled = true;
                btnArchivo.Enabled = false;
                btnupdate.Enabled = false;
                btningreso.Enabled = true;

                btnArchivo.Enabled = true;
                btnupdate.Enabled = true;
                btningreso.Enabled = false;

                //Mensaje("Trabajador cargado correctamente.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar liquidacion en formulario: {this.Name}");
                Mensaje("Error al cargar liquidacion en formulario: " + ex.Message);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtID.Text = "0";
            cboEmpleados.SelectedIndex = 0;
            dttYear.Value = DateTime.Now;
            dttMeses.Value = DateTime.Now;
            txtcontrato.Text = "0";
            txtperiodo.Text = "";

            txtsueldobase.Text = "";
            txtbonos.Text = "";
            txtdeducciones.Text = "";
            txtsueldoliquido.Text = "";
            txtdescbono.Text = "";
            txtdescdedu.Text = "";
            btnArchivo.Enabled = false;
            btnupdate.Enabled = false;
            btningreso.Enabled = true;
        }

        private void btnListadoLiquidacion_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoLiquidacion frmShow = new FrmListadoLiquidacion();
                frmShow.ShowDialog();
                if (frmShow.selecLiquidacion.IdLiquidacion != 0)
                {
                    cboEmpleados.SelectedValue = frmShow.selecLiquidacion.IdEmpleado;
                    CargarLiquidacion(frmShow.selecLiquidacion);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado de liquidaciones en formulario: {this.Name}");
                Mensaje("Error al cargar Listado de liquidaciones en formulario: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidacion datos = new Liquidacion();
                decimal sueldoBase = 0;
                decimal sueldoLiquido = 0;
                decimal bonificacion = 0;
                decimal deduccion = 0;
                //if (Validar()) return;
                datos.IdLiquidacion = Convert.ToInt32(txtID.Text);
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.Periodo = dttMeses.Value.ToString("MMMM") + " de " + dttYear.Value.ToString("yyyy");
                DateTime primerDia = new DateTime(dttYear.Value.Year, dttMeses.Value.Month, 1);
                DateTime ultimoDia = new DateTime(dttYear.Value.Year, dttMeses.Value.Month, DateTime.DaysInMonth(dttYear.Value.Year, dttMeses.Value.Month), 23, 59, 59);

                List<RegistroActividad> actividads = new BO.BOTareas().getRegistroActividades(0, primerDia, ultimoDia, datos.IdEmpleado);

                sueldoBase = actividads.Sum(a => a.Total);
                datos.SalarioBase = sueldoBase;

                List<DTO.Bonificaciones> bonificaciones = new DAO.ContratosDAO().GetBonificacionesEmpresaEmpleado(datos.IdEmpleado);

                bonificacion = bonificaciones.Sum(a => a.Monto);

                datos.Bonificaciones = bonificacion;

                List<DTO.Deducciones> deducciones = new DAO.DeduccionesDAO().GetDeduccionesEmpresaEmpleado(datos.IdEmpleado);

                deduccion = deducciones.Sum(a => a.Monto);

                datos.Deducciones = deduccion;

                sueldoLiquido = sueldoBase + bonificacion - deduccion;

                datos.SueldoLiquido = sueldoLiquido;

                datos.IdContrato = Convert.ToInt32(HistorialEmpleado.Where(a => a.Id == datos.IdEmpleado).FirstOrDefault().IdContrato);
                datos.year = dttYear.Value.Year.ToString();
                datos.month = dttMeses.Value.Month.ToString();

                datos.DescripcionBonos = ReturnDescripcionBonificaciones(bonificaciones, bonificacion, sueldoBase);


                datos.DescripcionDeducciones = ReturnDescripcionDeducciones(deducciones, deduccion);

                DTO.Liquidacion response = new BO.BOLiquidaciones().registroLiquidacion(datos);

                if (response.IdLiquidacion > 0)
                {
                    Mensaje("Liquidacion registrada correctamente.");
                    CargarLiquidacion(response);
                }
                else
                {
                    Mensaje("Error al registrar la Liquidacion.");
                }

                //datos.FechaFinalizacion = dtpFFin.Value;
                //datos.IdEstadoTarea = Convert.ToInt32(cboEstado.SelectedValue);
                //datos.IdTipoPago = Convert.ToInt32(Cbotipopago.SelectedValue);
                //datos.Valor = Convert.ToDecimal(txtvalor.Text);
                //datos.Titulo = txtNombre.Text;
                //datos.IdJornada = Convert.ToInt32(cbojornada.SelectedValue);

                //DTO.TareasDTO.Tareas response = new BO.BOTareas().registroTarea(datos);

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al editar la Liquidacion: {this.Name}");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboEmpleados.SelectedValue) != 0)
                {
                    Liquidacion datos = new Liquidacion();
                    datos = new BO.BOLiquidaciones().GetLiquidacionById(Convert.ToInt32(txtID.Text));

                    if (datos.IdLiquidacion != 0)
                    {
                        string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string rutaArchivo = Path.Combine(rutaCarpeta, "Liquidacion_" + datos.Periodo +"_"+datos.NombreEmpleado+".pdf");
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
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al generar Liquidacion en formulario: {this.Name}");
                Mensaje("Error al generar Liquidacion en formulario: " + ex.Message);
            }
        }
    }
}
