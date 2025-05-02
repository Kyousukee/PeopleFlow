using iText.Kernel.Pdf;
using iText.Layout;
using iText.Html2pdf;
using iText.Layout.Element;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.Tareas.Tareas;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PeopleFlow.BO
{
    public class BOContratos
    {
        public List<TipoContrato> cargarTipoContratos()
        {
            List<TipoContrato> response = new List<TipoContrato>();
            try
            {
                
                response = new DAO.ContratosDAO().GetTipoContratos();
                response.Add(new TipoContrato { IdTipoContrato = 0, Descripcion = "Seleccione" });
                response = response.OrderBy(x => x.IdTipoContrato).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Plazos> cargarPlazos()
        {
            List<Plazos> response = new List<Plazos>();
            try
            {
                
                response = new DAO.ContratosDAO().GetPlazos();
                response.Add(new Plazos { IdPlazo = 0, Descripcion = "Seleccione" });
                response = response.OrderBy(x => x.IdPlazo).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Contrato getContratoTrabajador( int id_trabajador)
        {
            Contrato response = new Contrato();
            try
            {
                response = new DAO.ContratosDAO().GetContratoTrabajador(id_trabajador);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
        public List<FiniquitoTipoDetalle> GetTipoDetalleFiniquito()
        {
            List<FiniquitoTipoDetalle> response = new List<FiniquitoTipoDetalle>();
            try
            {
                response = new DAO.ContratosDAO().GetTipoDetalleFiniquito();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<AnexoContrato> GetAnexosContratos(int IdContrato)
        {
            List<AnexoContrato> response = new List<AnexoContrato>();
            try
            {
                response = new DAO.ContratosDAO().GetAnexosContratos(IdContrato);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<DetalleFiniquito> GetDetalleFiniquito(int IdFiniquito)
        {
            List<DetalleFiniquito> response = new List<DetalleFiniquito>();
            try
            {
                response = new DAO.ContratosDAO().GetDetalleFiniquito(IdFiniquito);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TipoFiniquito> GetTipoFiniquito()
        {
            List<TipoFiniquito> response = new List<TipoFiniquito>();
            try
            {
                response = new DAO.ContratosDAO().GetTipoFiniquito();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
        public void GENERARPDFCONTRATO(Contrato contrato, string rutaArchivo,List<Tareas> tareas)
        {
            try
            {
                string plantilla = "";
                List<TipoContrato> tipoPago = cargarTipoContratos();
                TipoContrato selectTipoContrato = tipoPago.FirstOrDefault(x => x.IdTipoContrato == contrato.IdTipoContrato);
                var datosTrabajador = CambioDatos(contrato, selectTipoContrato, tareas.FirstOrDefault(o => o.IdTarea==contrato.IdTarea));

                plantilla = GenerarContratoPersonalizado(selectTipoContrato.Planilla, datosTrabajador);

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

        public void GENERARPDFFINIQUITO(Contrato contrato, string rutaArchivo, Finiquito finiquito, TipoFiniquito tipoFiniquito)
        {
            try
            {
                string plantilla = "";
                DocumentosPlantilla plantillaObj = new DocumentosPlantilla();
                plantillaObj = new DAO.ContratosDAO().GetFiniquitoPlanilla();

                plantilla = plantillaObj.planilla;

                var datosFiniquito = CambioDatosFiniquito(contrato, finiquito,tipoFiniquito);

                plantilla = GenerarContratoPersonalizado(plantilla, datosFiniquito);

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

        private Dictionary<string, string> CambioDatosFiniquito(Contrato contrato, Finiquito finiquito, TipoFiniquito tipoFiniquito)
        {
            var datosFiniquito = new Dictionary<string, string>();
            Empresas empresa = new Empresas();
            Empleados empleados = new Empleados();
            try
            {
                empleados = new BO.BOEmpleados().GetEmpleadosRut(contrato.Rut.Substring(0, 8));
                empresa = new DAO.EmpresasDAO().GetEmpresasbyID(Sesion.UsuarioActual.IdEmpresa);

                string tablaValores = @"
                <table style=""border-collapse: collapse; font-family: monospace; width: 100%;"">
                <tr>
                    <th style=""border-bottom: 2px solid black; text-align: left;"">CONCEPTO</th>
                    <th style=""border-bottom: 2px solid black; text-align: left;"">MONTO</th>
                </tr>
                [[FILAS]]
                </table>";

                                string FILAS = "";

                                foreach (var b in finiquito.detalleFiniquitos)
                                {
                                    FILAS += $@"
                <tr>
                    <td style='padding: 5px 10px; text-align: left;'>{b.Descripcion}</td>
                    <td style='padding: 5px 10px; text-align: left;'>${b.Monto:N0}</td>
                </tr>";
                }

                tablaValores = tablaValores.Replace("[[FILAS]]", FILAS);






                //string bonificacionesHTML = ReturnBonificaciones(bonificaciones);

                datosFiniquito = new Dictionary<string, string>
                {
                    { "CIUDAD", "Rancagua" },
                    { "FECHA", DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-ES")) }, // <-- Formato corregido
                    { "RAZON_SOCIAL", empresa.Nombre },
                    { "RUT_EMPLEADOR", empresa.RUT },
                    { "DIRECCION_EMPLEADOR", empresa.Direccion },
                    { "NOMBRE_TRABAJADOR", empleados.Nombre + " " + empleados.Apellido },
                    { "RUT_TRABAJADOR", empleados.Rut },
                    { "DIRECCION_TRABAJADOR", empleados.Direccion },
                    { "NACIONALIDAD", empleados.Nacionalidad },
                    { "FECHA_NACIMIENTO", empleados.FechaNacimiento.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-ES")) },
                    { "CARGO", contrato.Cargo },
                    { "FINICIOCONTRATO", contrato.FechaInicio.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-ES")) },
                    { "FECHA_FIN", finiquito.FechaFiniquito.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-ES")) },
                    { "CAUSA_FINIQUITO", tipoFiniquito.Descripcion },
                    { "ARTICULO", tipoFiniquito.Articulo.ToString() },
                    { "TABLADETALLEINDEMNIZACION", tablaValores },
                };
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo generar el cambio de informacion.");
            }

            return datosFiniquito;
        }

        private Dictionary<string, string> CambioDatos(Contrato contrato, TipoContrato tipoContrato,Tareas tarea)
        {
            var datosTrabajador = new Dictionary<string, string>();
            Empresas empresa = new Empresas(); 
            Empleados empleados = new Empleados();
            Jornadas jornada = new Jornadas();
            try
            {
                empleados = new BO.BOEmpleados().GetEmpleadosRut(contrato.Rut.Substring(0, 8));
                empresa = new DAO.EmpresasDAO().GetEmpresasbyID(Sesion.UsuarioActual.IdEmpresa);
                jornada = new BO.BOTareas().cargarJornadasById(tarea.IdJornada);

                List<Bonificaciones> bonificaciones = new DAO.ContratosDAO().GetBonificacionesEmpresaEmpleado(empleados.IdEmpleado);

                string TipoPago = "";

                TipoPago = TipoPagoContrato(tarea);

                string bonificacionesHTML = ReturnBonificaciones(bonificaciones);

                datosTrabajador = new Dictionary<string, string>
                {
                    { "CIUDAD", "Rancagua" },
                    { "DIA", contrato.FechaInicio.ToString("dddd", new CultureInfo("es-ES")) + " " + contrato.FechaInicio.Day.ToString() },
                    { "MES", contrato.FechaInicio.ToString("MMMM", new CultureInfo("es-ES")) },
                    { "YEAR", contrato.FechaInicio.Year.ToString() },
                    { "RAZON_SOCIAL", empresa.Nombre },
                    { "RUT_EMPRESA", empresa.RUT },
                    { "NOMBRE_ENCAEGADO", Sesion.UsuarioActual.Nombres + " " + Sesion.UsuarioActual.Apellidos },
                    { "RUT_ENCARGADO", Sesion.UsuarioActual.Rut },
                    { "CARGO_ENCARGADO", Sesion.UsuarioActual.Cargo },
                    { "DIRECCION_ACUERDO", empresa.Direccion },
                    { "CORREO_ENCARGADO", Sesion.UsuarioActual.Correo },
                    { "NOMBRE_TRABAJADOR", empleados.Nombre + " " + empleados.Apellido },
                    { "RUT_TRABAJADOR", empleados.Rut },
                    { "FECHA_NACIMIENTOT", empleados.FechaNacimiento.Date.ToString("dd-MM-yyyy") },
                    { "NACIONALIDAD", empleados.Nacionalidad },
                    { "PROFESION", empleados.Profesion },
                    { "ESTADO_CIVIL", empleados.EstadoCivil },
                    { "DIRECCION_EMPLEADO", empleados.Direccion },
                    { "CORREO_EMPLEADO", empleados.Correo },
                    { "TAREA_ASIGNADA", tarea.Titulo },
                    { "HORAS_SEMANALES", jornada.HorasSemanales.ToString() },
                    { "DIA_INICIO", jornada.DiaComienzo },
                    { "DIA_TERMINO", jornada.DiaTermino },
                    { "HORA_INICIO", jornada.HoraInSemana },
                    { "HORA_TERMINO", jornada.HoraOutSemana },
                    { "HORARIO_FINDESEMANA", "y el fin de semana: " + jornada.HoraInFinSemana + " a " + jornada.HoraOutFinSemana},
                    { "TIPO_PAGO", TipoPago },
                    { "BENEFICIOS", bonificacionesHTML },
                    { "FECHA_FIN", contrato.FechaFin.Date.ToString("dd-MM-yyyy") },
                    { "FECHA_INICIO", contrato.FechaInicio.Date.ToString("dd-MM-yyyy") },
                    { "NEJEMPLARES", "3" },
                    { "BANCO", empleados.Banco },
                    { "TIPOCUENTA", empleados.TipoCuenta + " " + empleados.NumeroCuenta },
                    { "NUMEROCUENTA", empleados.NumeroCuenta },
                    { "AFP", empleados.AFP },
                    { "SALUD", empleados.Salud },
                    { "DESCRIPCIONHORARIOPARTTIME", "" }
                };
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo generar el cambio de informacion.");
            }
            
            return datosTrabajador;
        }

        public string ReturnBonificaciones(List<Bonificaciones> datos)
        {
            string bonificacionesHTML = "";
            try
            {
                bonificacionesHTML = "<table border='1' style='border-collapse: collapse; width: 100%; text-align: left;'>";
                bonificacionesHTML += "<tr><th style='padding: 5px;'>Descripción</th><th style='padding: 5px;'>Valor</th></tr>";

                foreach (var bono in datos)
                {
                    bonificacionesHTML += $"<tr><td style='padding: 5px;'>{bono.Descripcion}</td><td style='padding: 5px;'>${bono.Monto}</td></tr>";
                }

                bonificacionesHTML += "</table>";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return bonificacionesHTML;
        }

        public string TipoPagoContrato(Tareas tareas) {
            string response = "";


            switch (tareas.IdTipoPago)
            {
                case 1:
                    response = "por cada hora trabajada recibira la cantidad de $" + tareas.Valor + " pagada en el periodo que se indica MENSUAL, los primeros tres días hábiles del mes siguiente";
                    break;
                case 2:
                    response = "por cada tarea finalizada recibira la cantidad de $" + tareas.Valor + " pagada en el periodo que se indica MENSUAL, los primeros tres días hábiles del mes siguiente";
                    break;
                case 3:
                    response = "por cada dia trabajado recibira la cantidad de $" + tareas.Valor + " pagada en el periodo que se indica MENSUAL, los primeros tres días hábiles del mes siguiente.";
                    break;
                case 4:
                    response = "el/la trabajador(a) percibirá un sueldo base de $" + tareas.Valor + " (" + Validaciones.ConvertirNumeroATexto(tareas.Valor) + ") mensuales, los primeros tres días hábiles del mes siguiente";
                    break;
                case 5:
                    response = "el/la trabajador(a) a trato percibira un valor de $" + tareas.Valor + " por la tarea asignada en contrato que sera de '"+ tareas.Titulo +"', remuneracion que sera rescatada mensualmente los primeros tres días hábiles del mes siguiente";
                    break;

                default:
                    break;
            }
            return response;    


        }

        public string GenerarContratoPersonalizado(string plantilla, Dictionary<string, string> datos)
        {
            foreach (var item in datos)
            {
                plantilla = plantilla.Replace("[[" + item.Key + "]]", item.Value);
            }
            return plantilla;
        }

        public List<Contrato> getContratos()
        {
            List<Contrato> response = new List<Contrato>();
            try
            {
                response = new DAO.ContratosDAO().GetContratos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Finiquito GetFiniquito(int IDContrato)
        {
            Finiquito response = new Finiquito();
            try
            {
                response = new DAO.ContratosDAO().GetFiniquito(IDContrato);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Contrato registroContrato(Contrato datos)
        {
            Contrato response = new Contrato();
            try
            {
                response = new DAO.ContratosDAO().registroContrato(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public void DeleteAnexo(int IdAnexo)
        {
            try
            {
                new DAO.ContratosDAO().EliminarAnexo(IdAnexo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public AnexoContrato RegistroAnexosContratos(AnexoContrato datos)
        {
            AnexoContrato response = new AnexoContrato();
            try
            {
                response = new DAO.ContratosDAO().RegistroAnexosContratos(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Finiquito RegistroFiniquito(Finiquito datos)
        {
            Finiquito response = new Finiquito();
            try
            {
                response = new DAO.ContratosDAO().RegistroFiniquito(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
    }
}
