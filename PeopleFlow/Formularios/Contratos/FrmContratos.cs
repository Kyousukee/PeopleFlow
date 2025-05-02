using MySqlX.XDevAPI.Common;
using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.Tareas.Tareas;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.Contratos;
using PeopleFlow.Formularios.Trabajdores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PeopleFlow.Formularios
{

    public partial class FrmContratos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public List<Tareas> tareas = new List<Tareas>();
        public FrmContratos()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmContratos_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarTipoContrato();
            CargarPlazo();
            CargarControles();
            cargarEstados();
            CargarTrabajadores();
            CargarTareas();
        }

        private void CargarControles()
        {
            dttFAsignacion.Value = DateTime.Now;
            dtpFFin.Value = DateTime.Now;
        }

        private void CargarTipoContrato()
        {
            List<TipoContrato> estados = new List<TipoContrato>();
            try
            {
                estados = new BO.BOContratos().cargarTipoContratos();
                cbotipocontrato.DataSource = estados;
                cbotipocontrato.DisplayMember = "Descripcion";
                cbotipocontrato.ValueMember = "IdTipoContrato";

                estados = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar tipo contrato: FrmContratos");
                Mensaje("Error al cargar tipo contrato: " + ex.Message);

            }
        }

        private void CargarTareas()
        {

            try
            {
                tareas = new BO.BOTareas().cargarTareas();

                tareas.Add(new Tareas { IdTarea = 0, Titulo = "Seleccione" });

                tareas = tareas.OrderBy(x => x.IdTarea).ToList();

                cboTareas.DataSource = tareas;
                cboTareas.DisplayMember = "Titulo";
                cboTareas.ValueMember = "IdTarea";

                //tareas = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Tareas: FrmContratos");
                Mensaje("Error al cargar Tareas: " + ex.Message);

            }
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

        private void CargarPlazo()
        {
            List<Plazos> estados = new List<Plazos>();
            try
            {
                estados = new BO.BOContratos().cargarPlazos();
                cboplazo.DataSource = estados;
                cboplazo.DisplayMember = "Descripcion";
                cboplazo.ValueMember = "IdPlazo";

                estados = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar plazo: FrmContratos");
                Mensaje("Error al cargar plazo: " + ex.Message);

            }
        }


        private void CargarTrabajadores()
        {
            List<EmpleadosContratos> emp = new List<EmpleadosContratos>();
            try
            {
                emp = new BO.BOEmpleados().cargarTrabajadoresContratos();
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
                logger.Error(ex, "Error al cargar trabajadores: FrmContratos");
                Mensaje("Error al cargar trabajadores: " + ex.Message);

            }
        }

        private void cboEmpleados_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEmpleados.SelectedValue != null && cboEmpleados.SelectedIndex != 0)
                {
                    pContratos.Enabled = true;

                    Contrato contrato = new Contrato();
                    contrato = new BO.BOContratos().getContratoTrabajador(Convert.ToInt32(cboEmpleados.SelectedValue));
                    if (contrato != null)
                    {
                        //Mensaje("Contrato Cargado");
                        cargarContrato(contrato);
                    }
                    else
                    {
                        Mensaje("Ingresar Nuevo Contrato");
                        limpiar();
                        pContratos.Enabled = true;
                        btnIngresar.Enabled = true;
                    }
                }
                else
                {
                    pContratos.Enabled = false;
                    limpiar();
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar trabajadores: FrmContratos");
                Mensaje("Error: " + ex.Message);

            }


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Contrato.Contrato datos = new DTO.Contrato.Contrato();
                if (Validar()) return;
                datos.IdContrato = 0;
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.FechaInicio = dttFAsignacion.Value;
                if (Convert.ToInt32(cbotipocontrato.SelectedValue) == 1 || Convert.ToInt32(cbotipocontrato.SelectedValue) == 4)
                {
                    datos.FechaFin = dtpFFin.Value;
                }

                datos.IdTipoContrato = Convert.ToInt32(cbotipocontrato.SelectedValue);
                datos.IdPlazo = Convert.ToInt32(cboplazo.SelectedValue);
                datos.IdTarea = Convert.ToInt32(cboTareas.SelectedValue);
                datos.NPlazo = txtnumero.Text == "" ? 0 : Convert.ToInt32(txtnumero.Text);
                datos.Descripcion = txtdescripcion.Text;
                datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);

                DTO.Contrato.Contrato response = new BO.BOContratos().registroContrato(datos);
                if (response.IdContrato > 0)
                {
                    Mensaje("Contrato registrado correctamente.");
                    cargarContrato(response);
                }
                else
                {
                    Mensaje("Error al registrar el contrato.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar el contrato: FrmContratos");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void cargarContrato(Contrato contrato)
        {
            try
            {
                txtID.Text = contrato.IdContrato.ToString();
                dttFAsignacion.Value = contrato.FechaInicio;

                if (contrato.IdTipoContrato == 1 || contrato.IdTipoContrato == 4)
                {
                    dtpFFin.Value = contrato.FechaFin;
                }

                cbotipocontrato.SelectedValue = contrato.IdTipoContrato;
                cboplazo.SelectedValue = contrato.IdPlazo;
                txtnumero.Text = contrato.NPlazo.ToString();
                txtdescripcion.Text = contrato.Descripcion;
                cboEstado.SelectedValue = Convert.ToInt32(contrato.Estado);
                cboTareas.SelectedValue = contrato.IdTarea;


                btnIngresar.Enabled = false;
                btnActualizar.Enabled = true;
                btnArchivo.Enabled = true;
                btnanexos.Enabled = true;
                btndesvincular.Enabled = true;
                pContratos.Enabled = true;

                //Mensaje("Trabajador cargado correctamente.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar contrato en formulario: FrmContratos");
                Mensaje("Error al cargar contrato en formulario: " + ex.Message);
            }
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRequerido(txtdescripcion.Text, "Descripción", out string mensajeError))
            {
                errores.Add(mensajeError);
            }

            int tipoContrato;
            int.TryParse(cbotipocontrato.SelectedValue?.ToString(), out tipoContrato);

            if (tipoContrato == 1 || tipoContrato == 4)
            {
                if (!Validaciones.ValidarRequerido(txtnumero.Text, "Valor", out mensajeError))
                {
                    errores.Add(mensajeError);
                }
                else if (decimal.TryParse(txtnumero.Text, out decimal valor))
                {
                    if (valor <= 0)
                    {
                        errores.Add("El número de plazo debe ser mayor a 0.");
                    }
                }
                else
                {
                    errores.Add("El número ingresado no es válido.");
                }
            }

            if (cboTareas.SelectedIndex == 0)
            {
                errores.Add("Debe seleccionar una tarea de referencia.");
            }

            if (cbotipocontrato.SelectedIndex == 0)
            {
                errores.Add("Debe seleccionar un tipo de contrato.");
            }

            if (dttFAsignacion.Value > dtpFFin.Value)
            {
                errores.Add("La fecha de asignación no puede ser mayor a la fecha de finalización.");
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // Hay errores
            }

            return false; // Todo correcto
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Contrato.Contrato datos = new DTO.Contrato.Contrato();
                if (Validar()) return;
                datos.IdContrato = Convert.ToInt32(txtID.Text);
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.FechaInicio = dttFAsignacion.Value;
                if (Convert.ToInt32(cbotipocontrato.SelectedValue) == 1 || Convert.ToInt32(cbotipocontrato.SelectedValue) == 4)
                {
                    datos.FechaFin = dtpFFin.Value;
                }

                datos.IdTipoContrato = Convert.ToInt32(cbotipocontrato.SelectedValue);
                datos.IdPlazo = Convert.ToInt32(cboplazo.SelectedValue);
                datos.IdTarea = Convert.ToInt32(cboTareas.SelectedValue);
                datos.NPlazo = Convert.ToInt32(txtnumero.Text);
                datos.Descripcion = txtdescripcion.Text;
                datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);

                DTO.Contrato.Contrato response = new BO.BOContratos().registroContrato(datos);
                if (response.IdContrato > 0)
                {
                    Mensaje("Contrato registrado correctamente.");
                    cargarContrato(response);
                }
                else
                {
                    Mensaje("Error al registrar el contrato.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar el contrato: FrmContratos");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            cboEmpleados.SelectedIndex = 0;
            pContratos.Enabled = false;
        }

        private void limpiar()
        {
            txtID.Text = "0";
            dttFAsignacion.Value = DateTime.Now;
            dtpFFin.Value = DateTime.Now;
            cbotipocontrato.SelectedIndex = 0;
            cboplazo.SelectedIndex = 0;
            txtnumero.Text = "";
            txtdescripcion.Text = "";
            cboEstado.SelectedIndex = 0;
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;
            btnArchivo.Enabled = false;
            btnanexos.Enabled = false;
            btndesvincular.Enabled = false;


        }

        private void cbotipocontrato_SelectedValueChanged(object sender, EventArgs e)
        {
            var objeto = cbotipocontrato.SelectedValue is TipoContrato tipoContrat2o;
            if (cbotipocontrato.SelectedValue is TipoContrato tipoContrato)
            {

                return;
            }

            if (Convert.ToInt32(cbotipocontrato.SelectedValue) == 1 || Convert.ToInt32(cbotipocontrato.SelectedValue.ToString()) == 4)
            {
                cboplazo.Enabled = true;
            }
            else
            {
                cboplazo.Enabled = false;
            }

        }

        private void cboplazo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboplazo.SelectedValue is Plazos plazo)
            {

                return;
            }

            if (Convert.ToInt32(cboplazo.SelectedValue) != 0)
            {
                txtnumero.Enabled = true;
            }
            else
            {
                txtnumero.Text = "";
                txtnumero.Enabled = false;
            }



        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtnumero, e);
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            if (txtnumero.Text != "")
            {
                if (Convert.ToInt32(cboplazo.SelectedValue) == 3)
                    dtpFFin.Value = dttFAsignacion.Value.AddDays(Convert.ToInt32(txtnumero.Text));

                if (Convert.ToInt32(cboplazo.SelectedValue) == 4)
                    dtpFFin.Value = dttFAsignacion.Value.AddMonths(Convert.ToInt32(txtnumero.Text));

                if (Convert.ToInt32(cboplazo.SelectedValue) == 5)
                    dtpFFin.Value = dttFAsignacion.Value.AddYears(Convert.ToInt32(txtnumero.Text));
            }
            else
            {
                dtpFFin.Value = DateTime.Now;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListadoTrabajadores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoContrato frmShow = new FrmListadoContrato();
                frmShow.ShowDialog();
                if (frmShow.selecCtontrato.IdContrato != 0)
                {
                    cboEmpleados.SelectedValue = frmShow.selecCtontrato.IdEmpleado;
                    cargarContrato(frmShow.selecCtontrato);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de contratos en formulario: FrmContratos");
                Mensaje("Error al cargar Listado de contratos en formulario: " + ex.Message);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbotipocontrato.SelectedValue) != 0)
                {
                    int idtipopago = Convert.ToInt32(cbotipocontrato.SelectedValue);

                    Contrato contrato = new Contrato();
                    contrato = new BO.BOContratos().getContratoTrabajador(Convert.ToInt32(cboEmpleados.SelectedValue));
                    if (contrato != null)
                    {
                        string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string rutaArchivo = Path.Combine(rutaCarpeta, "Contrato.pdf");
                        // Si el archivo ya existe, eliminarlo antes de generar el nuevo
                        if (File.Exists(rutaArchivo))
                        {
                            File.Delete(rutaArchivo);
                        }
                        new BO.BOContratos().GENERARPDFCONTRATO(contrato, rutaArchivo, tareas);
                    }
                    else
                    {
                        Mensaje("Error al cargar contrato.");
                        return;
                    }

                }
                else
                {
                    Mensaje("Debe seleccionar un tipo de contrato.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al generar archivo Contrato en formulario: FrmContratos");
                Mensaje("Error al generar Contrato en formulario: " + ex.Message);
            }
        }

        private void btndesvincular_Click(object sender, EventArgs e)
        {
            try
            {

                Contrato contrato = new Contrato();
                contrato = new BO.BOContratos().getContratoTrabajador(Convert.ToInt32(cboEmpleados.SelectedValue));
                if (contrato != null)
                {
                    FrmDesvinculacion frmShow = new FrmDesvinculacion();
                    frmShow._contrato = contrato;
                    frmShow.ShowDialog();
                    if (frmShow._contrato.IdContrato != 0)
                    {
                        cboEmpleados.SelectedValue = frmShow._contrato.IdEmpleado;
                        cargarContrato(frmShow._contrato);
                    }
                }
                else
                {
                    Mensaje("Error al cargar contrato.");
                    return;
                }



            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al generar Finiquito en formulario: FrmContratos");
                Mensaje("Error al generar Finiquito en formulario: " + ex.Message);
            }
        }

        private void btnanexos_Click(object sender, EventArgs e)
        {
            try
            {

                Contrato contrato = new Contrato();
                contrato = new BO.BOContratos().getContratoTrabajador(Convert.ToInt32(cboEmpleados.SelectedValue));
                if (contrato != null)
                {
                    FrmAnexos frmShow = new FrmAnexos();
                    frmShow._contrato = contrato;
                    frmShow.ShowDialog();
                    if (frmShow._contrato.IdContrato != 0)
                    {
                        cboEmpleados.SelectedValue = frmShow._contrato.IdEmpleado;
                        cargarContrato(frmShow._contrato);
                    }
                }
                else
                {
                    Mensaje("Error al cargar contrato.");
                    return;
                }



            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al generar Anexos en formulario: FrmContratos");
                Mensaje("Error al generar Anexos en formulario: " + ex.Message);
            }
        }
    }
}
