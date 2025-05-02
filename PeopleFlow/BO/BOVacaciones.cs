using iText.Html2pdf;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BOVacaciones
    {
        public Vacaciones registroVacaciones(Vacaciones datos)
        {
            Vacaciones response = new Vacaciones();
            try
            {
                response = new DAO.VacacionesDAO().registroVacaciones(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public void EliminarVacaciones(int IDVacaciones)
        {
            new DAO.VacacionesDAO().EliminarVacaciones(IDVacaciones);
        }

        public List<Vacaciones> GetVacacionesEmpresa()
        {
            return new DAO.VacacionesDAO().GetVacacionesEmpresa();
        }

        public Vacaciones GetVacacionesByID(int IDVacaciones)
        {
            return new DAO.VacacionesDAO().GetVacacionesByID(IDVacaciones);
        }

        public Vacaciones GetVacacionesByIDUltima(int IDEmpleado)
        {
            return new DAO.VacacionesDAO().GetVacacionesByIDUltima(IDEmpleado);
        }
        public SaldoVacacionesResult ObtenerSaldoVacacionesChile(int IDEmpleado)
        {
            return new DAO.VacacionesDAO().GetSaldoVacaciones(IDEmpleado);
        }


        public void GENERARPDFVACACION(Vacaciones vacaciones, string rutaArchivo)
        {
            try
            {
                string plantilla = "";
                DocumentosPlantilla plantillaObj = new DocumentosPlantilla();
                plantillaObj = new DAO.VacacionesDAO().GetVacacionesPlanilla();

                plantilla = plantillaObj.planilla;

                var datosTrabajador = CambioDatos(vacaciones);

                plantilla = GenerarContratoPersonalizado(plantilla, datosTrabajador);

                // Crear un archivo temporal para el PDF
                string tempFilePath = Path.GetTempFileName();

                // Convertir el HTML a PDF y guardarlo en el archivo temporal
                HtmlConverter.ConvertToPdf(plantilla, new FileStream(tempFilePath, FileMode.Create));

                // Mover el archivo temporal a la ubicación final
                File.Move(tempFilePath, rutaArchivo, overwrite: true);

                // Verificar que el PDF se generó correctamente antes de abrirlo
                if (File.Exists(rutaArchivo))
                {
                    Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
                }
                else
                {
                    throw new Exception("No se pudo generar el archivo PDF.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
                throw;
            }
        }

        public string GenerarContratoPersonalizado(string plantilla, Dictionary<string, string> datos)
        {
            foreach (var item in datos)
            {
                plantilla = plantilla.Replace("[[" + item.Key + "]]", item.Value);
            }
            return plantilla;
        }

        private Dictionary<string, string> CambioDatos(Vacaciones vacaciones)
        {
            var datosTrabajador = new Dictionary<string, string>();
            Empresas empresa = new Empresas();
            Empleados empleados = new Empleados();
            Jornadas jornada = new Jornadas();
            Contrato contrato = new Contrato();
            Tareas tareas = new Tareas();

            try
            {
                empresa = new DAO.EmpresasDAO().GetEmpresasbyID(Sesion.UsuarioActual.IdEmpresa);
                empleados = new BO.BOEmpleados().GetEmpleadosById(vacaciones.IdEmpleado);
                contrato = new BO.BOContratos().getContratoTrabajador(vacaciones.IdEmpleado);
                tareas = new BO.BOTareas().cargarTareaByID(contrato.IdTarea);
                jornada = new BO.BOTareas().cargarJornadaByID(tareas.IdJornada);


                datosTrabajador = new Dictionary<string, string>
                {
                    { "FECHAACTUAL", DateTime.Now.ToString("dd/MM/yyyy") },
                    { "NOMBRETRABAJADOR", empleados.Nombre + " " + empleados.Apellido},
                    { "RUTTRABAJADOR", empleados.Rut },
                    { "IDVACACION", vacaciones.idVacaciones.ToString() },
                    { "FECHAINGRESO", contrato.FechaInicio.ToString("dd/MM/yyyy") },
                    { "DIRECCIONEMPLEADOR", empresa.Direccion },
                    { "NOMBREEMPLEADOR", empresa.Nombre },
                    { "RUTEMPLEDOR", empresa.RUT },
                    { "CARGO", contrato.Cargo },
                    { "CANTDIAS", vacaciones.CantDias.ToString() },
                    { "FECHAINICIO", vacaciones.FechaIni.ToString("dd/MM/yyyy") },
                    { "FECHAFIN", vacaciones.FechaFin.ToString("dd/MM/yyyy") },
                    { "FECHARETORNO", vacaciones.Fecha_Retorno.ToString("dd/MM/yyyy") },
                };
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo generar el cambio de informacion.");
            }

            return datosTrabajador;
        }
    }
}
