using MaterialSkin.Controls;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.Formularios;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media.TextFormatting;

namespace PeopleFlow
{
    public partial class PeopleFlow : MaterialForm
    {
        public PeopleFlow()
        {
            InitializeComponent();
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.Size = new System.Drawing.Size(325, 412);
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PeopleFlow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtuser;
            cargarEmpresas();
            txtuser.Focus();
        }

        private void cargarEmpresas()
        {
            List<DTO.Empresas> empresas = new List<DTO.Empresas>();

            empresas = new DAO.EmpresasDAO().GetEmpresas();

            cboEmpresas.DataSource = empresas;
            cboEmpresas.DisplayMember = "Nombre";
            cboEmpresas.ValueMember = "IdEmpresa";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            // Botón de inicio de sesión en PeopleFlow
            string usuario = txtuser.Text;
            string password = txtpass.Text;
            int idEmpresa = Convert.ToInt32(cboEmpresas.SelectedValue);

            DTO.Usuarios Login = new BO.BOUsuarios().login(usuario, idEmpresa);

            if (Login != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, Login.Contraseña))
                {
                    // Contraseña válida
                    Sesion.UsuarioActual = Login;
                    this.DialogResult = DialogResult.OK; // Indicar éxito
                    this.Close();
                }
                else
                {
                    // Contraseña incorrecta
                    Mensaje("Error: Contraseña incorrecta.");
                }
                
            }
            else
            {
                Mensaje("Error: Usuario, contraseña o Empresa son incorrectos.");
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }
    }
}
