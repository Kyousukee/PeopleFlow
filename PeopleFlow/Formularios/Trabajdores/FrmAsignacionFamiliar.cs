using NLog;
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
    public partial class FrmAsignacionFamiliar : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public int IdEmpleado;
        public FrmAsignacionFamiliar()
        {
            InitializeComponent();
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                AsignacionFamiliar asignacionFamiliar = new AsignacionFamiliar();
                asignacionFamiliar.idCargasEmpleados = Convert.ToInt32(txtID.Text);
                asignacionFamiliar.IdEmpleado = IdEmpleado;
                asignacionFamiliar.NCargasHijos = Convert.ToInt32(numerichijos.Text);
                asignacionFamiliar.NCargasConguye = Convert.ToInt32(numericConyuge.Text);
                asignacionFamiliar.NCargasInvalidez = Convert.ToInt32(numericInvalidez.Text);
                AsignacionFamiliar asignacionFamiliarResp = new BO.BOEmpleados().saveAsignacionFamiliar(asignacionFamiliar);
                if (asignacionFamiliarResp.idCargasEmpleados != 0)
                {
                    Mensaje("Asignacion guardada correctamente!");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al guardar asignacion: {this.Name}");
                Mensaje("Error al guardar asignacion: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignacionFamiliar_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarAsignacionFamiliar();
        }

        private void CargarAsignacionFamiliar()
        {
            try
            {
                AsignacionFamiliar asignacionFamiliar = new BO.BOEmpleados().GetAsignacionFamiliar(IdEmpleado);
                if (asignacionFamiliar != null)
                {
                    numerichijos.Text = asignacionFamiliar.NCargasHijos.ToString();
                    numericConyuge.Text = asignacionFamiliar.NCargasConguye.ToString();
                    numericInvalidez.Text = asignacionFamiliar.NCargasInvalidez.ToString();
                    txtID.Text = asignacionFamiliar.idCargasEmpleados.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al cargar asignacion: {this.Name}");
                Mensaje("Error al cargar asignacion: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                new BO.BOEmpleados().DeleteAsignacionFamiliar(IdEmpleado);
                Mensaje("Asignacion eliminada correctamente!");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"\"Error al eliminar asignacion: {this.Name}");
                Mensaje("Error al eliminar asignacion: " + ex.Message);
            }
        }
    }
}
