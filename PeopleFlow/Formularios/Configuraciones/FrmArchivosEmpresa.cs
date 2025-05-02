using NLog;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFlow.Formularios.Configuraciones
{
    public partial class FrmArchivosEmpresa : Form
    {
        private bool cargando = true; // Variable de control
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmArchivosEmpresa()
        {
            InitializeComponent();
            StyleTable();
        }
        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVArchivos.BackgroundColor = Color.White;
            DGVArchivos.BorderStyle = BorderStyle.None;
            DGVArchivos.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVArchivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVArchivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVArchivos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVArchivos.DefaultCellStyle.BackColor = Color.White;
            DGVArchivos.DefaultCellStyle.ForeColor = Color.Black;
            DGVArchivos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVArchivos.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVArchivos.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVArchivos.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArchivosEmpresa_Load(object sender, EventArgs e)
        {
            cargando = true;
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            cargarArchivo();

            cargando = false;
        }

        private void cargarArchivo()
        {
            List<ArchivosEmpresa> archivos = new List<ArchivosEmpresa>();
            try
            {
                archivos = new BO.BOUsuarios().GetArchivosEmpresa();

                if (archivos == null || archivos.Count == 0)
                {
                    DGVArchivos.DataSource = null;
                    lblSinAnexos.Visible = true; // Mostrar mensaje
                                                 // Eliminar columnas personalizadas si existen
                    if (DGVArchivos.Columns.Contains("VerArchivo"))
                        DGVArchivos.Columns.Remove("VerArchivo");

                    if (DGVArchivos.Columns.Contains("EliminarArchivo"))
                        DGVArchivos.Columns.Remove("EliminarArchivo");
                }
                else
                {
                    DGVArchivos.DataSource = archivos;
                    DGVArchivos.Columns["Archivo"].Visible = false;
                    DGVArchivos.Columns["ArchivoB"].Visible = false;
                    DGVArchivos.Columns["Usuario"].Visible = false;
                    DGVArchivos.Columns["IdEmpresa"].Visible = false;
                    DGVArchivos.Columns["idArchivos"].HeaderText = "N°";
                    DGVArchivos.Columns["FechaReg"].HeaderText = "Fecha Ingreso";
                    // Evitar duplicar columnas si ya fueron agregadas antes
                    if (DGVArchivos.Columns["VerArchivo"] == null)
                    {
                        DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                        btnVer.Name = "VerArchivo";
                        btnVer.HeaderText = "Ver";
                        btnVer.Text = "Ver";
                        btnVer.UseColumnTextForButtonValue = true;
                        DGVArchivos.Columns.Add(btnVer);
                    }

                    if (DGVArchivos.Columns["EliminarArchivo"] == null)
                    {
                        DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                        btnEliminar.Name = "EliminarArchivo";
                        btnEliminar.HeaderText = "Eliminar";
                        btnEliminar.Text = "Eliminar";
                        btnEliminar.UseColumnTextForButtonValue = true;
                        DGVArchivos.Columns.Add(btnEliminar);
                    }

                    DGVArchivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                    DGVArchivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGVArchivos.Columns[0].Width = 40;

                    lblSinAnexos.Visible = false; // Ocultar mensaje si hay datos
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado: FrmArchivosEmpresa");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Seleccionar archivo PDF";
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFileDialog.FileName;

                    // Validar que la extensión sea .pdf por seguridad
                    if (System.IO.Path.GetExtension(rutaArchivo).ToLower() == ".pdf")
                    {
                        MessageBox.Show("Archivo seleccionado: " + rutaArchivo);
                        txtNombreArchivo.Text = rutaArchivo;
                        // Aquí puedes continuar con la conversión o procesamiento
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona un archivo PDF válido.");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al seleccionar Archivo: FrmArchivosEmpresa");
                Mensaje("Error al seleccionar Archivo: " + ex.Message);
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar encabezados
            if (e.RowIndex < 0) return;

            string columna = DGVArchivos.Columns[e.ColumnIndex].Name;

            // Obtener el objeto AnexoContrato de la fila
            var anexo = DGVArchivos.Rows[e.RowIndex].DataBoundItem as ArchivosEmpresa;

            if (columna == "VerArchivo")
            {
                if (anexo != null && anexo.ArchivoB != null && anexo.ArchivoB.Length > 0)
                {
                    try
                    {
                        // Crear un nombre de archivo temporal único
                        string tempFilePath = Path.Combine(Path.GetTempPath(), $"Anexo_.pdf");

                        if (File.Exists(tempFilePath))
                        {
                            File.Delete(tempFilePath);
                        }

                        // Guardar el binario a un archivo temporal
                        File.WriteAllBytes(tempFilePath, anexo.ArchivoB);

                        // Verificar que el archivo se creó correctamente
                        if (File.Exists(tempFilePath))
                        {
                            // Abrir el PDF con el visor predeterminado del sistema
                            Process.Start(new ProcessStartInfo(tempFilePath)
                            {
                                UseShellExecute = true
                            });
                        }
                        else
                        {
                            throw new Exception("No se pudo crear el archivo temporal.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar errores adecuadamente
                        MessageBox.Show($"Error al abrir el archivo: {ex.Message}",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe o está vacío.",
                                   "Advertencia",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                }
            }
            else if (columna == "EliminarArchivo")
            {
                if (anexo != null)
                {
                    var confirm = MessageBox.Show("¿Deseas eliminar este archivo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        // Aquí llamas a tu lógica de negocio para eliminarlo, por ejemplo:
                        new BO.BOUsuarios().EliminarArchivo(anexo.idArchivos);

                        // Recargar la lista
                        cargarArchivo();
                    }
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir PDF a HTML
                string rutaPdf = txtNombreArchivo.Text;
                //string htmlGenerado = ConvertirPdfAHtml(rutaPdf); // usa el método mostrado arriba
                byte[] pdfBytes = File.ReadAllBytes(rutaPdf);

                ArchivosEmpresa datos = new ArchivosEmpresa
                {
                    idArchivos = 0,
                    Titulo = txtDetallenombre.Text,
                    Archivo = rutaPdf, // guardar HTML en esta variable
                    ArchivoB = pdfBytes
                };

                ArchivosEmpresa response = new BO.BOUsuarios().RegistroArchivoEmpresa(datos);
                if (response.idArchivos > 0)
                {
                    Mensaje("Archivo registrado correctamente.");
                    cargarArchivo();
                    txtDetallenombre.Text = "";
                    txtNombreArchivo.Text = "";
                }
                else
                {
                    Mensaje("Error al registrar el Archivo.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar el Archivo: FrmArchivosEmpresa");
                Mensaje("Error: " + ex.Message);
            }
        }
    }
}
