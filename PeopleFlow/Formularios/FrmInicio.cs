using Aspose.Pdf.LogicalStructure;
using MaterialSkin;
using MaterialSkin.Controls;
using NLog;
using PeopleFlow.DTO;
using PeopleFlow.Formularios.Configuraciones;
using PeopleFlow.Formularios.Dashboard;
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
    public partial class FrmInicio : MaterialForm
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private Usuarios usuarioActual;
        public FrmInicio()
        {
            InitializeComponent();
            FormStyke();
        }

        private void FormStyke()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            lblNombreUser.BackColor = Color.Transparent;
            lblCargo.BackColor = Color.Transparent;
            lblNombreUser.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            lblCargo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            pictureBox4.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (STATE)
            {
                usuarioActual = Sesion.UsuarioActual;
                lblNombreUser.Text = usuarioActual.Nombres + " " + usuarioActual.Apellidos;
                lblCargo.Text = usuarioActual.Cargo;
                AbrirFormHijo(new FrmDashboard());
            }
            else
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
        }


        #region controles
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D; // Efecto de clic
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None; // Restaurar el efecto
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D; // Efecto de clic
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None; // Restaurar el efecto
        }

        private void HPnael_MouseEnter(object sender, EventArgs e)
        {
            HPnael.BackColor = Color.LightGray;
        }

        private void HPnael_MouseLeave(object sender, EventArgs e)
        {
            HPnael.BackColor = SystemColors.Control;
        }

        private void HPnael_MouseDown(object sender, MouseEventArgs e)
        {
            HPnael.BackColor = Color.Gray;
        }

        private void HPnael_MouseUp(object sender, MouseEventArgs e)
        {
            HPnael.BackColor = Color.LightGray;
        }

        private void CPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CPanel.BackColor = Color.Gray;
        }

        private void CPanel_MouseEnter(object sender, EventArgs e)
        {
            CPanel.BackColor = Color.LightGray;
        }

        private void CPanel_MouseLeave(object sender, EventArgs e)
        {
            CPanel.BackColor = SystemColors.Control;
        }

        private void CPanel_MouseUp(object sender, MouseEventArgs e)
        {
            CPanel.BackColor = Color.LightGray;
        }

        private void TPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TPanel.BackColor = Color.Gray;
        }

        private void TPanel_MouseEnter(object sender, EventArgs e)
        {
            TPanel.BackColor = Color.LightGray;
        }

        private void TPanel_MouseLeave(object sender, EventArgs e)
        {
            TPanel.BackColor = SystemColors.Control;
        }

        private void TPanel_MouseUp(object sender, MouseEventArgs e)
        {
            TPanel.BackColor = Color.LightGray;
        }

        private void TAPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TAPanel.BackColor = Color.Gray;
        }

        private void TAPanel_MouseEnter(object sender, EventArgs e)
        {
            TAPanel.BackColor = Color.LightGray;
        }

        private void TAPanel_MouseLeave(object sender, EventArgs e)
        {
            TAPanel.BackColor = SystemColors.Control;
        }

        private void TAPanel_MouseUp(object sender, MouseEventArgs e)
        {
            TAPanel.BackColor = Color.LightGray;
        }

        private void LPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LPanel.BackColor = Color.Gray;
        }

        private void LPanel_MouseEnter(object sender, EventArgs e)
        {
            LPanel.BackColor = Color.LightGray;
        }

        private void LPanel_MouseLeave(object sender, EventArgs e)
        {
            LPanel.BackColor = SystemColors.Control;
        }

        private void LPanel_MouseUp(object sender, MouseEventArgs e)
        {
            LPanel.BackColor = Color.LightGray;
        }

        private void DPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DPanel.BackColor = Color.Gray;
        }

        private void DPanel_MouseEnter(object sender, EventArgs e)
        {
            DPanel.BackColor = Color.LightGray;
        }

        private void DPanel_MouseLeave(object sender, EventArgs e)
        {
            DPanel.BackColor = SystemColors.Control;
        }

        private void DPanel_MouseUp(object sender, MouseEventArgs e)
        {
            DPanel.BackColor = Color.LightGray;
        }

        private void BPanel_MouseDown(object sender, MouseEventArgs e)
        {
            BPanel.BackColor = Color.Gray;
        }

        private void BPanel_MouseEnter(object sender, EventArgs e)
        {
            BPanel.BackColor = Color.LightGray;
        }

        private void BPanel_MouseLeave(object sender, EventArgs e)
        {
            BPanel.BackColor = SystemColors.Control;
        }

        private void BPanel_MouseUp(object sender, MouseEventArgs e)
        {
            BPanel.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#212b62");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3f51b5");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#212b62");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#3f51b5");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //panel1.BackColor = Color.Gray;
            panel1.BackColor = Color.DarkBlue;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.LightGray;
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#212b62");
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //panel1.BackColor = SystemColors.Control;
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            //panel1.BackColor = Color.LightGray;
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //panel2.BackColor = Color.Gray;
            panel2.BackColor = Color.DarkBlue;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            //panel2.BackColor = Color.LightGray;
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#212b62");
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            //panel2.BackColor = SystemColors.Control;
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            //panel2.BackColor = Color.LightGray;
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            //panel3.BackColor = Color.Gray;
            panel3.BackColor = Color.DarkBlue;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            //panel3.BackColor = Color.LightGray;
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#212b62");
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            //panel3.BackColor = SystemColors.Control;
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
        }

        private void pictureBox13_MouseUp(object sender, MouseEventArgs e)
        {
            //panel3.BackColor = Color.LightGray;
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#303f9f");
        }


        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Botón de cerrar sesión en FrmInicio
            Sesion.UsuarioActual = null;

            this.Close(); // Cierra FrmInicio, lo que reiniciará el login en Program.cs
        }

        private void AbrirFormHijo(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            panelContenedor.AutoScrollMinSize = new Size(formHijo.Width, formHijo.Height);
            // Manejar el evento FormClosed
            formHijo.FormClosed += (s, args) =>
            {
                AbrirFormHijo(new FrmDashboard());
            };

        }

        private void HPnael_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmDashboard());
        }

        private void TPanel_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmEmpleados());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmContratos());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmTareas());
        }

        private void LPanel_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmLiquidaciones());
        }

        private void DPanel_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmDeducciones());
        }

        private void BPanel_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmBonificaciones());
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FrmGraficos frmShow = new FrmGraficos();
            //frmShow.Tarea = SelectEmplAsig;
            frmShow.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MenuConfiguraciones.Show(panel2, panel2.PointToClient(Cursor.Position));
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FrmVacaciones frmShow = new FrmVacaciones();
            //frmShow.Tarea = SelectEmplAsig;
            frmShow.ShowDialog();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmUsuarios());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmMiPerfil());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmMiPerfil());
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmInformaciones());
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmCargos());
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmJornadas());
        }

        private void documentosEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmArchivosEmpresa());
        }

        private void finiquitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmListadoFiniquitos());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
            pictureBox13.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent; 
            label10.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            pictureBox11.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            pictureBox12.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }
    }
}
