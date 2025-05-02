using iText.Html2pdf;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;


namespace PeopleFlow.Formularios.Contratos
{
    public partial class FrmAnexos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public DTO.Contrato.Contrato _contrato = new DTO.Contrato.Contrato();
        private bool cargando = true; // Variable de control
        public FrmAnexos()
        {
            InitializeComponent();
            StyleTable();
        }

        private void StyleTable()
        {
            // Configurar apariencia MaterialSkin para DGVCargos
            DGVAnexos.BackgroundColor = Color.White;
            DGVAnexos.BorderStyle = BorderStyle.None;
            DGVAnexos.EnableHeadersVisualStyles = false; // Permite cambiar el header
            DGVAnexos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            DGVAnexos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVAnexos.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold); // Fuente Material
            DGVAnexos.DefaultCellStyle.BackColor = Color.White;
            DGVAnexos.DefaultCellStyle.ForeColor = Color.Black;
            DGVAnexos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246); // Azul claro al seleccionar
            DGVAnexos.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGVAnexos.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
            DGVAnexos.GridColor = Color.LightGray; // Color de las líneas de separación

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmAnexos_Load(object sender, EventArgs e)
        {
            cargando = true;
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }

            cargarAnexos();

            cargando = false;

        }

        private void cargarAnexos()
        {
            List<DTO.Contrato.AnexoContrato> anexos = new List<DTO.Contrato.AnexoContrato>();
            try
            {
                anexos = new BO.BOContratos().GetAnexosContratos(_contrato.IdContrato);

                if (anexos == null || anexos.Count == 0)
                {
                    DGVAnexos.DataSource = null;
                    lblSinAnexos.Visible = true; // Mostrar mensaje
                                                 // Eliminar columnas personalizadas si existen
                    if (DGVAnexos.Columns.Contains("VerArchivo"))
                        DGVAnexos.Columns.Remove("VerArchivo");

                    if (DGVAnexos.Columns.Contains("EliminarArchivo"))
                        DGVAnexos.Columns.Remove("EliminarArchivo");
                }
                else
                {
                    DGVAnexos.DataSource = anexos;
                    DGVAnexos.Columns["Archivo"].Visible = false;
                    DGVAnexos.Columns["ArchivoB"].Visible = false;
                    DGVAnexos.Columns["Usuario"].Visible = false;
                    DGVAnexos.Columns["IdEmpresa"].Visible = false;
                    DGVAnexos.Columns["idAnexoContrato"].HeaderText = "N°";
                    DGVAnexos.Columns["IdContrato"].HeaderText = "N° Contrato";
                    DGVAnexos.Columns["FechaReg"].HeaderText = "Fecha Ingreso";
                    // Evitar duplicar columnas si ya fueron agregadas antes
                    if (DGVAnexos.Columns["VerArchivo"] == null)
                    {
                        DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                        btnVer.Name = "VerArchivo";
                        btnVer.HeaderText = "Ver";
                        btnVer.Text = "Ver";
                        btnVer.UseColumnTextForButtonValue = true;
                        DGVAnexos.Columns.Add(btnVer);
                    }

                    if (DGVAnexos.Columns["EliminarArchivo"] == null)
                    {
                        DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                        btnEliminar.Name = "EliminarArchivo";
                        btnEliminar.HeaderText = "Eliminar";
                        btnEliminar.Text = "Eliminar";
                        btnEliminar.UseColumnTextForButtonValue = true;
                        DGVAnexos.Columns.Add(btnEliminar);
                    }

                    DGVAnexos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    

                    DGVAnexos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGVAnexos.Columns[0].Width = 40;

                    lblSinAnexos.Visible = false; // Ocultar mensaje si hay datos
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Listado de Anexocontrato en formulario: FrmAnexos");
                Mensaje("Error al cargar Listado: " + ex.Message);
            }
        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
                logger.Error(ex, "Error al seleccionar Archivo: FrmAnexos");
                Mensaje("Error al seleccionar Archivo: " + ex.Message);
            }
        }

        private void DGVAnexos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar encabezados
            if (e.RowIndex < 0) return;

            string columna = DGVAnexos.Columns[e.ColumnIndex].Name;

            // Obtener el objeto AnexoContrato de la fila
            var anexo = DGVAnexos.Rows[e.RowIndex].DataBoundItem as DTO.Contrato.AnexoContrato;

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
                        new BO.BOContratos().DeleteAnexo(anexo.idAnexoContrato);

                        // Recargar la lista
                        cargarAnexos();
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

                DTO.Contrato.AnexoContrato datos = new DTO.Contrato.AnexoContrato
                {
                    idAnexoContrato = 0,
                    IdContrato = _contrato.IdContrato,
                    Titulo = txtDetallenombre.Text,
                    Archivo = rutaPdf, // guardar HTML en esta variable
                    ArchivoB = pdfBytes
                };

                DTO.Contrato.AnexoContrato response = new BO.BOContratos().RegistroAnexosContratos(datos);
                if (response.idAnexoContrato > 0)
                {
                    Mensaje("Anexo registrado correctamente.");
                    cargarAnexos();
                    txtDetallenombre.Text = "";
                    txtNombreArchivo.Text = "";
                }
                else
                {
                    Mensaje("Error al registrar el Anexo.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al registrar el Anexo Archivo: FrmAnexos");
                Mensaje("Error: " + ex.Message);
            }
        }


        public string ConvertirPdfAHtml(string rutaPdf)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html><head><meta charset='utf-8'><style>");
            sb.AppendLine("body { font-family: Arial, sans-serif; font-size: 14px; line-height: 1.5; padding: 20px; }");
            sb.AppendLine(".page { margin-bottom: 30px; border-bottom: 1px solid #eee; padding-bottom: 30px; }");
            sb.AppendLine(".title { font-size: 18px; font-weight: bold; text-align: center; margin: 20px 0; }");
            sb.AppendLine(".subtitle { font-size: 16px; font-weight: bold; margin: 15px 0; }");
            sb.AppendLine("p { margin: 0 0 10px 0; }");
            sb.AppendLine(".bold { font-weight: bold; }");
            sb.AppendLine(".italic { font-style: italic; }");
            sb.AppendLine("table { border-collapse: collapse; width: 100%; margin: 15px 0; }");
            sb.AppendLine("td, th { border: 1px solid #ddd; padding: 8px; }");
            sb.AppendLine("</style></head><body>");

            using (PdfDocument pdf = PdfDocument.Open(rutaPdf))
            {
                foreach (Page page in pdf.GetPages())
                {
                    sb.AppendLine("<div class='page'>");

                    var letters = page.Letters; // Obtiene los caracteres con posición y estilo

                    // Agrupa por líneas (basado en posición Y)
                    var lineGroups = letters.GroupBy(l => Math.Round(l.Location.Y, 1));

                    foreach (var line in lineGroups.OrderByDescending(g => g.Key))
                    {
                        var orderedLetters = line.OrderBy(l => l.Location.X);
                        var lineText = string.Join("", orderedLetters.Select(l => l.Value));

                        if (string.IsNullOrWhiteSpace(lineText)) continue;

                        // Detección simple de estilos
                        bool isBold = orderedLetters.Any(l => l.FontName?.ToLower().Contains("bold") ?? false);
                        bool isTitle = orderedLetters.All(l => l.FontSize > 14);
                        bool isCentered = IsCentered(line, page.Width);

                        // Aplicar clases según detección
                        if (isTitle && isCentered)
                        {
                            sb.AppendLine($"<div class='title'>{WebUtility.HtmlEncode(lineText)}</div>");
                        }
                        else if (isBold && lineText.Trim().Length < 50) // Asumimos que es un encabezado
                        {
                            sb.AppendLine($"<div class='subtitle'>{WebUtility.HtmlEncode(lineText)}</div>");
                        }
                        else
                        {
                            var tag = isBold ? "<strong>" : "";
                            var closeTag = isBold ? "</strong>" : "";
                            sb.AppendLine($"<p>{tag}{WebUtility.HtmlEncode(lineText)}{closeTag}</p>");
                        }
                    }

                    sb.AppendLine("</div>");
                }
            }

            sb.AppendLine("</body></html>");
            return sb.ToString();
        }

        private bool IsCentered(IGrouping<double, Letter> line, double pageWidth)
        {
            if (!line.Any()) return false;

            var firstChar = line.OrderBy(l => l.Location.X).First();
            var lastChar = line.OrderByDescending(l => l.Location.X).First();

            var textWidth = lastChar.Location.X + lastChar.Width - firstChar.Location.X;
            var leftMargin = firstChar.Location.X;
            var rightMargin = pageWidth - lastChar.Location.X - lastChar.Width;

            // Consideramos centrado si los márgenes son similares
            return Math.Abs(leftMargin - rightMargin) < 10;
        }
    }
}
