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
    public partial class HistorialClinico : BaseUserControl
    {
        private MiDbContext _context;
        private int mascotaIdActual;
        private string nombreMascotaActual;
        private bool estaEnTabConsultas = true;

        public HistorialClinico()
        {
            InitializeComponent();
            _context = new MiDbContext();
            InicializarVista();
        }

        public HistorialClinico(int idMascota) : this()
        {
            mascotaIdActual = idMascota;

            var mascota = _context.Mascota.FirstOrDefault(m => m.IdMascota == idMascota);
            nombreMascotaActual = mascota != null ? mascota.Nombre : "Desconocida";

            CargarHistorial();
        }

        public HistorialClinico(int idMascota, string nombreMascota) : this()
        {
            mascotaIdActual = idMascota;
            nombreMascotaActual = nombreMascota;
            CargarHistorial();
        }

        private void InicializarVista()
        {
            btnConsultas.BackColor = Color.FromArgb(76, 175, 80);
            btnConsultas.ForeColor = Color.White;
            btnTurnos.BackColor = Color.LightGray;
            btnTurnos.ForeColor = Color.Black;

            panelDetalles.Visible = false;
        }

        private void CargarHistorial()
        {
            lblNombreMascota.Text = $" Historial Clínico - {nombreMascotaActual}";

            if (estaEnTabConsultas)
            {
                CargarConsultas();
            }
            else
            {
                CargarTurnos();
            }
        }

        private void CargarConsultas()
        {
            try
            {
                dataGridViewHistorial.Rows.Clear();
                panelDetalles.Visible = false;

                var consultas = _context.Consulta
                    .Where(c => c.id_mascota == mascotaIdActual)
                    .OrderByDescending(c => c.fecha_consulta)
                    .ToList();

                foreach (var consulta in consultas)
                {
                    var veterinario = _context.Usuario.FirstOrDefault(u => u.Id == consulta.id_veterinario);
                    string nombreVet = veterinario != null ? $"Dr. {veterinario.nombre}" : "N/A";

                    dataGridViewHistorial.Rows.Add(
                        consulta.Id,
                        consulta.fecha_consulta.ToString("dd/MM/yyyy"),
                        consulta.motivo,
                        nombreVet,
                        consulta.diagnostico,
                        consulta.tratamiento,
                        consulta.sintomas,
                        consulta.proximo_control.ToString("dd/MM/yyyy")
                    );
                }

                if (consultas.Count == 0)
                {
                    MessageBox.Show("No hay consultas registradas para esta mascota.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar consultas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTurnos()
        {
            try
            {
                dataGridViewHistorial.Rows.Clear();
                panelDetalles.Visible = false;

                var turnos = _context.Turno
                    .Where(t => t.id_mascota == mascotaIdActual)
                    .OrderByDescending(t => t.fecha_inicio)
                    .ToList();

                foreach (var turno in turnos)
                {
                    var usuario = _context.Usuario.FirstOrDefault(u => u.Id == turno.id_usuario);
                    string nombreUsuario = usuario != null ? $"Dr. {usuario.nombre}" : "N/A";

                    var estado = _context.Estado.FirstOrDefault(e => e.IdEstado == turno.id_estado);
                   
                    string estadoNombre = estado != null ? estado.Nombre : "N/A";

                    dataGridViewHistorial.Rows.Add(
                        turno.id_turno,
                        turno.fecha_inicio.ToString("dd/MM/yyyy HH:mm"),
                        turno.descripcion_turno,
                        nombreUsuario,
                        estadoNombre,
                        turno.activo ? "Activo" : "Finalizado",
                        "",
                        turno.fecha_fin.HasValue ? turno.fecha_fin.Value.ToString("dd/MM/yyyy HH:mm") : "N/A"
                    );
                }

                if (turnos.Count == 0)
                {
                    MessageBox.Show("No hay turnos registrados para esta mascota.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar turnos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            estaEnTabConsultas = true;

            btnConsultas.BackColor = Color.FromArgb(76, 175, 80);
            btnConsultas.ForeColor = Color.White;
            btnTurnos.BackColor = Color.LightGray;
            btnTurnos.ForeColor = Color.Black;

            ConfigurarColumnasConsultas();
            CargarConsultas();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            estaEnTabConsultas = false;

            btnTurnos.BackColor = Color.FromArgb(76, 175, 80);
            btnTurnos.ForeColor = Color.White;
            btnConsultas.BackColor = Color.LightGray;
            btnConsultas.ForeColor = Color.Black;

            ConfigurarColumnasTurnos();
            CargarTurnos();
        }

        private void ConfigurarColumnasConsultas()
        {
            colDiagnostico.Visible = true;
            colTratamiento.Visible = true;
            colSintomas.Visible = true;
            colProximoControl.Visible = true;

            colDiagnostico.HeaderText = "Diagnóstico";
            colTratamiento.HeaderText = "Tratamiento";
            colSintomas.HeaderText = "Síntomas";
            colProximoControl.HeaderText = "Próximo Control";
        }

        private void ConfigurarColumnasTurnos()
        {
            colDiagnostico.HeaderText = "Estado";
            colDiagnostico.Visible = true;

            colTratamiento.HeaderText = "Activo";
            colTratamiento.Visible = false;

            colSintomas.Visible = false;

            colProximoControl.HeaderText = "Fecha Fin";
            colProximoControl.Visible = true;
        }

        private void dataGridViewHistorial_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHistorial.SelectedRows.Count > 0)
            {
                MostrarDetalles();
            }
        }

        private void MostrarDetalles()
        {
            if (dataGridViewHistorial.SelectedRows.Count == 0) return;

            var row = dataGridViewHistorial.SelectedRows[0];
            panelDetalles.Visible = true;

            if (estaEnTabConsultas)
            {
                lblDetallesTitulo.Text = "Detalles de la Consulta";

                int idConsulta = Convert.ToInt32(row.Cells["colId"].Value);
                var consulta = _context.Consulta.FirstOrDefault(c => c.Id == idConsulta);

                if (consulta != null)
                {
                    txtDiagnostico.Text = !string.IsNullOrEmpty(consulta.diagnostico)
                        ? consulta.diagnostico
                        : "No especificado";

                    txtTratamiento.Text = !string.IsNullOrEmpty(consulta.tratamiento)
                        ? consulta.tratamiento
                        : "No especificado";

                    txtObservaciones.Text = !string.IsNullOrEmpty(consulta.sintomas)
                        ? consulta.sintomas
                        : "No se registraron síntomas";

                    lblProximoControl.Visible = true;
                    lblProximoControlValor.Visible = true;
                    lblProximoControlValor.Text = consulta.proximo_control.ToString("dd/MM/yyyy");

                    if (consulta.proximo_control < DateTime.Now)
                    {
                        lblProximoControlValor.ForeColor = Color.FromArgb(244, 67, 54); 
                    }
                    else
                    {
                        lblProximoControlValor.ForeColor = Color.FromArgb(76, 175, 80); 
                    }
                }

                label2.Text = "Diagnóstico:";
                label3.Text = "Tratamiento:";
                label4.Text = "Síntomas/Observaciones:";
            }
            else
            {
                lblDetallesTitulo.Text = "Detalles del Turno";

                int idTurno = Convert.ToInt32(row.Cells["colId"].Value);
                var turno = _context.Turno.FirstOrDefault(t => t.id_turno == idTurno);

                if (turno != null)
                {
                    var estado = _context.Estado.FirstOrDefault(e => e.IdEstado == turno.id_estado);
                    string estadoNombre = estado != null ? estado.Nombre : "Desconocido";

                    txtDiagnostico.Text = estadoNombre;

                    string infoFechas = $"Fecha Inicio: {turno.fecha_inicio:dd/MM/yyyy HH:mm}\n";
                    if (turno.fecha_fin.HasValue)
                    {
                        infoFechas += $"Fecha Fin: {turno.fecha_fin.Value:dd/MM/yyyy HH:mm}";
                    }
                    else
                    {
                        infoFechas += "Fecha Fin: Pendiente";
                    }
                    infoFechas += $"\n\nEstado: {(turno.activo ? "✓ Activo" : "✗ Inactivo")}";

                    txtTratamiento.Text = infoFechas;

                    txtObservaciones.Text = !string.IsNullOrEmpty(turno.descripcion_turno)
                        ? turno.descripcion_turno
                        : "Sin descripción";

                    lblProximoControl.Visible = false;
                    lblProximoControlValor.Visible = false;
                }

                label2.Text = "Estado del Turno:";
                label3.Text = "Información de Fechas:";
                label4.Text = "Descripción:";
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivos de texto|*.txt|Todos los archivos|*.*",
                    Title = "Exportar Historial Clínico",
                    FileName = $"Historial_{nombreMascotaActual}_{DateTime.Now:yyyyMMdd}.txt"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportarHistorialTexto(saveDialog.FileName);
                    MessageBox.Show($"Historial exportado exitosamente a:\n{saveDialog.FileName}",
                        "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarHistorialTexto(string rutaArchivo)
        {
            using (var writer = new System.IO.StreamWriter(rutaArchivo))
            {
                writer.WriteLine("=================================================");
                writer.WriteLine($"HISTORIAL CLÍNICO - {nombreMascotaActual}");
                writer.WriteLine($"Fecha de exportación: {DateTime.Now:dd/MM/yyyy HH:mm}");
                writer.WriteLine("=================================================");
                writer.WriteLine();

                // Exportar Consultas
                writer.WriteLine("CONSULTAS:");
                writer.WriteLine("-------------------------------------------------");

                var consultas = _context.Consulta
                    .Where(c => c.id_mascota == mascotaIdActual)
                    .OrderByDescending(c => c.fecha_consulta)
                    .ToList();

                foreach (var consulta in consultas)
                {
                    var veterinario = _context.Usuario.FirstOrDefault(u => u.Id == consulta.id_veterinario);
                    string nombreVet = veterinario != null ? veterinario.nombre : "N/A";

                    writer.WriteLine($"Fecha: {consulta.fecha_consulta:dd/MM/yyyy}");
                    writer.WriteLine($"Veterinario: Dr. {nombreVet}");
                    writer.WriteLine($"Motivo: {consulta.motivo}");
                    writer.WriteLine($"Diagnóstico: {consulta.diagnostico}");
                    writer.WriteLine($"Tratamiento: {consulta.tratamiento}");
                    writer.WriteLine($"Síntomas: {consulta.sintomas}");
                    writer.WriteLine($"Próximo control: {consulta.proximo_control:dd/MM/yyyy}");
                    writer.WriteLine("-------------------------------------------------");
                }

                writer.WriteLine();
                writer.WriteLine("TURNOS:");
                writer.WriteLine("-------------------------------------------------");

                var turnos = _context.Turno
                    .Where(t => t.id_mascota == mascotaIdActual)
                    .OrderByDescending(t => t.fecha_inicio)
                    .ToList();

                foreach (var turno in turnos)
                {
                    var usuario = _context.Usuario.FirstOrDefault(u => u.Id == turno.id_usuario);
                    var estado = _context.Estado.FirstOrDefault(e => e.IdEstado == turno.id_estado);
                    string nombreUsuario = usuario != null ? usuario.nombre : "N/A";
                    string estadoNombre = estado != null ? estado.Nombre : "N/A";

                    writer.WriteLine($"Fecha: {turno.fecha_inicio:dd/MM/yyyy HH:mm}");
                    writer.WriteLine($"Veterinario: Dr. {nombreUsuario}");
                    writer.WriteLine($"Descripción: {turno.descripcion_turno}");
                    writer.WriteLine($"Estado: {estado}");
                    writer.WriteLine($"Activo: {(turno.activo ? "Sí" : "No")}");
                    writer.WriteLine("-------------------------------------------------");
                }
            }
        }

        private void HistorialClinico_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasConsultas();
        }

       
    }
}