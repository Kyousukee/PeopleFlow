using NLog;
using NLog.Config;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using PeopleFlow.Formularios;

namespace PeopleFlow
{
    internal static class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void IniciarAplicacion()
        {
            bool loginExitoso = false;

            while (!loginExitoso)
            {
                using (PeopleFlow frmLogin = new PeopleFlow())
                {
                    if (frmLogin.ShowDialog() == DialogResult.OK)
                    {
                        loginExitoso = true;
                        FrmInicio frmInicio = new FrmInicio();
                        Application.Run(frmInicio);

                        // Si se cierra FrmInicio (cerrar sesión), volver al login
                        loginExitoso = false;
                    }
                    else
                    {
                        return; // Salir de la aplicación si el login se cierra sin autenticarse
                    }
                }
            }
        }

        [STAThread]
        static void Main()
        {
            // Habilitar log interno para ver errores si los hay
            NLog.Common.InternalLogger.LogToConsole = true;
            NLog.Common.InternalLogger.LogLevel = NLog.LogLevel.Trace;

            // Inicializar NLog
            //DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySqlClientFactory.Instance);
            try
            {
                LogManager.Setup().LoadConfigurationFromFile("Nlog.config");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inicializando logger: " + ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IniciarAplicacion();
        }
    }
}
