using iText.Html2pdf;
using Mysqlx.Cursor;
using PeopleFlow.DTO;
using PeopleFlow.DTO.Contrato;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class BOLiquidaciones
    {
        public Liquidacion registroLiquidacion(Liquidacion datos)
        {
            Liquidacion response = new Liquidacion();
            try
            {
                response = new DAO.LiquidacionesDAO().registroLiquidacion(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Liquidacion> GetLiquidacionesEmpresa()
        {
            return new DAO.LiquidacionesDAO().GetLiquidacionesEmpresa();
        }

        public List<Liquidacion> GetLiquidacionesByContrato(int IdContrato)
        {
            return new DAO.LiquidacionesDAO().GetLiquidacionesByContrato(IdContrato);
        }

        public Liquidacion getLiquidacionPeriodo(string periodo,int IdEmpleado)
        {
            return new DAO.LiquidacionesDAO().getLiquidacionPeriodo(periodo, IdEmpleado);
        }
        public List<Afp> GetAFPAll()
        {
            return new DAO.LiquidacionesDAO().GetAFPAll();
        }

        public List<Liquidacion> GetLiquidacionByTrabajdor(int IdTrabajador)
        {
            return new DAO.LiquidacionesDAO().GetLiquidacionByTrabajdor(IdTrabajador);
        }


        public Liquidacion GetLiquidacionById(int ID)
        {
            return new DAO.LiquidacionesDAO().GetLiquidacionById(ID);
        }

        public void GENERARPDFLiquidacion(Liquidacion liquidacion, string rutaArchivo)
        {
            try
            {
                string plantilla = "";
                DocumentosPlantilla plantillaObj = new DocumentosPlantilla();
                plantillaObj = new DAO.LiquidacionesDAO().GetLiquidacionPlanilla();

                plantilla = plantillaObj.planilla;

                var datosTrabajador = CambioDatos(liquidacion);

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

        private Dictionary<string, string> CambioDatos(Liquidacion liquidacion)
        {
            var datosTrabajador = new Dictionary<string, string>();
            Empresas empresa = new Empresas();
            Empleados empleados = new Empleados();
            Jornadas jornada = new Jornadas();
            Contrato contrato = new Contrato();
            Tareas tareas = new Tareas();
            Afp afp = new Afp();
            int HorasExtras = 0;
            int HorasFaltnates = 0;
            string tablaValores = @"
                <table style=""border-collapse: collapse; font-family: monospace; width: 100%;"">
                <tr>
                    <th style=""border-bottom: 2px solid black; text-align: left; width: 50%;"">HABERES</th>
                    <th style=""border-bottom: 2px solid black; text-align: left; width: 1px;""></th>
                    <th style=""border-bottom: 2px solid black; text-align: left; width: 50%;"">DESCUENTOS</th>
                </tr>
                <tr>
                    <td style=""vertical-align: top; padding-right: 10px;"">[[HABERES]]</td>
                    <td style=""border-left: 2px solid black;""></td> <!-- Línea de separación -->
                    <td style=""vertical-align: top; padding-left: 10px;"">[[DESCUENTOS]]</td>
                </tr>
            </table>


            ";
            string deduccionesLegales = "";
            string sueldoBaseTable = "";
            decimal totalnoimponible = 0;
            try
            {
                empresa = new DAO.EmpresasDAO().GetEmpresasbyID(Sesion.UsuarioActual.IdEmpresa);
                empleados = new BO.BOEmpleados().GetEmpleadosById(liquidacion.IdEmpleado);
                contrato = new BO.BOContratos().getContratoTrabajador(liquidacion.IdEmpleado);
                tareas = new BO.BOTareas().cargarTareaByID(contrato.IdTarea);
                jornada = new BO.BOTareas().cargarJornadaByID(tareas.IdJornada);
                afp = new DAO.LiquidacionesDAO().GetAFPById(empleados.IdAfp);
                decimal totalHorasExtras = 0;
                decimal totalHorasFaltantes = 0;

                List<DTO.Bonificaciones> bonificaciones = new DAO.ContratosDAO().GetBonificacionesEmpresaEmpleado(empleados.IdEmpleado);
                List<DTO.Bonificaciones> bonificacionesImponibles = bonificaciones.Where(b => b.Imponible).ToList();
                List<DTO.Bonificaciones> bonificacionesnoImponibles = bonificaciones.Where(b => !b.Imponible).ToList();
                totalnoimponible = bonificacionesnoImponibles.Sum(a => a.Monto);

                decimal SueldoBruto = liquidacion.SalarioBase + bonificacionesImponibles.Sum(a => a.Monto);

                sueldoBaseTable += $@"
                <tr>
                    <td style='text-align: left;'>SUELDO BASE</td>
                    <td style='text-align: right;'>{liquidacion.SalarioBase:N0}</td>
                </tr>";

                //Calculo de Horas Extras y Faltantes

                DateTime primerDia = new DateTime(Convert.ToInt32(liquidacion.year), Convert.ToInt32(liquidacion.month), 1);
                DateTime ultimoDia = new DateTime(Convert.ToInt32(liquidacion.year), Convert.ToInt32(liquidacion.month), DateTime.DaysInMonth(Convert.ToInt32(liquidacion.year), Convert.ToInt32(liquidacion.month)), 23, 59, 59);

                List<RegistroActividad> actividads = new BO.BOTareas().getRegistroActividades(0, primerDia, ultimoDia, liquidacion.IdEmpleado);

                List<RegistroActividad> actividadsHorario = actividads.Where(o => o.Horario == "SI").ToList();
                if (actividadsHorario.Count > 0)
                {
                    // Horario de trabajo (ejemplo: "09:00|18:00")
                    TimeSpan horaInicioTrabajo = TimeSpan.Parse(jornada.HoraInSemana); // "09:00"
                    TimeSpan horaTerminoTrabajo = TimeSpan.Parse(jornada.HoraOutSemana); // "18:00"


                    // Horario de trabajo (ejemplo: "09:00|18:00")
                    TimeSpan horaInicioTrabajoFinSemana = TimeSpan.Parse(jornada.HoraInFinSemana == null ? "00:00" : jornada.HoraInFinSemana); // "09:00"
                    TimeSpan horaTerminoTrabajoFinSemana = TimeSpan.Parse(jornada.HoraOutFinSemana == null ? "00:00" : jornada.HoraOutFinSemana); // "18:00"

                    // Calcular horas extras y faltantes
                    TimeSpan horasExtras = CalcularHorasExtras(actividadsHorario, horaInicioTrabajo, horaTerminoTrabajo, horaInicioTrabajoFinSemana, horaTerminoTrabajoFinSemana);
                    HorasExtras = Convert.ToInt32(horasExtras.TotalHours);
                    TimeSpan horasFaltantes = CalcularHorasFaltantes(actividadsHorario, horaInicioTrabajo, horaTerminoTrabajo, horaInicioTrabajoFinSemana, horaTerminoTrabajoFinSemana);
                    HorasFaltnates = Convert.ToInt32(horasFaltantes.TotalHours);


                }

                if (HorasExtras > 0 && (tareas.IdTipoPago == 4 || tareas.IdTipoPago == 3))
                {
                    decimal valorHoraExtra = 0;
                    decimal valorHoraExtraPOST = 0;
                    int dias = jornada.HoraInFinSemana == null ? 5 : 6;
                    if (tareas.IdTipoPago == 4)
                    {
                        valorHoraExtra = SueldoBruto / 30 / (jornada.HorasSemanales / dias) * 1.5m;
                        valorHoraExtraPOST = SueldoBruto / 30 / (jornada.HorasSemanales / dias) * 2;

                        if (HorasExtras <= 2)
                        {
                            sueldoBaseTable += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS EXTRAS</td>
                                <td style='text-align: right;'>{(HorasExtras * valorHoraExtra):N0}</td>
                            </tr>";

                            totalHorasExtras = HorasExtras * valorHoraExtra;
                        }
                        else
                        {

                            sueldoBaseTable += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS EXTRAS</td>
                                <td style='text-align: right;'>{(2 * valorHoraExtra + (HorasExtras - 2) * valorHoraExtraPOST):N0}</td>
                            </tr>";

                            totalHorasExtras = 2 * valorHoraExtra + (HorasExtras - 2) * valorHoraExtraPOST;
                        }
                    }

                    if (tareas.IdTipoPago == 3)
                    {
                        // Horario de trabajo (ejemplo: "09:00|18:00")
                        TimeSpan horaInicioTrabajo = TimeSpan.Parse(jornada.HoraInSemana); // "09:00"
                        TimeSpan horaTerminoTrabajo = TimeSpan.Parse(jornada.HoraOutSemana); // "18:00"
                        TimeSpan spanMe = horaInicioTrabajo.Subtract(horaTerminoTrabajo);
                        valorHoraExtra = tareas.Valor / Convert.ToInt32(spanMe.TotalHours) * 1.5m;
                        valorHoraExtraPOST = tareas.Valor / Convert.ToInt32(spanMe.TotalHours) * 2;

                        if (HorasExtras <= 2)
                        {
                            sueldoBaseTable += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS EXTRAS</td>
                                <td style='text-align: right;'>{(HorasExtras * valorHoraExtra):N0}</td>
                            </tr>";
                            totalHorasExtras = HorasExtras * valorHoraExtra;
                        }
                        else
                        {
                            sueldoBaseTable += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS EXTRAS</td>
                                <td style='text-align: right;'>{(2 * valorHoraExtra + (HorasExtras - 2) * valorHoraExtraPOST):N0}</td>
                            </tr>";
                            totalHorasExtras = 2 * valorHoraExtra + (HorasExtras - 2) * valorHoraExtraPOST;
                        }
                    }
                }

                liquidacion.DescripcionBonos = liquidacion.DescripcionBonos.Replace("[[SUELDOBASE]]", sueldoBaseTable);

                string datosTabla = "";
                if (HorasFaltnates > 0 && (tareas.IdTipoPago == 4 || tareas.IdTipoPago == 3))
                {

                    decimal valorHoraExtra = 0;
                    decimal valorHoraExtraPOST = 0;
                    int dias = jornada.HoraInFinSemana == null ? 5 : 6;
                    if (tareas.IdTipoPago == 4)
                    {
                        valorHoraExtra = SueldoBruto / 30 / (jornada.HorasSemanales / dias) * 1.5m;
                        valorHoraExtraPOST = SueldoBruto / 30 / (jornada.HorasSemanales / dias) * 2;

                        if (HorasFaltnates <= 2)
                        {

                            datosTabla += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS FALTAS</td>
                                <td style='text-align: right;'>{(HorasFaltnates * valorHoraExtra):N0}</td>
                            </tr>";


                            totalHorasFaltantes = HorasFaltnates * valorHoraExtra;
                        }
                        else
                        {

                            datosTabla += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS FALTAS</td>
                                <td style='text-align: right;'>{(2 * valorHoraExtra + (HorasFaltnates - 2) * valorHoraExtraPOST):N0}</td>
                            </tr>";

                            totalHorasFaltantes = 2 * valorHoraExtra + (HorasFaltnates - 2) * valorHoraExtraPOST;
                        }
                    }

                    if (tareas.IdTipoPago == 3)
                    {
                        // Horario de trabajo (ejemplo: "09:00|18:00")
                        TimeSpan horaInicioTrabajo = TimeSpan.Parse(jornada.HoraInSemana); // "09:00"
                        TimeSpan horaTerminoTrabajo = TimeSpan.Parse(jornada.HoraOutSemana); // "18:00"
                        TimeSpan spanMe = horaInicioTrabajo.Subtract(horaTerminoTrabajo);
                        valorHoraExtra = tareas.Valor / Convert.ToInt32(spanMe.TotalHours) * 1.5m;
                        valorHoraExtraPOST = tareas.Valor / Convert.ToInt32(spanMe.TotalHours) * 2;

                        if (HorasFaltnates <= 2)
                        {
                            datosTabla += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS FALTAS</td>
                                <td style='text-align: right;'>{(HorasFaltnates * valorHoraExtra):N0}</td>
                            </tr>";
                            totalHorasFaltantes = HorasFaltnates * valorHoraExtra;
                        }
                        else
                        {
                            datosTabla += $@"
                            <tr>
                                <td style='text-align: left;'>HORAS FALTAS</td>
                                <td style='text-align: right;'>{(2 * valorHoraExtra + (HorasFaltnates - 2) * valorHoraExtraPOST):N0}</td>
                            </tr>";
                            totalHorasFaltantes = 2 * valorHoraExtra + (HorasFaltnates - 2) * valorHoraExtraPOST;
                        }
                    }


                }
                if (datosTabla.Length != 0)
                {
                    liquidacion.DescripcionDeducciones = liquidacion.DescripcionDeducciones.Replace("[[HFALTANTES]]", datosTabla);
                }
                else
                {
                    liquidacion.DescripcionDeducciones = liquidacion.DescripcionDeducciones.Replace("[[HFALTANTES]]", "");
                }

                SueldoBruto = SueldoBruto + totalHorasExtras; 
                decimal valorSalud = SueldoBruto * 0.07m;
                decimal valorPrevision = SueldoBruto * (10 + afp.porcentaje)/100;
                decimal SeguroCesantia = SueldoBruto * 0.06m;

                

                

                deduccionesLegales += $@"
                <tr>
                    <td style='text-align: left;'>Prevision</td>
                    <td style='text-align: right;'>{valorPrevision:N0}</td>
                </tr>";

                deduccionesLegales += $@"
                <tr>
                    <td style='text-align: left;'>SALUD</td>
                    <td style='text-align: right;'>{valorSalud:N0}</td>
                </tr>";

                deduccionesLegales += $@"
                <tr>
                    <td style='text-align: left;'>SEGURO CESANTIA</td>
                    <td style='text-align: right;'>{SeguroCesantia:N0}</td>
                </tr>";


                liquidacion.DescripcionDeducciones = liquidacion.DescripcionDeducciones.Replace("[[DESCUENTOSLEGALES]]", deduccionesLegales);
                liquidacion.DescripcionDeducciones = liquidacion.DescripcionDeducciones.Replace("[[TOTALDESCLEGALES]]", (valorPrevision+ valorSalud+ SeguroCesantia).ToString("N0"));

                





                

                AsignacionFamiliar asignacionFamiliar = new BO.BOEmpleados().GetAsignacionFamiliar(liquidacion.IdEmpleado);
                int NCargas = 0;
                if (asignacionFamiliar != null)
                {
                    string tablaCargas = "";
                    NCargas = asignacionFamiliar.NCargasHijos + asignacionFamiliar.NCargasConguye + asignacionFamiliar.NCargasInvalidez;

                    ValoresCargas valoresCargas = new ValoresCargas();
                    List<ValoresCargas> ListvaloresCargas = new DAO.EmpleadosDAO().GetValoresCargas();

                    valoresCargas = ListvaloresCargas
                    .Where(vc => SueldoBruto <= vc.Tope)  // Filtrar valores que cumplen la condición
                    .OrderBy(vc => vc.Tope)              // Ordenar por Tope ascendente (para tomar el menor posible)
                    .FirstOrDefault();

                    if (valoresCargas != null)
                    {
                        decimal valorHijos = valoresCargas.ValorHijos * asignacionFamiliar.NCargasHijos;
                        decimal valorConyuge = valoresCargas.ValorConyuge * asignacionFamiliar.NCargasConguye;
                        decimal valorInvalidez = valoresCargas.ValorDiscapacidad * asignacionFamiliar.NCargasInvalidez;
                        if ((asignacionFamiliar.NCargasHijos + asignacionFamiliar.NCargasConguye) > 0)
                        {
                            tablaCargas += $@"
                            <tr>
                                <td style='text-align: left;'>CARGA FAMILIAR</td>
                                <td style='text-align: right;'>{(valorHijos + valorConyuge):N0}</td>
                            </tr>";
                            totalnoimponible = totalnoimponible + valorHijos + valorConyuge;
                        }
                        if (asignacionFamiliar.NCargasInvalidez > 0)
                        {
                            tablaCargas += $@"
                            <tr>
                                <td style='text-align: left;'>CARGA INVALIDEZ</td>
                                <td style='text-align: right;'>{valorInvalidez:N0}</td>
                            </tr>";
                            totalnoimponible = totalnoimponible + valorInvalidez;
                        }
                    }

                    
                    liquidacion.DescripcionBonos = liquidacion.DescripcionBonos.Replace("[[CARGASFAMILIARES]]", tablaCargas);
                }
                else
                {
                    liquidacion.DescripcionBonos = liquidacion.DescripcionBonos.Replace("[[CARGASFAMILIARES]]", "");
                }

                liquidacion.DescripcionBonos = liquidacion.DescripcionBonos.Replace("[[TOTALIMPONIBLE]]", SueldoBruto.ToString("N0"));
                liquidacion.DescripcionBonos = liquidacion.DescripcionBonos.Replace("[[TOTALNOIMPONIBLE]]", totalnoimponible.ToString("N0"));

                tablaValores = tablaValores.Replace("[[HABERES]]", liquidacion.DescripcionBonos);
                tablaValores = tablaValores.Replace("[[DESCUENTOS]]", liquidacion.DescripcionDeducciones);


                var diasTrabajados = actividads
                .GroupBy(a => a.FechaAsignacion.Date) // Agrupar por fecha (sin hora)
                .Select(g => new
                {
                    Fecha = g.Key, // Fecha de asignación
                    TotalDiasTrabajados = g.Count() // Número de actividades en esa fecha
                })
                .OrderBy(g => g.Fecha) // Ordenar por fecha (opcional)
                .ToList();

                datosTrabajador = new Dictionary<string, string>
                {
                    { "PERIODO", liquidacion.Periodo },
                    { "RUTEMPRESA", empresa.RUT},
                    { "RAZONSOCIAL", empresa.Nombre },
                    { "RUTTRABAJADOR", empleados.Rut },
                    { "NOMBRETRABAJADOR", liquidacion.NombreEmpleado },
                    { "NCONTRATO", liquidacion.IdContrato.ToString() },
                    { "AFPEMPLEADO", empleados.AFP.ToString() },
                    { "SALUD", empleados.Salud },
                    { "VALORPESO", valorSalud.ToString("N0") },
                    { "PORCENTAJEAFP", (10+afp.porcentaje).ToString() + "%" },
                    { "PORCENTAJEUFUTM", (7).ToString() + "%" },
                    { "DIAST", diasTrabajados.Count.ToString() },
                    { "HEXTRAS", HorasExtras.ToString() },
                    { "HFALTAS", HorasFaltnates.ToString() },
                    { "CARGAS", NCargas.ToString() }, //Se debe agregar en el registro del empleado
                    { "IMPONIBLE", SueldoBruto.ToString("N0") },
                    { "TRIBUTABLE", (SueldoBruto -  (valorPrevision+ valorSalud+ SeguroCesantia)).ToString("N0") },
                    { "HABERES", tablaValores },
                    //{ "DESCUENTOS", liquidacion.DescripcionDeducciones },
                    { "TOTALHABERES", (SueldoBruto+totalnoimponible).ToString("N0") },
                    { "TOTALDESCUENTOS", (liquidacion.Deducciones +  (valorPrevision+ valorSalud+ SeguroCesantia)).ToString("N0") },
                    { "FECHA", DateTime.Now.ToString("dd/MM/yyyy") },
                    { "ALCANCELIQUIDO",( (SueldoBruto+totalnoimponible) - (liquidacion.Deducciones +  (valorPrevision+ valorSalud+ SeguroCesantia))).ToString("N0") },
                    { "VALORSTRING", Validaciones.ConvertirNumeroATexto( (SueldoBruto+totalnoimponible) - (liquidacion.Deducciones +  (valorPrevision+ valorSalud+ SeguroCesantia))) },
                };
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo generar el cambio de informacion.");
            }

            return datosTrabajador;
        }

        public static bool EsFinDeSemana(DateTime fecha)
        {
            return fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday;
        }

        // Función para calcular horas extras
        public static TimeSpan CalcularHorasExtras(List<RegistroActividad> actividades, TimeSpan horaInicioTrabajo, TimeSpan horaTerminoTrabajo, TimeSpan horaInicioTrabajoFin, TimeSpan horaTerminoTrabajoFin)
        {
            TimeSpan horasExtras = TimeSpan.Zero;

            foreach (var actividad in actividades)
            {
                if (!EsFinDeSemana(actividad.FechaAsignacion))
                {
                    string[] horas = actividad.Cantidad.Split('|');
                    TimeSpan horaInicioActividad = TimeSpan.Parse(horas[0]); // Hora de inicio de la actividad
                    TimeSpan horaTerminoActividad = TimeSpan.Parse(horas[1]); // Hora de término de la actividad

                    // Si la actividad termina después del horario de trabajo, son horas extras
                    if (horaTerminoActividad > horaTerminoTrabajo)
                    {
                        horasExtras += horaTerminoActividad - horaTerminoTrabajo;
                    }

                }
                else
                {
                    string[] horas = actividad.Cantidad.Split('|');
                    TimeSpan horaInicioActividad = TimeSpan.Parse(horas[0]); // Hora de inicio de la actividad
                    TimeSpan horaTerminoActividad = TimeSpan.Parse(horas[1]); // Hora de término de la actividad

                    // Si la actividad termina después del horario de trabajo, son horas extras
                    if (horaTerminoActividad > horaTerminoTrabajoFin)
                    {
                        horasExtras += horaTerminoActividad - horaTerminoTrabajoFin;
                    }
                }
                
            }

            return horasExtras;
        }

        public static TimeSpan CalcularHorasFaltantes(List<RegistroActividad> actividades, TimeSpan horaInicioTrabajo, TimeSpan horaTerminoTrabajo, TimeSpan horaInicioTrabajoFin, TimeSpan horaTerminoTrabajoFin)
        {
            TimeSpan horasFaltantes = TimeSpan.Zero;

            foreach (var actividad in actividades)
            {
                if (!EsFinDeSemana(actividad.FechaAsignacion))
                {
                    string[] horas = actividad.Cantidad.Split('|');
                    TimeSpan horaInicioActividad = TimeSpan.Parse(horas[0]); // Hora de inicio de la actividad
                    TimeSpan horaTerminoActividad = TimeSpan.Parse(horas[1]); // Hora de término de la actividad

                    // Si la actividad comienza antes del horario de trabajo, son horas faltantes
                    if (horaInicioActividad < horaInicioTrabajo)
                    {
                        horasFaltantes += horaInicioTrabajo - horaInicioActividad;
                    }
                }
                else
                {
                    string[] horas = actividad.Cantidad.Split('|');
                    TimeSpan horaInicioActividad = TimeSpan.Parse(horas[0]); // Hora de inicio de la actividad
                    TimeSpan horaTerminoActividad = TimeSpan.Parse(horas[1]); // Hora de término de la actividad

                    // Si la actividad comienza antes del horario de trabajo, son horas faltantes
                    if (horaInicioActividad < horaInicioTrabajoFin)
                    {
                        horasFaltantes += horaInicioTrabajoFin - horaInicioActividad;
                    }
                }
                    
            }

            return horasFaltantes;
        }


        public string GenerarContratoPersonalizado(string plantilla, Dictionary<string, string> datos)
        {
            foreach (var item in datos)
            {
                plantilla = plantilla.Replace("[[" + item.Key + "]]", item.Value);
            }
            return plantilla;
        }

        public List<Liquidacion> GetLiquidacionesEmpresaPeriodo(string year, string month)
        {
            return new DAO.LiquidacionesDAO().GetLiquidacionesEmpresaPeriodo(year, month);
        }
    }
}
