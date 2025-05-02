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

namespace PeopleFlow.Formularios.Dashboard
{
    public partial class FrmIngresoAsistencia : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public TareasConEmpleados Tarea = new TareasConEmpleados();
        public bool Save = false;
        public FrmIngresoAsistencia()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIngresoAsistencia_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            txtTitulo.Text = Tarea.Titulo;
            cargarControles();
            cargarTrabajadores();
            HorarioAutomatico(DateTime.Now);
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

            dttFAsignacion.Value = DateTime.Now;
            dttFAsignacion.MaxDate = DateTime.Now;
        }

        private void HorarioAutomatico(DateTime dia)
        {
            try
            {
                Jornadas jornadas = new BO.BOTareas().cargarJornadaByID(Tarea.IdJornada);
                if (jornadas != null)
                {
                    if (dia.DayOfWeek == DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday)
                    {
                        if (jornadas.HoraInFinSemana != null)
                        {
                            dttinicio.Value = Convert.ToDateTime(jornadas.HoraInFinSemana);
                            dtttermino.Value = Convert.ToDateTime(jornadas.HoraOutFinSemana);
                        }
                    }
                    else
                    {
                        dttinicio.Value = Convert.ToDateTime(jornadas.HoraInSemana);
                        dtttermino.Value = Convert.ToDateTime(jornadas.HoraOutSemana);
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar horario automatico: FrmIngresoAsistencia");
                Mensaje("Error al cargar horario automatico: " + ex.Message);
            }
        }

        private void cargarTrabajadores()
        {
            List<TareasEmpleados> empleados = new List<TareasEmpleados>();
            try
            {
                empleados.Add(new TareasEmpleados()
                {
                    IdEmpleador = 0,
                    Nombre = "Todos",
                    Apellido = ""
                });
                empleados.AddRange(new BO.BOTareas().cargarEmpleadosTareas(Tarea.IdTarea));

                foreach (TareasEmpleados item in empleados)
                {
                    item.NombreCompleto = item.Nombre + " " + item.Apellido;
                }
                //empleados = new BO.BOTareas().cargarEmpleadosTareas(Tarea.IdTarea);
                cboEmpleados.DataSource = empleados;
                cboEmpleados.DisplayMember = "NombreCompleto";
                cboEmpleados.ValueMember = "IdEmpleador";
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado Tareas: FrmIngresoAsistencia");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void dttFAsignacion_ValueChanged(object sender, EventArgs e)
        {
            HorarioAutomatico(dttFAsignacion.Value);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.TareasDTO.TareasEmpleadoAsistencia datos = new DTO.TareasDTO.TareasEmpleadoAsistencia();
                if (Validar()) return;
                datos.IdTareaAsistencia = 0;
                datos.IdTarea = Tarea.IdTarea;
                datos.FechaAsignacion = dttFAsignacion.Value;
                datos.IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                datos.HoraInicio = dttinicio.Value.ToString("HH:mm");
                datos.HoraTermino = dtttermino.Value.ToString("HH:mm");
                DTO.TareasDTO.TareasEmpleadoAsistencia response = new BO.BOTareas().registroTareaAsistencia(datos);
                if (response.IdTareaAsistencia > 0)
                {
                    Save = true;
                    Mensaje("Asistencia registrada correctamente.");
                    this.Close();
                }
                else
                {
                    Mensaje("Error al registrar la Actividad.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar la Actividad: FrmIngresoAsistencia");
                Mensaje("Error: " + ex.Message);
            }
        }

        private bool Validar()
        {
            bool result = false;
            if (dttinicio.Value > dtttermino.Value)
            {
                Mensaje("Hora inicio no debe ser mayor que hora termino.");
                result = true;
            }


            TareasEmpleadoAsistencia validador = new BO.BOTareas().getTareaAsistencia(Tarea.IdTarea, Convert.ToInt32(cboEmpleados.SelectedValue), dttFAsignacion.Value);
            if (validador != null)
            {
                // Mostrar un MessageBox para preguntar si desea reemplazar la tarea existente
                DialogResult resultt = MessageBox.Show(
                    "Ya existe Asistencias con los mismos valores. ¿Desea reemplazarlo?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (resultt != DialogResult.Yes)
                {
                    Mensaje("Registro ya se encuentra existente.");
                    result = true;
                }
            }
            return result;
        }
    }
}
