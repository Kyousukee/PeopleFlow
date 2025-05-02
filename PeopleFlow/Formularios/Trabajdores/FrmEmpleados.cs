using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.TareasForm;
using PeopleFlow.Formularios.Trabajdores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PeopleFlow.Formularios
{
    public partial class FrmEmpleados : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarEstados();
            cargarControles();
            cargarRoles();
            cargarEstadoCivil();
            cargarSalud();
            cargarAfp();
        }

        private void cargarControles()
        {
            dttFIngreso.Value = DateTime.Now;
            DttFNacimiento.Value = DateTime.Now;
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

        private void cargarEstadoCivil()
        {
            List<EstadoCivil> rep = new List<EstadoCivil>();
            try
            {
                rep = new BO.BOEmpleados().cargarEstadoCivil();
                cboCivil.DataSource = rep;
                cboCivil.DisplayMember = "Descripcion";
                cboCivil.ValueMember = "idEstado_Civil";

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar estado civil: {this.Name}");
                Mensaje("Error al cargar estado civil: " + ex.Message);

            }

        }

        private void cargarSalud()
        {
            List<RegimenSalud> rep = new List<RegimenSalud>();
            try
            {
                rep = new BO.BOEmpleados().cargarRegimenSalud();
                cboSalud.DataSource = rep;
                cboSalud.DisplayMember = "Descripcion";
                cboSalud.ValueMember = "idRegimenSalud";

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Salud: {this.Name}");
                Mensaje("Error al cargar Salud: " + ex.Message);

            }

        }

        private void cargarAfp()
        {
            List<TipoAfp> rep = new List<TipoAfp>();
            try
            {
                rep = new BO.BOEmpleados().cargarAFP();
                cboAFP.DataSource = rep;
                cboAFP.DisplayMember = "Descripcion";
                cboAFP.ValueMember = "idAFP";

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar AFP: {this.Name}");
                Mensaje("Error al AFP: " + ex.Message);

            }

        }

        private void cargarRoles()
        {
            List<Roles> roles = new List<Roles>();
            try
            {
                roles = new BO.BOCargo().GetRoles();
                CboCargos.DataSource = roles;
                CboCargos.DisplayMember = "Descripcion";
                CboCargos.ValueMember = "IdRol";

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar roles: {this.Name}");
                Mensaje("Error al cargar roles: " + ex.Message);

            }

        }

        private void txtfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtfono, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleados req = new Empleados();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.IdEmpleado = 0;
                req.Nombre = txtNombres.Text;
                req.Apellido = txtApellidos.Text;
                req.Rut = txtRut.Text + "-" + txtdv.Text;
                req.FechaNacimiento = DttFNacimiento.Value;
                req.Telefono = txtfono.Text;
                req.Correo = txtcorreo.Text;
                req.Direccion = txtdireccion.Text;
                req.FechaIngreso = dttFIngreso.Value;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                req.IdRol = Convert.ToInt32(CboCargos.SelectedValue);
                req.IdEstadoCivil = Convert.ToInt32(cboCivil.SelectedValue);
                req.Nacionalidad = txtnacionalidad.Text;
                req.Profesion = txtprofesion.Text;
                req.IdEmpresa = Sesion.UsuarioActual.IdEmpresa;
                req.Banco = txtBanco.Text;
                req.TipoCuenta = txtcuenta.Text;
                req.NumeroCuenta = txtnumeroC.Text;
                req.IdSalud = Convert.ToInt32(cboSalud.SelectedValue);
                req.IdAfp = Convert.ToInt32(cboAFP.SelectedValue);

                Empleados response = new BOEmpleados().registroEmpleado(req);
                Mensaje("Trabajador registrado con exito.");

                cargarTrabajador(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al grabar registro de Empleado: {this.Name}");
                Mensaje("Error al grabar registro de Empleado: " + ex.Message);
            }
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRut(txtRut.Text + "-" + txtdv.Text))
            {
                errores.Add("Error: Formato Rut no reconocido.");
            }

            if (!Validaciones.ValidarCorreo(txtcorreo.Text))
            {
                errores.Add("Error: Correo incorrecto.");
            }

            if (!Validaciones.ValidarRequerido(txtNombres.Text, "Nombres", out string mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtnacionalidad.Text, "Nacionalidad", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtprofesion.Text, "Profesión", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtApellidos.Text, "Apellidos", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtRut.Text, "Rut", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtdv.Text, "Dígito Verificador", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtfono.Text, "Teléfono", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtcorreo.Text, "Correo", out mensajeError)) errores.Add(mensajeError);
            if (!Validaciones.ValidarRequerido(txtdireccion.Text, "Dirección", out mensajeError)) errores.Add(mensajeError);

            if (Convert.ToUInt32(cboCivil.SelectedValue) == 0)
            {
                errores.Add("Se debe seleccionar estado civil del trabajador.");
            }

            if (Convert.ToUInt32(cboSalud.SelectedValue) == 0)
            {
                errores.Add("Se debe seleccionar Salud del trabajador.");
            }

            if (Convert.ToUInt32(cboAFP.SelectedValue) == 0)
            {
                errores.Add("Se debe seleccionar AFP del trabajador.");
            }

            if (Convert.ToUInt32(CboCargos.SelectedValue) == 0)
            {
                errores.Add("Se debe seleccionar cargo del trabajador.");
            }

            if (errores.Any())
            {
                Mensaje(string.Join("\n", errores));
                return true;
            }

            return false;
        }


        private void cargarTrabajador(Empleados empleado)
        {
            try
            {
                txtID.Text = empleado.IdEmpleado.ToString();
                txtNombres.Text = empleado.Nombre;
                txtApellidos.Text = empleado.Apellido;
                txtRut.Text = empleado.Rut.Substring(0, 8);
                txtdv.Text = empleado.Rut.Substring(empleado.Rut.Length - 1);
                DttFNacimiento.Value = empleado.FechaNacimiento;
                txtfono.Text = empleado.Telefono;
                txtcorreo.Text = empleado.Correo;
                txtdireccion.Text = empleado.Direccion;
                dttFIngreso.Value = empleado.FechaIngreso;
                cboEstado.SelectedValue = Convert.ToInt32(empleado.Estado);
                CboCargos.SelectedValue = empleado.IdRol;
                cboCivil.SelectedValue = empleado.IdEstadoCivil;
                txtnacionalidad.Text = empleado.Nacionalidad;
                txtprofesion.Text = empleado.Profesion;
                txtBanco.Text = empleado.Banco;
                txtcuenta.Text = empleado.TipoCuenta;
                txtnumeroC.Text = empleado.NumeroCuenta;
                cboSalud.SelectedValue = empleado.IdSalud;
                cboAFP.SelectedValue = empleado.IdAfp;

                btnIngresar.Enabled = false;
                btnActualizar.Enabled = true;
                btnContrato.Enabled = true;
                btnLiquidaciones.Enabled = true;
                btnCarga.Enabled = true;

                //Mensaje("Trabajador cargado correctamente.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Empleado en formulario: {this.Name}");
                Mensaje("Error al cargar Empleado en formulario: " + ex.Message);
            }
        }

        private void btnListadoTrabajadores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoTrabajadores frmShow = new FrmListadoTrabajadores();
                frmShow.ShowDialog();
                if (frmShow.selectEmpleado.IdEmpleado != 0)
                {
                    cargarTrabajador(frmShow.selectEmpleado);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado de Empleados en formulario: {this.Name}");
                Mensaje("Error al cargar Listado de Empleados en formulario: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Empleados req = new Empleados();
            try
            {
                if (Validar()) return;
                req.IdEmpleado = Convert.ToInt32(txtID.Text);
                req.Nombre = txtNombres.Text;
                req.Apellido = txtApellidos.Text;
                req.Rut = txtRut.Text + "-" + txtdv.Text;
                req.FechaNacimiento = DttFNacimiento.Value;
                req.Telefono = txtfono.Text;
                req.Correo = txtcorreo.Text;
                req.Direccion = txtdireccion.Text;
                req.FechaIngreso = dttFIngreso.Value;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                req.IdRol = Convert.ToInt32(CboCargos.SelectedValue);
                req.IdEmpresa = Sesion.UsuarioActual.IdEmpresa;
                req.IdEstadoCivil = Convert.ToInt32(cboCivil.SelectedValue);
                req.Nacionalidad = txtnacionalidad.Text;
                req.Profesion = txtprofesion.Text;
                req.Banco = txtBanco.Text;
                req.TipoCuenta = txtcuenta.Text;
                req.NumeroCuenta = txtnumeroC.Text;
                req.IdSalud = Convert.ToInt32(cboSalud.SelectedValue);
                req.IdAfp = Convert.ToInt32(cboAFP.SelectedValue);
                Empleados response = new BOEmpleados().registroEmpleado(req);

                Mensaje("Trabajador registrado con exito.");

                cargarTrabajador(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al EDITAR registro de Empleado: {this.Name}");
                Mensaje("Error al grabar registro de Empleado: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtRut.Text = "";
            txtdv.Text = "";
            DttFNacimiento.Value = DateTime.Now;
            txtfono.Text = "";
            txtcorreo.Text = "";
            txtdireccion.Text = "";
            txtnacionalidad.Text = "";
            txtprofesion.Text = "";
            dttFIngreso.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
            CboCargos.SelectedIndex = 0;
            cboCivil.SelectedIndex = 0;
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;
            btnContrato.Enabled = false;
            btnLiquidaciones.Enabled = false;
            btnCarga.Enabled = false;
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si se presionó la tecla Enter (código ASCII 13)
            if (e.KeyChar == (char)13)
            {
                Empleados empleados = new BOEmpleados().GetEmpleadosRut(txtRut.Text);
                if (empleados.IdEmpleado != 0)
                    cargarTrabajador(empleados);
            }
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            try
            {
                int idtipopago = Convert.ToInt32(txtID.Text);

                Contrato contrato = new Contrato();
                contrato = new BO.BOContratos().getContratoTrabajador(idtipopago);

                List<Tareas> tareas = new BO.BOTareas().cargarTareas();
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
                    Mensaje("Trabajador sin Contrato Activo.");
                    return;
                }


            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al generar archivo Contrato en formulario: {this.Name}");
                Mensaje("Error al generar Contrato en formulario: " + ex.Message);
            }
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAsignacionFamiliar frmShow = new FrmAsignacionFamiliar();
                frmShow.IdEmpleado = Convert.ToInt32(txtID.Text);
                frmShow.ShowDialog();

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Asignacion en formulario: {this.Name}");
                Mensaje("Error al cargar Asignacion en formulario: " + ex.Message);
            }
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            Empleados req = new Empleados();
            try
            {
                req.IdEmpleado = Convert.ToInt32(txtID.Text);
                req.Nombre = txtNombres.Text;
                req.Apellido = txtApellidos.Text;
                req.Rut = txtRut.Text + "-" + txtdv.Text;
                req.FechaNacimiento = DttFNacimiento.Value;
                req.Telefono = txtfono.Text;
                req.Correo = txtcorreo.Text;
                req.Direccion = txtdireccion.Text;
                req.FechaIngreso = dttFIngreso.Value;
                req.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                req.IdRol = Convert.ToInt32(CboCargos.SelectedValue);
                req.IdEmpresa = Sesion.UsuarioActual.IdEmpresa;
                req.IdEstadoCivil = Convert.ToInt32(cboCivil.SelectedValue);
                req.Nacionalidad = txtnacionalidad.Text;
                req.Profesion = txtprofesion.Text;
                req.Banco = txtBanco.Text;
                req.TipoCuenta = txtcuenta.Text;
                req.NumeroCuenta = txtnumeroC.Text;
                req.IdSalud = Convert.ToInt32(cboSalud.SelectedValue);
                req.IdAfp = Convert.ToInt32(cboAFP.SelectedValue);

                FrmLiquidacionesTrabajador frmShow = new FrmLiquidacionesTrabajador();
                frmShow.selectEmpleado = req;
                frmShow.ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado de liquidaciones en formulario: {this.Name}");
                Mensaje("Error al cargar Listado de liquidaciones en formulario: " + ex.Message);
            }
        }
    }
}
