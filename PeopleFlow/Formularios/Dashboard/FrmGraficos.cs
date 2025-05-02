using LiveCharts.Wpf;
using LiveCharts;
using PeopleFlow.BO;
using PeopleFlow.DTO;
using PeopleFlow.DTO.TareasDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace PeopleFlow.Formularios.Dashboard
{
    public partial class FrmGraficos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmGraficos()
        {
            InitializeComponent();
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmGraficos_Load(object sender, EventArgs e)
        {
            bool STATE = new BO.BOUsuarios().verificaUsuario();
            if (!STATE)
            {
                Mensaje("Error: Usuario no detectado.");
                this.Close();
            }
            CargarGrafico();
            CargarGrafico2();
            CargarGrafico3();
            CargarGraficoDistribucionCostosLaboralesPastel();
            CargarGraficoAusentismo();
            CargarGraficoSueldosVsBonos();
        }

        private void CargarGrafico()
        {
            // Simulación de datos (esto normalmente se obtiene desde el SP en la base de datos)
            List<EmpleadoProductividad> datos = new BO.BOTareas().cargarEmpleadosProductividad();

            // Agrupar datos por empleado y tipo de pago
            var empleados = datos.Select(d => d.Empleado).Distinct().ToList();
            var tiposPago = datos.Select(d => d.Descripcion).Distinct().ToList();

            // Crear un diccionario para organizar los valores por tipo de pago
            Dictionary<string, ChartValues<double>> seriesData = new Dictionary<string, ChartValues<double>>();
            foreach (var tipo in tiposPago)
            {
                seriesData[tipo] = new ChartValues<double>();
            }

            // Llenar los valores por cada empleado
            foreach (var empleado in empleados)
            {
                foreach (var tipo in tiposPago)
                {
                    var total = datos
                        .Where(d => d.Empleado == empleado && d.Descripcion == tipo)
                        .Sum(d => d.TotalPago);

                    seriesData[tipo].Add((double)total);
                }
            }

            // Crear el gráfico
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill
            };

            // Agregar las series al gráfico
            chart.Series = new SeriesCollection();
            foreach (var tipo in tiposPago)
            {
                chart.Series.Add(new StackedColumnSeries
                {
                    Title = tipo,
                    Values = seriesData[tipo],
                    DataLabels = true
                });
            }

            // Configurar etiquetas del eje X con los nombres de los empleados
            chart.AxisX.Add(new Axis
            {
                Labels = empleados
            });

            // Limpiar y agregar el gráfico al panel
            panelGrafico.Controls.Clear();
            panelGrafico.Controls.Add(chart);
        }

        private void CargarGrafico2()
        {
            // Simulación de datos (esto normalmente se obtiene desde el SP en la base de datos)
            List<ProductividadMensual> datos = new BO.BOTareas().CargarProductividadPorMes();

            // Obtener lista de meses ordenados cronológicamente
            var meses = datos.Select(d => d.Mes).Distinct().OrderBy(m => m).ToList();

            // Obtener lista de empleados
            var empleados = datos.Select(d => d.Empleado).Distinct().ToList();

            // Crear el gráfico de líneas
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill
            };

            // Crear series para cada empleado
            foreach (var empleado in empleados)
            {
                var valores = new ChartValues<double>();

                foreach (var mes in meses)
                {
                    var registro = datos.FirstOrDefault(d => d.Empleado == empleado && d.Mes == mes);
                    valores.Add((double)(registro?.TotalPago ?? 0)); // Si no hay datos, agrega 0
                }

                chart.Series.Add(new LineSeries
                {
                    Title = empleado,
                    Values = valores,
                    PointGeometry = DefaultGeometries.Circle, // Punto en cada mes
                    LineSmoothness = 0.5 // Suaviza la línea
                });
            }

            // Configurar el eje X con los meses
            chart.AxisX.Add(new Axis
            {
                Labels = meses,
                Separator = new Separator { Step = 1 }
            });

            // Configurar el eje Y con el total pagado
            chart.AxisY.Add(new Axis
            {
                Title = "Total Pagado ($)"
            });

            // Limpiar y agregar el gráfico al panel
            panelGrafico2.Controls.Clear();
            panelGrafico2.Controls.Add(chart);
        }

        private void CargarGrafico3()
        {
            // Obtener datos desde el BO
            List<AsistenciaSemanalEmpleados> datos = new BO.BOTareas().asistenciaSemanalEmpleados();

            // Procesar datos para el gráfico
            var empleados = datos.Select(d => d.Empleado).Distinct().OrderBy(e => e).ToList();
            var semanas = datos.Select(d => d.Semana.ToString()).Distinct().OrderBy(s => s).ToList();

            var series = new SeriesCollection();

            // Configuración de colores
            var colors = new[]
            {
                System.Windows.Media.Color.FromRgb(33, 149, 242),  // Azul para horas trabajadas
                System.Windows.Media.Color.FromRgb(242, 99, 33)     // Naranja para horas esperadas
            };

            foreach (var empleado in empleados)
            {
                // Convertir explícitamente a double
                var horasTrabajadas = semanas.Select(s => (double)(datos.FirstOrDefault(d => d.Empleado == empleado && d.Semana.ToString() == s)?.HorasTrabajadas ?? 0));

                var horasEsperadas = semanas.Select(s =>
                    (double)(datos.FirstOrDefault(d => d.Empleado == empleado && d.Semana.ToString() == s)?.HorasEsperadas ?? 0));

                // Serie para horas trabajadas
                series.Add(new ColumnSeries
                {
                    Title = empleado + " (Trabajadas)",
                    Values = new ChartValues<double>(horasTrabajadas),
                    Fill = new System.Windows.Media.SolidColorBrush(colors[0]),
                    DataLabels = true
                });

                // Serie para horas esperadas/contratadas
                series.Add(new ColumnSeries
                {
                    Title = empleado + " (Esperadas)",
                    Values = new ChartValues<double>(horasEsperadas),
                    Fill = new System.Windows.Media.SolidColorBrush(colors[1]),
                    DataLabels = true
                });
            }

            // Configurar el gráfico
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                LegendLocation = LegendLocation.Top,
                Hoverable = true
            };

            // Configurar ejes
            chart.AxisX.Add(new Axis
            {
                Title = "Semanas",
                Labels = semanas,
                Separator = new Separator { Step = 1 }
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Horas",
                LabelFormatter = value => value.ToString("N0")
            });

            // Agregar series al gráfico
            chart.Series = series;

            // Limpiar panel y agregar el gráfico
            panel2.Controls.Clear();
            panel2.Controls.Add(chart);
        }

        private void CargarGraficoAusentismo()
        {
            // Obtener datos desde el BO (deberían coincidir con la nueva estructura)
            List<TasaAusentismoSemanal> datos = new BO.BOTareas().GetTasaAusentismoSemanal();

            // Procesar datos para el gráfico
            var empleados = datos.Select(d => d.Empleado).Distinct().OrderBy(e => e).ToList();
            var semanas = datos.Select(d => d.Semana.ToString()).Distinct().OrderBy(s => s).ToList();

            var series = new SeriesCollection();

            // Configuración de colores (puedes agregar más colores si tienes muchos empleados)
            var colors = new[]
            {
                System.Windows.Media.Color.FromRgb(231, 76, 60),   // Rojo
                System.Windows.Media.Color.FromRgb(41, 128, 185),  // Azul
                System.Windows.Media.Color.FromRgb(39, 174, 96),   // Verde
                System.Windows.Media.Color.FromRgb(243, 156, 18),  // Naranja
                System.Windows.Media.Color.FromRgb(142, 68, 173)   // Morado
            };

            for (int i = 0; i < empleados.Count; i++)
            {
                var empleado = empleados[i];
                var color = colors[i % colors.Length]; // Ciclar colores si hay más empleados que colores

                // Convertir la tasa de ausentismo a double
                var tasasAusentismo = semanas.Select(s =>
                    datos.FirstOrDefault(d => d.Empleado == empleado && d.Semana.ToString() == s)?.TasaAusentismo ?? 0);

                // Serie para la tasa de ausentismo
                series.Add(new LineSeries
                {
                    Title = empleado,
                    Values = new ChartValues<double>(tasasAusentismo),
                    Stroke = new System.Windows.Media.SolidColorBrush(color),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y:N2}%"
                });
            }

            // Configurar el gráfico
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                LegendLocation = LegendLocation.Top,
                Hoverable = true,
                AnimationsSpeed = TimeSpan.FromMilliseconds(300)
            };

            // Configurar ejes
            chart.AxisX.Add(new Axis
            {
                Title = "Semanas",
                Labels = semanas,
                Separator = new Separator { Step = 1 }
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Tasa de Ausentismo (%)",
                LabelFormatter = value => $"{value:N0}%",
                MinValue = 0, // Empezar desde 0%
                MaxValue = 100 // Máximo 100%
            });

            // Agregar series al gráfico
            chart.Series = series;

            // Limpiar panel y agregar el gráfico (usa el panel que corresponda)
            panel1.Controls.Clear();
            panel1.Controls.Add(chart);
        }

        private void CargarGraficoDistribucionCostosLaboralesPastel()
        {
            // Obtener datos desde la capa de negocio
            List<DistribucionCostosLaborales> datos = new BO.BOTareas().DistribucionCostosLaboralesUltimoMes();

            if (datos == null || datos.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles para mostrar en el gráfico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var series = new SeriesCollection();

            double total = datos.Sum(x => (double)x.MontoTotal);

            foreach (var item in datos)
            {
                series.Add(new PieSeries
                {
                    Title = item.Concepto,
                    Values = new ChartValues<double> { (double)item.MontoTotal },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.SeriesView.Title}: {chartPoint.Y / total:P1} (${chartPoint.Y:N0})",
                    FontSize = 12
                });
            }

            // Crear y configurar el gráfico de pastel
            var chart = new LiveCharts.WinForms.PieChart
            {
                Dock = DockStyle.Fill,
                LegendLocation = LegendLocation.Right,
                Series = series,
                AnimationsSpeed = TimeSpan.FromMilliseconds(300)
            };

            // Limpiar el panel y mostrar el gráfico
            panel4.Controls.Clear();
            panel4.Controls.Add(chart);
        }


        private void CargarGraficoSueldosVsBonos()
        {
            // Obtener los datos desde la lógica de negocio
            List<DistribucionSueldosBonos> datos = new BO.BOTareas().DistribucionSueldosBonos();

            var empleados = datos.Select(d => d.Empleado).ToList();
            var sueldos = datos.Select(d => (double)d.SueldoBase).ToList();
            var bonos = datos.Select(d => (double)d.Bonos).ToList();

            var series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Sueldo Base",
                    Values = new ChartValues<double>(sueldos),
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.SteelBlue),
                    DataLabels = true,
                    LabelPoint = point => $"${point.Y:N0}"
                },
                new ColumnSeries
                {
                    Title = "Bonos",
                    Values = new ChartValues<double>(bonos),
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Orange),
                    DataLabels = true,
                    LabelPoint = point => $"${point.Y:N0}"
                }
            };

            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                LegendLocation = LegendLocation.Top
            };

            chart.AxisX.Add(new Axis
            {
                Title = "Empleados",
                Labels = empleados,
                LabelsRotation = 15
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Monto ($)",
                LabelFormatter = value => $"${value:N0}"
            });

            chart.Series = series;

            panelAusentismo.Controls.Clear();
            panelAusentismo.Controls.Add(chart);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
