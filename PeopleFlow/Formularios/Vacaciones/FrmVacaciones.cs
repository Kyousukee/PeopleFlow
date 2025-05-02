using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.TareasForm;
using PeopleFlow.Formularios.Vacaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFlow.Formularios.Dashboard
{
    public partial class FrmVacaciones : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private bool cargando = true; // Variable de control
        SaldoVacacionesResult saldoVacacionesResult = new SaldoVacacionesResult();
        public FrmVacaciones()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVacaciones_Load(object sender, EventArgs e)
        {
            cargando = true;
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarTrabajadores();
            CargarControles();
            cargando = false;
        }

        private void CargarControles()
        {
            dttInicio.Value = DateTime.Now;
            dttTermino.Value = DateTime.Now;
            dttRetorno.Value = DateTime.Now;
        }

        private void CargarDiasSaldos()
        {
            try
            {
                saldoVacacionesResult = new BO.BOVacaciones().ObtenerSaldoVacacionesChile(Convert.ToInt32(cboEmpleados.SelectedValue));
                txtsaldo.Text = saldoVacacionesResult.SaldoVacaciones.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar saldo de vacaciones: {this.Name}");
                Mensaje("Error al cargar saldo de vacaciones: " + ex.Message);
            }
        }

        private void CargarTrabajadores()
        {
            List<EmpleadosContratos> emp = new List<EmpleadosContratos>();
            try
            {
                emp = new BO.BOEmpleados().cargarTrabajadoresContratosActivos();
                //HistorialEmpleado = emp;
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

        private bool Validar()
        {
            bool result = false;
            if (!Validaciones.ValidarRequerido(txtdias.Text, "Cantidad", out string mensajeError))
            {
                Mensaje(mensajeError);
                result = true;
            }
            if (!Validaciones.ValidarRequerido(txtsaldo.Text, "Saldo", out mensajeError))
            {
                Mensaje(mensajeError);
                result = true;
            }

            return result;
        }


        private void txtdias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtdias, e);
        }

        private void txtsaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtsaldo, e);
        }

        private void cboEmpleados_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEmpleados.SelectedValue != null && cboEmpleados.SelectedIndex != 0)
                {
                    pLiquidacion.Enabled = true;

                    CargarDiasSaldos();
                }
                else
                {
                    pLiquidacion.Enabled = false;
                    //limpiar();
                    txtsaldo.Text = "";
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al seleccionar trabajadores: {this.Name}");
                Mensaje("Error: " + ex.Message);

            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Vacaciones datos = new DTO.Vacaciones();
                if (Validar()) return;
                datos.idVacaciones = 0;
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.CantDias = Convert.ToInt32(txtdias.Text);
                datos.SaldoTrabajador = Convert.ToInt32(txtsaldo.Text);
                datos.FechaIni = dttInicio.Value;
                datos.FechaFin = dttTermino.Value;
                datos.Fecha_Retorno = dttRetorno.Value;

                DTO.Vacaciones response = new BO.BOVacaciones().registroVacaciones(datos);
                if (response.idVacaciones > 0)
                {
                    Mensaje("Vacacion registrada correctamente.");
                    cargarVacaciones(response);
                }
                else
                {
                    Mensaje("Error al registrar la Vacacion.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al registrar la Vacacion: {this.Name}");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void cargarVacaciones(DTO.Vacaciones vacaciones)
        {
            try
            {
                txtID.Text = vacaciones.idVacaciones.ToString();
                cboEmpleados.SelectedValue = vacaciones.IdEmpleado;
                dttInicio.Value = vacaciones.FechaIni;
                dttTermino.Value = vacaciones.FechaFin;
                txtdias.Text = vacaciones.CantDias.ToString();
                txtsaldo.Text = vacaciones.SaldoTrabajador.ToString();
                dttRetorno.Value = vacaciones.Fecha_Retorno;

                btningreso.Enabled = false;
                btnupdate.Enabled = true;
                btnArchivo.Enabled = true;
                btnEliminar.Enabled = true;

                //Mensaje("Trabajador cargado correctamente.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Vacaciones en formulario: {this.Name}");
                Mensaje("Error al cargar Vacaciones en formulario: " + ex.Message);
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
            dttInicio.Value = DateTime.Now;
            dttTermino.Value = DateTime.Now;
            txtdias.Text = "";
            txtsaldo.Text = "";
            dttRetorno.Value = DateTime.Now;
            btningreso.Enabled = true;
            btnupdate.Enabled = false;
            btnEliminar.Enabled = false;
            btnArchivo.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Vacaciones datos = new DTO.Vacaciones();
                if (Validar()) return;
                datos.idVacaciones = Convert.ToInt32(txtID.Text);
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.CantDias = Convert.ToInt32(txtdias.Text);
                datos.SaldoTrabajador = Convert.ToInt32(txtsaldo.Text);
                datos.FechaIni = dttInicio.Value;
                datos.FechaFin = dttTermino.Value;
                datos.Fecha_Retorno = dttRetorno.Value;

                DTO.Vacaciones response = new BO.BOVacaciones().registroVacaciones(datos);
                if (response.idVacaciones > 0)
                {
                    Mensaje("Vacacion registrada correctamente.");
                    cargarVacaciones(response);
                }
                else
                {
                    Mensaje("Error al registrar la Vacacion.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al editar la Vacacion: {this.Name}");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void btnListadoLiquidacion_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoVacaciones frmShow = new FrmListadoVacaciones();
                frmShow.ShowDialog();
                if (frmShow.selectedVacacion.idVacaciones != 0)
                {
                    cargarVacaciones(frmShow.selectedVacacion);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar Listado de Vacaciones en formulario: {this.Name}");
                Mensaje("Error al cargar Listado de Vacaciones en formulario: " + ex.Message);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboEmpleados.SelectedValue) != 0)
                {
                    DTO.Vacaciones datos = new DTO.Vacaciones();
                    datos = new BO.BOVacaciones().GetVacacionesByID(Convert.ToInt32(txtID.Text));

                    if (datos.idVacaciones != 0)
                    {
                        string rutaCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string rutaArchivo = Path.Combine(rutaCarpeta, "Vacaciones_" + txtID.Text + "_" + ".pdf");
                        // Si el archivo ya existe, eliminarlo antes de generar el nuevo
                        if (File.Exists(rutaArchivo))
                        {
                            File.Delete(rutaArchivo);
                        }
                        new BO.BOVacaciones().GENERARPDFVACACION(datos, rutaArchivo);
                    }
                    else
                    {
                        Mensaje("Error al cargar Vacacion.");
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
                logger.Error(ex, $"\"Error al generar archivo Vacacion en formulario: {this.Name}");
                Mensaje("Error al generar Vacacion en formulario: " + ex.Message);
            }
        }

        private void dttTermino_ValueChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            if (dttTermino.Value.Date < dttInicio.Value.Date)
            {
                dttTermino.Value = dttInicio.Value;
                txtsaldo.Text = saldoVacacionesResult.SaldoVacaciones.ToString();
                Mensaje("Fecha de término no puede ser anterior a fecha de inicio.");
                return;
            }

            // Calcular días hábiles (L-V)
            int totalDiasHabiles = CalcularDiasHabiles(dttInicio.Value, dttTermino.Value);
            txtdias.Text = totalDiasHabiles.ToString();

            // Calcular fecha de retorno (próximo día hábil)
            dttRetorno.Value = CalcularProximoDiaHabil(dttTermino.Value);
            txtsaldo.Text = (saldoVacacionesResult.SaldoVacaciones - totalDiasHabiles).ToString();
        }

        // Función para calcular días hábiles (excluye sábados y domingos)
        private int CalcularDiasHabiles(DateTime fechaInicio, DateTime fechaFin)
        {
            int diasHabiles = 0;
            DateTime fecha = fechaInicio;

            while (fecha <= fechaFin)
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasHabiles++;
                }
                fecha = fecha.AddDays(1);
            }

            return diasHabiles;
        }

        // Función para obtener el próximo día hábil
        private DateTime CalcularProximoDiaHabil(DateTime fecha)
        {
            DateTime fechaRetorno = fecha.AddDays(1);

            // Saltar fines de semana
            while (fechaRetorno.DayOfWeek == DayOfWeek.Saturday ||
                   fechaRetorno.DayOfWeek == DayOfWeek.Sunday)
            {
                fechaRetorno = fechaRetorno.AddDays(1);
            }

            return fechaRetorno;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    new BO.BOVacaciones().EliminarVacaciones(Convert.ToInt32(txtID.Text));
                    Mensaje("Vacaciones eliminada correctamente!!");
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al eliminar Vacacion en formulario: {this.Name}");
                Mensaje("Error al eliminar Vacacion en formulario: " + ex.Message);
            }
            
        }
    }
}
