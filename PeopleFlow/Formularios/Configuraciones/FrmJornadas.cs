using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.TareasDTO;
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
    public partial class FrmJornadas : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private bool cargando = true;
        public FrmJornadas()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmJornadas_Load(object sender, EventArgs e)
        {
            cargando = true;
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarControles();
            CargarDiasSemana();
            cargando = false;
        }

        public class DiaSemana
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
        }

        private void CargarDiasSemana()
        {
            // Crear lista de días de la semana
            var diasSemana = new List<DiaSemana>
            {
                new DiaSemana { Id = "Lunes", Nombre = "Lunes" },
                new DiaSemana { Id = "Martes", Nombre = "Martes" },
                new DiaSemana { Id = "Miercoles", Nombre = "Miercoles" },
                new DiaSemana { Id = "Jueves", Nombre = "Jueves" },
                new DiaSemana { Id = "Viernes", Nombre = "Viernes" },
                new DiaSemana { Id = "Sabado", Nombre = "Sabado" },
                new DiaSemana { Id = "Domingo", Nombre = "Domingo" }
            };

            // Configurar combo de día de comienzo
            cboDiaComienzo.DataSource = diasSemana;
            cboDiaComienzo.DisplayMember = "Nombre";
            cboDiaComienzo.ValueMember = "Id";

            // Configurar combo de día de fin
            CboDiaFin.DataSource = diasSemana.ToList(); // Nueva copia para evitar sincronización
            CboDiaFin.DisplayMember = "Nombre";
            CboDiaFin.ValueMember = "Id";

            // Opcional: Seleccionar días laborales por defecto
            cboDiaComienzo.SelectedValue = (int)DayOfWeek.Monday;
            CboDiaFin.SelectedValue = (int)DayOfWeek.Friday;
        }

        private void cargarControles()
        {
            // Configurar para mostrar solo la hora en formato de 24 horas
            dttinicio.Format = DateTimePickerFormat.Custom;
            dttinicio.CustomFormat = "HH:mm"; // Formato de 24 horas (ej: 09:00, 23:00)
            dttinicio.ShowUpDown = true; // Usar controles de flecha para cambiar la hora

            // Configurar para mostrar solo la hora en formato de 24 horas
            dtttermino.Format = DateTimePickerFormat.Custom;
            dtttermino.CustomFormat = "HH:mm"; // Formato de 24 horas (ej: 09:00, 23:00)
            dtttermino.ShowUpDown = true; // Usar controles de flecha para cambiar la hora

            dttinicio.Value = DateTime.Now;
            dtttermino.Value = DateTime.Now;

            dttinicio.Value = DateTime.Parse("00:00");
            dtttermino.Value = DateTime.Parse("00:00");

            //dttFAsignacion.Value = DateTime.Now;
            //dttFAsignacion.MaxDate = DateTime.Now;

            dttinicio2.Format = DateTimePickerFormat.Custom;
            dttinicio2.CustomFormat = "HH:mm"; // Formato de 24 horas (ej: 09:00, 23:00)
            dttinicio2.ShowUpDown = true; // Usar controles de flecha para cambiar la hora

            // Configurar para mostrar solo la hora en formato de 24 horas
            dtttermino2.Format = DateTimePickerFormat.Custom;
            dtttermino2.CustomFormat = "HH:mm"; // Formato de 24 horas (ej: 09:00, 23:00)
            dtttermino2.ShowUpDown = true; // Usar controles de flecha para cambiar la hora

            dttinicio2.Value = DateTime.Now;
            dtttermino2.Value = DateTime.Now;


            dttinicio2.Value = DateTime.Parse("00:00");
            dtttermino2.Value = DateTime.Parse("00:00");
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtHoras, e);
        }

        private void btnListadoCargos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoJornadas frmShow = new FrmListadoJornadas();
                frmShow.ShowDialog();
                if (frmShow.selectJornada.idJornadas != 0)
                {
                    CargarJornada(frmShow.selectJornada);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Jornadas en formulario: FrmJornadas");
                Mensaje("Error al cargar Listado de Jornadas en formulario: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DTO.Jornadas req = new DTO.Jornadas();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.idJornadas = 0;
                req.Descripcion = txtNombre.Text;
                req.DiaComienzo = cboDiaComienzo.SelectedValue.ToString();
                req.DiaTermino = CboDiaFin.SelectedValue.ToString();
                req.HoraInSemana = dttinicio.Value.ToString("HH:mm");
                req.HoraOutSemana = dtttermino.Value.ToString("HH:mm");
                if (dttinicio2.Enabled == true)
                {
                    req.HoraInFinSemana = dttinicio2.Value.ToString("HH:mm");
                    req.HoraOutFinSemana = dtttermino2.Value.ToString("HH:mm");
                }

                req.HorasSemanales = Convert.ToInt32(txtHoras.Text);

                DTO.Jornadas response = new BOTareas().registroJornadas(req);
                Mensaje("Jornada registrado con exito.");

                CargarJornada(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al grabar nueva jornada: FrmJornadas");
                Mensaje("Error al grabar nueva jornada: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtHoras.Text = "";
            cboDiaComienzo.SelectedValue = "Lunes";
            CboDiaFin.SelectedValue = "Viernes";
            cargarControles();
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void CargarJornada(Jornadas datos)
        {
            txtID.Text = datos.idJornadas.ToString();
            txtNombre.Text = datos.Descripcion;
            cboDiaComienzo.SelectedValue = datos.DiaComienzo;
            CboDiaFin.SelectedValue = datos.DiaTermino;
            dttinicio.Value = DateTime.Parse(datos.HoraInSemana);
            dtttermino.Value = DateTime.Parse(datos.HoraOutSemana);
            dttinicio2.Value = datos.HoraInFinSemana != null ? DateTime.Parse(datos.HoraInFinSemana) : DateTime.Parse("00:00");
            dtttermino2.Value = datos.HoraOutFinSemana != null ? DateTime.Parse(datos.HoraOutFinSemana) : DateTime.Parse("00:00");
            txtHoras.Text = datos.HorasSemanales.ToString();
            btnIngresar.Enabled = false;
            btnActualizar.Enabled = true;

        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (dttinicio.Value > dtttermino.Value)
            {
                errores.Add("Hora inicio no debe ser mayor que hora término en la Semana.");
            }

            if (dttinicio2.Value > dtttermino2.Value)
            {
                errores.Add("Hora inicio no debe ser mayor que hora término en el Fin de Semana.");
            }

            if (cboDiaComienzo.SelectedIndex > CboDiaFin.SelectedIndex)
            {
                errores.Add("Día de comienzo no debe ser posterior al día de fin.");
            }

            if (!Validaciones.ValidarRequerido(txtNombre.Text, "Descripción", out string mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (!Validaciones.ValidarRequerido(txtHoras.Text, "Horas Semanales", out mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // Hay errores
            }

            return false; // Todo correcto
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DTO.Jornadas req = new DTO.Jornadas();
            Validaciones validaciones = new Validaciones();
            try
            {
                if (Validar()) return;
                req.idJornadas = Convert.ToInt32(txtID.Text);
                req.Descripcion = txtNombre.Text;
                req.DiaComienzo = cboDiaComienzo.SelectedValue.ToString();
                req.DiaTermino = CboDiaFin.SelectedValue.ToString();
                req.HoraInSemana = dttinicio.Value.ToString("HH:mm");
                req.HoraOutSemana = dtttermino.Value.ToString("HH:mm");
                if (dttinicio2.Enabled == true)
                {
                    req.HoraInFinSemana = dttinicio2.Value.ToString("HH:mm");
                    req.HoraOutFinSemana = dtttermino2.Value.ToString("HH:mm");
                }
                req.HorasSemanales = Convert.ToInt32(txtHoras.Text);

                DTO.Jornadas response = new BOTareas().registroJornadas(req);
                Mensaje("Jornada registrado con exito.");

                CargarJornada(response);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar nueva jornada: FrmJornadas");
                Mensaje("Error al grabar nueva jornada: " + ex.Message);
            }
        }

        private void CboDiaFin_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            if (CboDiaFin.SelectedValue == "Sabado" || CboDiaFin.SelectedValue == "Domingo")
            {
                dttinicio2.Enabled = true;
                dtttermino2.Enabled = true;
            }
            else
            {
                dttinicio2.Value = DateTime.Parse("00:00");
                dtttermino2.Value = DateTime.Parse("00:00");
                dttinicio2.Enabled = false;
                dtttermino2.Enabled = false;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
