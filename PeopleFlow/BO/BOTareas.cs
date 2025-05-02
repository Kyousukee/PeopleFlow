using PeopleFlow.DTO;
using PeopleFlow.DTO.Tareas.Tareas;
using PeopleFlow.DTO.TareasDTO;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PeopleFlow.BO
{
    public class BOTareas
    {
        public List<Tareas> cargarTareas()
        {
            List<Tareas> response = new List<Tareas>();
            try
            {
                response = new DAO.TareasDAO().GetTareas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }


        public Tareas cargarTareaByID(int idTarea)
        {
            Tareas response = new Tareas();
            try
            {
                response = new DAO.TareasDAO().GetTareasByID(idTarea);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Tareas> cargarTareasALL()
        {
            List<Tareas> response = new List<Tareas>();
            try
            {
                response = new DAO.TareasDAO().GetTareasALL();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TareasEmpleadoAsistencia> GetAsistenciasNoPagadas(int IdEmpleado,int mes)
        {
            List<TareasEmpleadoAsistencia> response = new List<TareasEmpleadoAsistencia>();
            try
            {
                response = new DAO.TareasDAO().GetAsistenciasNoPagadas(IdEmpleado, mes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TareasEmpleadosRegistros> GetTareasNoPagadas(int IdEmpleado, int mes)
        {
            List<TareasEmpleadosRegistros> response = new List<TareasEmpleadosRegistros>();
            try
            {
                response = new DAO.TareasDAO().GetTareasNoPagadas(IdEmpleado, mes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TareasControlCambio> cargarControlTareas(int idTarea)
        {
            List<TareasControlCambio> response = new List<TareasControlCambio>();
            try
            {
                response = new DAO.TareasDAO().GetControlTareas(idTarea);
                response = response.OrderBy(x => x.FechaTermino).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TareasEmpleados> cargarEmpleadosTareas(int idTarea)
        {
            List<TareasEmpleados> response = new List<TareasEmpleados>();
            try
            {
                response = new DAO.TareasDAO().GetEmpleadosTareas(idTarea);
                response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Empleados> cargarEmpleadosnoTareas(int idTarea)
        {
            List<Empleados> response = new List<Empleados>();
            try
            {
                response = new DAO.TareasDAO().GetEmpleadosNoTareas(idTarea);
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<EmpleadoProductividad> cargarEmpleadosProductividad()
        {
            List<EmpleadoProductividad> response = new List<EmpleadoProductividad>();
            try
            {
                response = new DAO.TareasDAO().GetProductividadPorEmpleado();
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<AsistenciaSemanalEmpleados> asistenciaSemanalEmpleados()
        {
            List<AsistenciaSemanalEmpleados> response = new List<AsistenciaSemanalEmpleados>();
            try
            {
                response = new DAO.TareasDAO().asistenciaSemanalEmpleados();
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TasaAusentismoSemanal> GetTasaAusentismoSemanal()
        {
            List<TasaAusentismoSemanal> response = new List<TasaAusentismoSemanal>();
            try
            {
                response = new DAO.TareasDAO().GetTasaAusentismoSemanal();
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<DistribucionCostosLaborales> DistribucionCostosLaboralesUltimoMes()
        {
            List<DistribucionCostosLaborales> response = new List<DistribucionCostosLaborales>();
            try
            {
                response = new DAO.TareasDAO().DistribucionCostosLaboralesUltimoMes();
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<DistribucionSueldosBonos> DistribucionSueldosBonos()
        {
            List<DistribucionSueldosBonos> response = new List<DistribucionSueldosBonos>();
            try
            {
                response = new DAO.TareasDAO().DistribucionSueldosBonos();
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }


        public List<ProductividadMensual> CargarProductividadPorMes()
        {
            List<ProductividadMensual> response = new List<ProductividadMensual>();
            try
            {
                response = new DAO.TareasDAO().GetProductividadPorMes();
                //response = response.OrderBy(x => x.FechaIni).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public TareasEmpleadosRegistros getTareaRegistro(int IdTarea, int IdEmpleado, DateTime Fecha)
        {
            TareasEmpleadosRegistros response = new TareasEmpleadosRegistros();
            try
            {
                response = new DAO.TareasDAO().GetTareaRegistro(IdTarea, IdEmpleado, Fecha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public TareasEmpleadoAsistencia getTareaAsistencia(int IdTarea, int IdEmpleado, DateTime Fecha)
        {
            TareasEmpleadoAsistencia response = new TareasEmpleadoAsistencia();
            try
            {
                response = new DAO.TareasDAO().GetTareaAsistencia(IdTarea, IdEmpleado, Fecha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<RegistroActividad> getRegistroActividades(int IdTarea, DateTime FechaIni,DateTime FechaTer,int IdEmpleado)
        {
            List<RegistroActividad> response = new List<RegistroActividad>();
            try
            {
                response = new DAO.TareasDAO().GetRegistroActividades(IdTarea, FechaIni, FechaTer, IdEmpleado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<EstadoTarea> cargarTareasEstados()
        {
            List<EstadoTarea> response = new List<EstadoTarea>();
            
            try
            {
                response = new DAO.TareasDAO().GetEstadosTareas();
                response.Add(new EstadoTarea { IdEstadoTarea = 0, Descripcion = "Seleccione" });
                response = response.OrderBy(x => x.IdEstadoTarea).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Jornadas> cargarJornadas()
        {
            List<Jornadas> response = new List<Jornadas>();

            try
            {
                response = new DAO.TareasDAO().GetJornadas();
                response.Add(new Jornadas { idJornadas = 0, Descripcion = "Seleccione" });
                foreach (Jornadas item in response)
                {
                    if (item.HoraInFinSemana !=null)
                    {
                        item.DescripcionDiaComienzo = item.DiaComienzo + "-" + item.DiaTermino + item.HoraInSemana + " - " + item.HoraOutSemana + "Find:" + item.HoraInFinSemana +"/" + item.HoraOutFinSemana;
                    }
                    else
                    {
                        item.DescripcionDiaComienzo = item.DiaComienzo + "-" + item.DiaTermino + item.HoraInSemana + " - " + item.HoraOutSemana;
                    }
                    
                }
                response = response.OrderBy(x => x.idJornadas).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<Jornadas> cargarJornadasEmpresas()
        {
            List<Jornadas> response = new List<Jornadas>();

            try
            {
                response = new DAO.TareasDAO().GetJornadas();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TareasConEmpleados> cargarTareasConEmpleados()
        {
            List<TareasConEmpleados> response = new List<TareasConEmpleados>();

            try
            {
                response = new DAO.TareasDAO().GetTareasConEmpleados();
                foreach (TareasConEmpleados item in response)
                {
                    if (item.TareasRegistradasHoy == item.TotalEmpleados)
                    {
                        item.EstadoDia = "SI";
                    }
                    else
                    {
                        item.EstadoDia = "NO";
                    }
                    item.Texto = item.Titulo;
                    item.Texto2 = item.TareasRegistradasHoy + " / " + item.TotalEmpleados;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Jornadas cargarJornadasById(int ID)
        {
            List<Jornadas> response = new List<Jornadas>();
            Jornadas jornada = new Jornadas();
            try
            {
                response = new DAO.TareasDAO().GetJornadas();

                foreach (Jornadas item in response)
                {
                    if (item.HoraInFinSemana != null)
                    {
                        item.DescripcionDiaComienzo = item.DiaComienzo + "-" + item.DiaTermino + item.HoraInSemana + " - " + item.HoraOutSemana + "Find:" + item.HoraInFinSemana + "/" + item.HoraOutFinSemana;
                    }
                    else
                    {
                        item.DescripcionDiaComienzo = item.DiaComienzo + "-" + item.DiaTermino + item.HoraInSemana + " - " + item.HoraOutSemana;
                    }

                }
                jornada = response.FirstOrDefault(o=> o.idJornadas == ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return jornada;
        }

        public Jornadas cargarJornadaByID(int idjornadas)
        {
            Jornadas response = new Jornadas();
            try
            {
                response = new DAO.TareasDAO().GetJornadasID(idjornadas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public List<TipoPago> cargarTipoPago()
        {
            List<TipoPago> response = new List<TipoPago>();
            try
            {
                response = new DAO.TareasDAO().GetTipoPago();
                response.Add(new TipoPago { IdTipoPago = 0, Descripcion = "Seleccione" });
                response = response.OrderBy(x => x.IdTipoPago).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Tareas registroTarea(Tareas datos)
        {
            Tareas response = new Tareas();
            try
            {
                response = new DAO.TareasDAO().registroTarea(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public Jornadas registroJornadas(Jornadas datos)
        {
            Jornadas response = new Jornadas();
            try
            {
                response = new DAO.TareasDAO().registroJornada(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public TareasEmpleadosRegistros registroTareaRegistro(TareasEmpleadosRegistros datos)
        {
            TareasEmpleadosRegistros response = new TareasEmpleadosRegistros();
            try
            {
                response = new DAO.TareasDAO().registroTareaRegistros(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public TareasEmpleadoAsistencia registroTareaAsistencia(TareasEmpleadoAsistencia datos)
        {
            TareasEmpleadoAsistencia response = new TareasEmpleadoAsistencia();
            try
            {
                response = new DAO.TareasDAO().registroTareaAsistencia(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public void registroAsignacionTarea(TareasEmpleados datos)
        {
            try
            {
                new DAO.TareasDAO().registroAsignacionTarea(datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void GenerarExcelRegistroActividades(List<RegistroActividad> registros, string rutaArchivo)
        {
            using (var workbook = new XLWorkbook())
            {
                // Agrupar los registros por trabajador (Nombre + Apellido)
                var trabajadores = registros.GroupBy(r => $"{r.Nombre} {r.Apellido}");

                foreach (var trabajador in trabajadores)
                {
                    string nombreHoja = trabajador.Key.Length > 30 ? trabajador.Key.Substring(0, 30) : trabajador.Key;
                    var hoja = workbook.Worksheets.Add(nombreHoja);

                    hoja.Cell(1, 1).Value = "Fecha Asignación";
                    hoja.Cell(1, 2).Value = "Cantidad";
                    hoja.Cell(1, 3).Value = "Pago Individual";
                    hoja.Cell(1, 4).Value = "Valor Unitario";
                    hoja.Cell(1, 5).Value = "Total";

                    // Ajustar ancho de columnas solo en la fila de encabezado
                    //hoja.Columns().AdjustToContents(1, 1);
                    hoja.Columns().AdjustToContents();

                    hoja.Column(5).Width = 15;
                    int fila = 2;
                    decimal totalGeneral = 0;

                    // Agrupar por tarea dentro de cada trabajador
                    var tareas = trabajador.GroupBy(r => r.Titulo);

                    foreach (var tarea in tareas)
                    {
                        hoja.Cell(fila, 1).Value = $"Tarea: {tarea.Key}";
                        hoja.Range(fila, 1, fila, 5).Merge().Style.Font.Bold = true;
                        fila++;

                        decimal totalTarea = 0;

                        foreach (var registro in tarea)
                        {
                            hoja.Cell(fila, 1).Value = registro.FechaAsignacion.ToString("yyyy-MM-dd");
                            hoja.Cell(fila, 2).Value = registro.Cantidad;
                            hoja.Cell(fila, 3).Value = registro.PagoIndividual;
                            hoja.Cell(fila, 4).Value = registro.ValorUnitario;
                            hoja.Cell(fila, 5).Value = registro.Total;

                            totalTarea += registro.Total;
                            fila++;
                        }

                        // Total por tarea
                        hoja.Cell(fila, 4).Value = "Total Tarea:";
                        hoja.Cell(fila, 5).Value = totalTarea;
                        hoja.Cell(fila, 4).Style.Font.Bold = true;
                        hoja.Cell(fila, 5).Style.Font.Bold = true;
                        fila++;

                        totalGeneral += totalTarea;
                    }

                    // Total general del trabajador
                    hoja.Cell(fila, 4).Value = "Total General:";
                    hoja.Cell(fila, 5).Value = totalGeneral;
                    hoja.Cell(fila, 4).Style.Font.Bold = true;
                    hoja.Cell(fila, 5).Style.Font.Bold = true;

                    // Aplicar formato de tabla
                    var rangoTabla = hoja.RangeUsed();
                    rangoTabla.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    rangoTabla.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    rangoTabla.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }

                // Guardar el archivo
                workbook.SaveAs(rutaArchivo);
            }
        }
    }
}
