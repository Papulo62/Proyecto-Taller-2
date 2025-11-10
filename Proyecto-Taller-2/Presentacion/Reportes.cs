using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Reportes : BaseUserControl
    {
        private MiDbContext _context;
        private string tipoReporteActual = "consultas";

        public Reportes()
        {
            InitializeComponent();
            _context = new MiDbContext();
            InicializarVista();
        }

        private int rolId = 2; 

        private void InicializarVista()
        {
            dateTimePickerFin.Value = DateTime.Now;
            dateTimePickerInicio.Value = DateTime.Now.AddMonths(-1);

            comboBoxTipoReporte.Items.Clear();

            if (rolId == 1)
            {
                comboBoxTipoReporte.Items.Add("Turnos Agendados");
            }
            else if (rolId == 2) 
            {
                comboBoxTipoReporte.Items.Add("Consultas Realizadas");
                comboBoxTipoReporte.Items.Add("Turnos Agendados");
                comboBoxTipoReporte.Items.Add("Mascotas Registradas");
            }
            else if (rolId == 3) 
            {
                comboBoxTipoReporte.Items.Add("Consultas Realizadas");
                comboBoxTipoReporte.Items.Add("Turnos Agendados");
                comboBoxTipoReporte.Items.Add("Mascotas Registradas");
                comboBoxTipoReporte.Items.Add("Consultas por Veterinario");
            }

            comboBoxTipoReporte.SelectedIndex = 0;
        }


        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dateTimePickerInicio.Value.Date;
                DateTime fechaFin = dateTimePickerFin.Value.Date.AddDays(1).AddSeconds(-1);

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin.",
                        "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tipoSeleccionado = comboBoxTipoReporte.SelectedItem.ToString();

                switch (tipoSeleccionado)
                {
                    case "Consultas Realizadas":
                        GenerarReporteConsultas(fechaInicio, fechaFin);
                        break;
                    case "Turnos Agendados":
                        GenerarReporteTurnos(fechaInicio, fechaFin);
                        break;
                    case "Mascotas Registradas":
                        GenerarReporteMascotas(fechaInicio, fechaFin);
                        break;
                    case "Consultas por Veterinario":
                        GenerarReporteVeterinarios(fechaInicio, fechaFin);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarReporteConsultas(DateTime fechaInicio, DateTime fechaFin)
        {
            tipoReporteActual = "consultas";
            ConfigurarColumnasConsultas();

            var consultas = _context.Consulta
                .Where(c => c.activo && c.fecha_consulta >= fechaInicio && c.fecha_consulta <= fechaFin)
                .OrderByDescending(c => c.fecha_consulta)
                .ToList();

            dataGridViewReporte.Rows.Clear();
            lblTotalRegistros.Text = $"Total de Consultas: {consultas.Count}";

            foreach (var consulta in consultas)
            {
                var mascota = _context.Mascota.FirstOrDefault(m => m.IdMascota == consulta.id_mascota);
                var veterinario = _context.Veterinario.FirstOrDefault(v => v.IdVeterinario == consulta.id_veterinario);
                var usuario = _context.Usuario.FirstOrDefault(u => u.Id == veterinario.id_usuario);
                string veterinarioNombre = usuario != null ? $"{usuario.nombre} {usuario.apellido}" : "N/A";
                var propietario = mascota != null ?
                    _context.Propietario.FirstOrDefault(p => p.Id == mascota.id_propietario) : null;

                dataGridViewReporte.Rows.Add(
                    consulta.Id,
                    consulta.fecha_consulta.ToString("dd/MM/yyyy HH:mm"),
                    mascota?.Nombre ?? "N/A",
                    propietario != null ? $"{propietario.nombre} {propietario.apellido}" : "N/A",
                    veterinarioNombre,
                    consulta.motivo,
                    consulta.diagnostico,
                    consulta.tratamiento
                );
            }

            if (consultas.Count == 0)
            {
                MessageBox.Show("No se encontraron consultas en el rango de fechas seleccionado.",
                    "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarReporteTurnos(DateTime fechaInicio, DateTime fechaFin)
        {
            tipoReporteActual = "turnos";
            ConfigurarColumnasTurnos();

            var turnos = _context.Turno
                .Where(t => t.fecha_inicio >= fechaInicio && t.fecha_inicio <= fechaFin)
                .OrderByDescending(t => t.fecha_inicio)
                .ToList();

            dataGridViewReporte.Rows.Clear();
            lblTotalRegistros.Text = $"Total de Turnos: {turnos.Count}";

            foreach (var turno in turnos)
            {
                var mascota = _context.Mascota.FirstOrDefault(m => m.IdMascota == turno.id_mascota);
                var usuario = _context.Usuario.FirstOrDefault(u => u.Id == turno.id_usuario);
                var propietario = mascota != null ?
                    _context.Propietario.FirstOrDefault(p => p.Id == mascota.id_propietario) : null;
                var estado = _context.Estado.FirstOrDefault(e => e.IdEstado == turno.id_estado);
                string estadoTexto = estado != null ? estado.Nombre : "Desconocido";

                string veterinarioNombre = usuario != null ? $"{usuario.nombre} {usuario.apellido}" : "N/A";

                dataGridViewReporte.Rows.Add(
                    turno.id_turno,
                    turno.fecha_inicio.ToString("dd/MM/yyyy HH:mm"),
                    turno.fecha_fin.HasValue
                    ? turno.fecha_fin.Value.ToString("dd/MM/yyyy HH:mm")
    :               "N/A",

                    mascota?.Nombre ?? "N/A",
                    propietario != null ? $"{propietario.nombre} {propietario.apellido}" : "N/A",
                    veterinarioNombre, 
                    turno.descripcion_turno,
                    estadoTexto
                );
            }

            if (turnos.Count == 0)
            {
                MessageBox.Show("No se encontraron turnos en el rango de fechas seleccionado.",
                    "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarReporteMascotas(DateTime fechaInicio, DateTime fechaFin)
        {
            tipoReporteActual = "mascotas";
            ConfigurarColumnasMascotas();

            var mascotas = _context.Mascota
                .Where(m => m.Activo && m.FechaNacimiento >= fechaInicio && m.FechaNacimiento <= fechaFin)
                .OrderByDescending(m => m.FechaNacimiento)
                .ToList();

            dataGridViewReporte.Rows.Clear();
            lblTotalRegistros.Text = $"Total de Mascotas: {mascotas.Count}";

            foreach (var mascota in mascotas)
            {
                var propietario = _context.Propietario.FirstOrDefault(p => p.Id == mascota.id_propietario);
                var edad = CalcularEdad(mascota.FechaNacimiento);

                // Contar consultas de esta mascota
                var totalConsultas = _context.Consulta.Count(c => c.id_mascota == mascota.IdMascota && c.activo);

                dataGridViewReporte.Rows.Add(
                    mascota.IdMascota,
                    mascota.FechaNacimiento.ToString("dd/MM/yyyy"),
                    mascota.Nombre,
                    propietario != null ? $"{propietario.nombre} {propietario.apellido}" : "N/A",
                    propietario?.telefono ?? "N/A",
                    mascota.Sexo,
                    $"{mascota.Peso} kg",
                    edad,
                    totalConsultas
                );
            }

            if (mascotas.Count == 0)
            {
                MessageBox.Show("No se encontraron mascotas registradas en el rango de fechas seleccionado.",
                    "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarReporteVeterinarios(DateTime fechaInicio, DateTime fechaFin)
        {
            tipoReporteActual = "veterinarios";
            ConfigurarColumnasVeterinarios();

            var consultas = _context.Consulta
                .Where(c => c.activo && c.fecha_consulta >= fechaInicio && c.fecha_consulta <= fechaFin)
                .GroupBy(c => c.id_veterinario)
                .Select(g => new
                {
                    VeterinarioId = g.Key,
                    TotalConsultas = g.Count(),
                    PrimeraConsulta = g.Min(c => c.fecha_consulta),
                    UltimaConsulta = g.Max(c => c.fecha_consulta)
                })
                .OrderByDescending(x => x.TotalConsultas)
                .ToList();

            dataGridViewReporte.Rows.Clear();
            lblTotalRegistros.Text = $"Total de Veterinarios Activos: {consultas.Count}";

            int posicion = 1;
            foreach (var item in consultas)
            {
                var veterinario = _context.Veterinario.FirstOrDefault(v => v.IdVeterinario == item.VeterinarioId);
                var usuario = _context.Usuario.FirstOrDefault(u => u.Id == veterinario.id_usuario);
                string veterinarioNombre = usuario != null ? $"{usuario.nombre} {usuario.apellido}" : "N/A";

      
                TimeSpan diferencia = item.UltimaConsulta - item.PrimeraConsulta;
                int diasActivo = (int)diferencia.TotalDays;

         
                double promedioConsultas = diasActivo > 0 ? (double)item.TotalConsultas / diasActivo : item.TotalConsultas;

                dataGridViewReporte.Rows.Add(
                    posicion++,
                   veterinarioNombre,
                    veterinario?.id_usuario.ToString() ?? "N/A",
                    item.TotalConsultas,
                    item.PrimeraConsulta.ToString("dd/MM/yyyy"),
                    item.UltimaConsulta.ToString("dd/MM/yyyy"),
                    diasActivo,
                    $"{promedioConsultas:F2}"
                );
            }

            if (consultas.Count == 0)
            {
                MessageBox.Show("No se encontraron consultas de veterinarios en el rango de fechas seleccionado.",
                    "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigurarColumnasConsultas()
        {
            dataGridViewReporte.Columns.Clear();

            // Columnas específicas para Consultas
            dataGridViewReporte.Columns.Add("colId", "ID");
            dataGridViewReporte.Columns.Add("colFecha", "Fecha");
            dataGridViewReporte.Columns.Add("colMascota", "Mascota");
            dataGridViewReporte.Columns.Add("colPropietario", "Propietario");
            dataGridViewReporte.Columns.Add("colVeterinario", "Veterinario");
            dataGridViewReporte.Columns.Add("colMotivo", "Motivo");
            dataGridViewReporte.Columns.Add("colDiagnostico", "Diagnóstico");
            dataGridViewReporte.Columns.Add("colTratamiento", "Tratamiento");

            // Configurar anchos
            dataGridViewReporte.Columns["colId"].Visible = false;
            dataGridViewReporte.Columns["colFecha"].Width = 130;
            dataGridViewReporte.Columns["colMascota"].Width = 100;
            dataGridViewReporte.Columns["colPropietario"].Width = 130;
            dataGridViewReporte.Columns["colVeterinario"].Width = 120;
            dataGridViewReporte.Columns["colMotivo"].Width = 150;
            dataGridViewReporte.Columns["colDiagnostico"].Width = 180;
            dataGridViewReporte.Columns["colTratamiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ConfigurarColumnasTurnos()
        {
            dataGridViewReporte.Columns.Clear();

            // Columnas específicas para Turnos
            dataGridViewReporte.Columns.Add("colId", "ID");
            dataGridViewReporte.Columns.Add("colFechaInicio", "Fecha Inicio");
            dataGridViewReporte.Columns.Add("colFechaFin", "Fecha Fin");
            dataGridViewReporte.Columns.Add("colMascota", "Mascota");
            dataGridViewReporte.Columns.Add("colPropietario", "Propietario");
            dataGridViewReporte.Columns.Add("colUsuario", "Veterinario");
            dataGridViewReporte.Columns.Add("colDescripcion", "Descripción");
            dataGridViewReporte.Columns.Add("colEstado", "Estado");

            // Configurar anchos
            dataGridViewReporte.Columns["colId"].Visible = false;
            dataGridViewReporte.Columns["colFechaInicio"].Width = 130;
            dataGridViewReporte.Columns["colFechaFin"].Width = 130;
            dataGridViewReporte.Columns["colMascota"].Width = 100;
            dataGridViewReporte.Columns["colPropietario"].Width = 130;
            dataGridViewReporte.Columns["colUsuario"].Width = 120;
            dataGridViewReporte.Columns["colDescripcion"].Width = 200;
            dataGridViewReporte.Columns["colEstado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ConfigurarColumnasMascotas()
        {
            dataGridViewReporte.Columns.Clear();

            // Columnas específicas para Mascotas
            dataGridViewReporte.Columns.Add("colId", "ID");
            dataGridViewReporte.Columns.Add("colFechaNac", "Fecha Nacimiento");
            dataGridViewReporte.Columns.Add("colNombre", "Nombre");
            dataGridViewReporte.Columns.Add("colPropietario", "Propietario");
            dataGridViewReporte.Columns.Add("colTelefono", "Teléfono");
            dataGridViewReporte.Columns.Add("colGenero", "Género");
            dataGridViewReporte.Columns.Add("colPeso", "Peso");
            dataGridViewReporte.Columns.Add("colEdad", "Edad");
            dataGridViewReporte.Columns.Add("colConsultas", "Total Consultas");

            // Configurar anchos
            dataGridViewReporte.Columns["colId"].Visible = false;
            dataGridViewReporte.Columns["colFechaNac"].Width = 130;
            dataGridViewReporte.Columns["colNombre"].Width = 120;
            dataGridViewReporte.Columns["colPropietario"].Width = 150;
            dataGridViewReporte.Columns["colTelefono"].Width = 110;
            dataGridViewReporte.Columns["colGenero"].Width = 80;
            dataGridViewReporte.Columns["colPeso"].Width = 80;
            dataGridViewReporte.Columns["colEdad"].Width = 120;
            dataGridViewReporte.Columns["colConsultas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ConfigurarColumnasVeterinarios()
        {
            dataGridViewReporte.Columns.Clear();

            // Columnas específicas para Veterinarios
            dataGridViewReporte.Columns.Add("colPosicion", "#");
            dataGridViewReporte.Columns.Add("colNombre", "Nombre");
            dataGridViewReporte.Columns.Add("colDni", "DNI");
            dataGridViewReporte.Columns.Add("colTotal", "Total Consultas");
            dataGridViewReporte.Columns.Add("colPrimera", "Primera Consulta");
            dataGridViewReporte.Columns.Add("colUltima", "Última Consulta");
            dataGridViewReporte.Columns.Add("colDias", "Días Activo");
            dataGridViewReporte.Columns.Add("colPromedio", "Promedio/Día");

            // Configurar anchos
            dataGridViewReporte.Columns["colPosicion"].Width = 40;
            dataGridViewReporte.Columns["colNombre"].Width = 180;
            dataGridViewReporte.Columns["colDni"].Width = 100;
            dataGridViewReporte.Columns["colTotal"].Width = 120;
            dataGridViewReporte.Columns["colPrimera"].Width = 120;
            dataGridViewReporte.Columns["colUltima"].Width = 120;
            dataGridViewReporte.Columns["colDias"].Width = 100;
            dataGridViewReporte.Columns["colPromedio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private string CalcularEdad(DateTime fechaNacimiento)
        {
            TimeSpan diferencia = DateTime.Now - fechaNacimiento;
            int años = (int)(diferencia.TotalDays / 365.25);
            int meses = (int)((diferencia.TotalDays % 365.25) / 30.44);

            if (años > 0)
                return $"{años} año(s) {meses} mes(es)";
            else
                return $"{meses} mes(es)";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewReporte.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivo CSV|*.csv|Archivo de Texto|*.txt",
                    Title = "Exportar Reporte",
                    FileName = $"Reporte_{tipoReporteActual}_{DateTime.Now:yyyyMMdd_HHmmss}"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportarReporte(saveDialog.FileName);
                    MessageBox.Show($"Reporte exportado exitosamente a:\n{saveDialog.FileName}",
                        "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarReporte(string rutaArchivo)
        {
            using (var writer = new System.IO.StreamWriter(rutaArchivo, false, Encoding.UTF8))
            {
                // Escribir título del reporte
                writer.WriteLine($"REPORTE: {comboBoxTipoReporte.SelectedItem}");
                writer.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                writer.WriteLine($"Período: {dateTimePickerInicio.Value:dd/MM/yyyy} - {dateTimePickerFin.Value:dd/MM/yyyy}");
                writer.WriteLine(lblTotalRegistros.Text);
                writer.WriteLine("==================================================");
                writer.WriteLine();

                // Escribir encabezados
                var encabezados = new List<string>();
                foreach (DataGridViewColumn col in dataGridViewReporte.Columns)
                {
                    if (col.Visible)
                        encabezados.Add(col.HeaderText);
                }
                writer.WriteLine(string.Join(";", encabezados));

                // Escribir datos
                foreach (DataGridViewRow row in dataGridViewReporte.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var valores = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.OwningColumn.Visible)
                            {
                                string valor = cell.Value?.ToString() ?? "";
                                // Escapar punto y coma si está en el texto
                                valores.Add(valor.Replace(";", ","));
                            }
                        }
                        writer.WriteLine(string.Join(";", valores));
                    }
                }
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // Generar reporte inicial
            btnGenerarReporte_Click(sender, e);
        }

    }
}