using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Proyecto_Taller_2.Models;
using System.Data.Entity;

namespace Proyecto_Taller_2
{
    public partial class Dashboard : BaseUserControl
    {
        private MiDbContext _context;

        public Dashboard()
        {
            InitializeComponent();
            _context = new MiDbContext();
            CargarDatosDashboard();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosDashboard();
            MessageBox.Show("Dashboard actualizado correctamente", "Actualización",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarDatosDashboard()
        {
            CargarTarjetasInformativas();
            CargarGraficoTorta();
            CargarGraficoBarras();
            CargarProximasCitas();
        }

        private void CargarTarjetasInformativas()
        {
            try
            {
                lblTotalMascotas.Text = _context.Mascota.Count().ToString();
                lblTotalClientes.Text = _context.Propietario.Count().ToString();
                lblUsuarios.Text = _context.Usuario.Count().ToString();

                DateTime hoy = DateTime.Today;

                lblCitasHoy.Text = _context.Consulta
                    .Count(c => DbFunctions.TruncateTime(c.fecha_consulta) == hoy)
                    .ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las tarjetas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void CargarGraficoTorta()
{
    try
    {
        chartTiposMascotas.Series.Clear();
        chartTiposMascotas.Titles.Clear();

        Title titulo = new Title
        {
            Text = "Distribución de Mascotas por Raza",
            Font = new Font("Inter", 12, FontStyle.Bold),
            ForeColor = Color.FromArgb(64, 64, 64)
        };
        chartTiposMascotas.Titles.Add(titulo);

        Series series = new Series
        {
            Name = "Mascotas",
            ChartType = SeriesChartType.Pie,
            IsValueShownAsLabel = true
        };

        var datos = (from m in _context.Mascota
                     join r in _context.Raza on m.id_raza equals r.id_raza
                     group m by r.nombre_raza into g
                     select new
                     {
                         Raza = g.Key,
                         Cantidad = g.Count()
                     }).ToList();

        foreach (var d in datos)
        {
            string nombreRaza = string.IsNullOrEmpty(d.Raza) ? "Desconocida" : d.Raza;
            series.Points.AddXY(nombreRaza, d.Cantidad);
        }

        series.Label = "#PERCENT{P1}";
        series.LegendText = "#VALX (#VAL)";
        chartTiposMascotas.Series.Add(series);

        if (chartTiposMascotas.Legends.Count == 0)
            chartTiposMascotas.Legends.Add(new Legend());

        chartTiposMascotas.Legends[0].Docking = Docking.Right;
        chartTiposMascotas.Legends[0].Font = new Font("Inter", 9);
    }
    catch (Exception ex)
    {
        MessageBox.Show(
            $"Error al cargar el gráfico de torta:\n{ex.Message}\n\nDetalles internos:\n{ex.InnerException?.Message}",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }
}


        private void CargarGraficoBarras()
        {
            try
            {
                chartCitasMensuales.Series.Clear();
                chartCitasMensuales.Titles.Clear();

                Title titulo = new Title
                {
                    Text = "Consultas Mensuales - Últimos 6 Meses",
                    Font = new Font("Inter", 12, FontStyle.Bold),
                    ForeColor = Color.FromArgb(64, 64, 64)
                };
                chartCitasMensuales.Titles.Add(titulo);

                Series series = new Series
                {
                    Name = "Consultas",
                    ChartType = SeriesChartType.Column,
                    Color = Color.FromArgb(76, 175, 80),
                    IsValueShownAsLabel = true,
                    Font = new Font("Inter", 9, FontStyle.Bold)
                };

                DateTime desde = DateTime.Today.AddMonths(-5);

                var datos = _context.Consulta
                    .Where(c => c.fecha_consulta >= desde)
                    .GroupBy(c => new { c.fecha_consulta.Year, c.fecha_consulta.Month })
                    .Select(g => new
                    {
                        Anio = g.Key.Year,
                        Mes = g.Key.Month,
                        Cantidad = g.Count()
                    })
                    .ToList();

                var datosOrdenados = datos.OrderBy(d => new DateTime(d.Anio, d.Mes, 1)).ToList();

                foreach (var d in datosOrdenados)
                {
                    string nombreMes = new DateTime(d.Anio, d.Mes, 1).ToString("MMM");
                    series.Points.AddXY(nombreMes, d.Cantidad);
                }

                chartCitasMensuales.Series.Add(series);

                chartCitasMensuales.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartCitasMensuales.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chartCitasMensuales.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Inter", 9);
                chartCitasMensuales.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Inter", 9);

                if (chartCitasMensuales.Legends.Count > 0)
                    chartCitasMensuales.Legends[0].Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   $"Error al cargar el grafico de barras:\n{ex.Message}\n\nDetalles internos:\n{ex.InnerException?.Message}",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }

        private void CargarProximasCitas()
        {
            try
            {
                dataGridViewProximasCitas.Rows.Clear();

                DateTime hoy = DateTime.Today;

                var citas = _context.Consulta
                    .Where(c => DbFunctions.TruncateTime(c.fecha_consulta) >= hoy)
                    .OrderBy(c => c.fecha_consulta)
                    .Take(10)
                    .Select(c => new
                    {
                        Hora = c.fecha_consulta,
                        IdMascota = c.id_mascota,
                        Motivo = c.motivo
                    })
                    .ToList();

                foreach (var cita in citas)
                {
                    var mascota = _context.Mascota.FirstOrDefault(m => m.IdMascota == cita.IdMascota);
                    string nombreMascota = mascota?.Nombre ?? "Desconocida";

                    string propietario = "N/D";
                    if (mascota != null)
                    {
                        int idProp = mascota.id_propietario;
                        var prop = _context.Propietario.FirstOrDefault(p => p.Id == idProp);
                        if (prop != null)
                            propietario = $"{prop.nombre} {prop.apellido}";
                    }

                    dataGridViewProximasCitas.Rows.Add(
                        cita.Hora.ToString("HH:mm"),
                        nombreMascota,
                        propietario,
                        cita.Motivo
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar próximas citas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
