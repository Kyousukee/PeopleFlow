using NLog;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.TareasDTO;
using PeopleFlow.Formularios.Bonificaciones;
using PeopleFlow.Formularios.TareasForm;
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
    public partial class FrmBonificaciones : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmBonificaciones()
        {
            InitializeComponent();
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmBonificaciones_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }

            cargarControles();
            CargarTrabajadores();
            cargarEstados();
            CargarTareas();
        }

        private void CargarTareas()
        {

            try
            {
                List<Tareas> tareas = new BO.BOTareas().cargarTareas();

                tareas.Add(new Tareas { IdTarea = 0, Titulo = "Sin Tarea" });

                tareas = tareas.Where(x => x.IdTipoPago == 2 || x.IdTipoPago == 5 || x.IdTipoPago == 0).ToList();

                tareas = tareas.OrderBy(x => x.IdTarea).ToList();

                cboTareas.DataSource = tareas;
                cboTareas.DisplayMember = "Titulo";
                cboTareas.ValueMember = "IdTarea";

                //tareas = null;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar tareas: FrmBonificaciones");
                Mensaje("Error al cargar tareas: " + ex.Message);

            }
        }

        private void cargarControles()
        {
            dttFAsignacion.Value = DateTime.Now;
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
                logger.Error(ex, "Error al cargar trabajadores: FrmBonificaciones");
                Mensaje("Error al cargar trabajadores: " + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.SelectedItem == null || (cboEmpleados.SelectedItem is EmpleadosContratos seleccionado && seleccionado.Id == 0))
            {
                MessageBox.Show("Por favor seleccione un empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si hay una selección válida, se agrega al ListView
            EmpleadosContratos empleadoSeleccionado = (EmpleadosContratos)cboEmpleados.SelectedItem;

            // Evita duplicados en el ListView
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Tag is EmpleadosContratos emp && emp.Id == empleadoSeleccionado.Id)
                {
                    MessageBox.Show("Este empleado ya está en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Agregar al ListView
            ListViewItem nuevoItem = new ListViewItem(empleadoSeleccionado.Descripcion)
            {
                Tag = empleadoSeleccionado // Guardamos el objeto completo en Tag
            };
            listView1.Items.Add(nuevoItem);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(txtvalor, e);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                bool imponible = false;

                imponible = checkBox1.CheckState == CheckState.Checked ? true : false;
                DTO.Bonificaciones datos = new DTO.Bonificaciones();
                if (Validar()) return;
                datos.IdBonificacion = 0;
                datos.Descripcion = txtNombre.Text;
                datos.IdEmpresa = Sesion.UsuarioActual.IdEmpresa;
                datos.Monto = Convert.ToDecimal(txtvalor.Text);
                datos.FechaAplicacion = dttFAsignacion.Value;
                datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                datos.Asignados = ObtenerEmpleadosDelListView();
                datos.IdTarea = Convert.ToInt32(cboTareas.SelectedValue);
                datos.Imponible = imponible;

                datos.ParaEmpleado = datos.Asignados.Count > 0 ? true : false;

                DTO.Bonificaciones response = new BO.BOBeneficios().registrarBeneficio(datos);
                if (response.IdBonificacion > 0)
                {
                    Mensaje("Bonificacion registrada correctamente.");
                    cargarBonificacion(response);
                }
                else
                {

                    Mensaje("Error al registrar la bonificacion.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar la bonificacion: FrmBonificaciones");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void cargarBonificacion(DTO.Bonificaciones bonificaciones)
        {
            try
            {
                txtID.Text = bonificaciones.IdBonificacion.ToString();
                txtNombre.Text = bonificaciones.Descripcion;
                txtvalor.Text = bonificaciones.Monto.ToString("N0");
                dttFAsignacion.Value = bonificaciones.FechaAplicacion;
                cboEstado.SelectedValue = Convert.ToInt32(bonificaciones.Estado);
                btnIngresar.Enabled = false;
                btnActualizar.Enabled = true;
                cboTareas.SelectedValue = bonificaciones.IdTarea;
                checkBox1.CheckState = bonificaciones.Imponible ? CheckState.Checked : CheckState.Unchecked;

                if (bonificaciones.Asignados != null)
                {
                    listView1.Items.Clear();
                    foreach (EmpleadosContratos item in bonificaciones.Asignados)
                    {
                        // Agregar al ListView
                        ListViewItem nuevoItem = new ListViewItem(item.Descripcion)
                        {
                            Tag = item // Guardamos el objeto completo en Tag
                        };
                        listView1.Items.Add(nuevoItem);
                    }

                }

                //Mensaje("Trabajador cargado correctamente.");

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar bonificacion en formulario: FrmBonificaciones");
                Mensaje("Error al cargar bonificacion en formulario: " + ex.Message);
            }
        }

        private List<EmpleadosContratos> ObtenerEmpleadosDelListView()
        {
            List<EmpleadosContratos> empleadosList = new List<EmpleadosContratos>();

            // Iterar sobre los ítems del ListView
            foreach (ListViewItem item in listView1.Items)
            {
                // Obtener el objeto 'EmpleadosContratos' que se encuentra en el Tag
                if (item.Tag is EmpleadosContratos empleado)
                {
                    empleadosList.Add(empleado);
                }
            }

            return empleadosList;
        }

        private bool Validar()
        {
            List<string> errores = new List<string>();

            if (!Validaciones.ValidarRequerido(txtNombre.Text, "Nombre", out string mensajeError))
            {
                errores.Add(mensajeError);
            }

            if (!Validaciones.ValidarRequerido(txtvalor.Text, "Valor", out mensajeError))
            {
                errores.Add(mensajeError);
            }
            else if (decimal.TryParse(txtvalor.Text, out decimal valor))
            {
                if (valor <= 0)
                {
                    errores.Add("El valor debe ser mayor a 0.");
                }
            }
            else
            {
                errores.Add("El valor ingresado no es válido.");
            }

            if (errores.Count > 0)
            {
                Mensaje(string.Join("\n", errores));
                return true; // hay errores
            }

            return false; // validación exitosa
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtvalor.Text = "";
            dttFAsignacion.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
            cboTareas.SelectedIndex = 0;
            listView1.Items.Clear();
            btnIngresar.Enabled = true;
            btnActualizar.Enabled = false;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                bool imponible = false;

                imponible = checkBox1.CheckState == CheckState.Checked ? true : false;
                DTO.Bonificaciones datos = new DTO.Bonificaciones();
                if (Validar()) return;
                datos.IdBonificacion = Convert.ToInt32(txtID.Text);
                datos.Descripcion = txtNombre.Text;
                datos.IdEmpresa = Sesion.UsuarioActual.IdEmpresa;
                datos.Monto = Convert.ToDecimal(txtvalor.Text);
                datos.FechaAplicacion = dttFAsignacion.Value;
                datos.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                datos.Asignados = ObtenerEmpleadosDelListView();
                datos.IdTarea = Convert.ToInt32(cboTareas.SelectedValue);
                datos.Imponible = imponible;

                datos.ParaEmpleado = datos.Asignados.Count > 0 ? true : false;

                DTO.Bonificaciones response = new BO.BOBeneficios().registrarBeneficio(datos);
                if (response.IdBonificacion > 0)
                {
                    Mensaje("Bonificacion registrada correctamente.");
                    cargarBonificacion(response);
                }
                else
                {
                    Mensaje("Error al registrar la bonificacion.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar la bonificacion: FrmBonificaciones");
                Mensaje("Error: " + ex.Message);
            }
        }

        private void btnListadoTrabajadores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoBonificacion frmShow = new FrmListadoBonificacion();
                frmShow.ShowDialog();
                if (frmShow.selectBonificacion.IdBonificacion != 0)
                {
                    cargarBonificacion(frmShow.selectBonificacion);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Bonificacion en formulario: FrmBonificaciones");
                Mensaje("Error al cargar Listado de Bonificacion en formulario: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
