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

        // Constructor sin parámetros
        public HistorialClinico()
        {
            InitializeComponent();
            _context = new MiDbContext();
            InicializarVista();
        }

        // Constructor con parámetros para recibir la mascota
        public HistorialClinico(int idMascota, string nombreMascota) : this()
        {
            mascotaIdActual = idMascota;
            nombreMascotaActual = nombreMascota;
            CargarHistorial();
        }

        private void InicializarVista()
        {
            // Configurar pestañas
            btnConsultas.BackColor = Color.FromArgb(76, 175, 80);
            btnConsultas.ForeColor = Color.White;
            btnTurnos.BackColor = Color.LightGray;
            btnTurnos.ForeColor = Color.Black;

            // Ocultar panel de detalles inicialmente
            panelDetalles.Visible = false;
        }

        private void CargarHistorial()
        {
            lblNombreMascota.Text = $"🐶 Historial Clínico - {nombreMascotaActual}";

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
                    // Obtener nombre del veterinario
                    var veterinario = _context.Usuario.FirstOrDefault(u => u.Id == consulta.id_veterinario);
                    string nombreVet = veterinario != null ? $"Dr. {veterinario.nombre_usuario}" : "N/A";

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
                    // Obtener nombre del veterinario/usuario
                    var usuario = _context.Usuario.FirstOrDefault(u => u.id_usuario == turno.id_usuario);
                    string nombreUsuario = usuario != null ? $"Dr. {usuario.nombre_usuario}" : "N/A";

                    // Obtener estado
                    var estado = _context.Estado.FirstOrDefault(e => e.id_estado == turno.id_estado);
                    string estadoTexto = estado != null ? estado.nombre_estado : turno.estado_turno;

                    dataGridViewHistorial.Rows.Add(
                        turno.id_turno,
                        turno.fecha_inicio.ToString("dd/MM/yyyy HH:mm"),
                        turno.descripcion_turno,
                        nombreUsuario,
                        estadoTexto,
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

            // Cambiar estilos de botones
            btnConsultas.BackColor = Color.FromArgb(76, 175, 80);
            btnConsultas.ForeColor = Color.White;
            btnTurnos.BackColor = Color.LightGray;
            btnTurnos.ForeColor = Color.Black;

            // Configurar columnas para consultas
            ConfigurarColumnasConsultas();
            CargarConsultas();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            estaEnTabConsultas = false;

            // Cambiar estilos de botones
            btnTurnos.BackColor = Color.FromArgb(76, 175, 80);
            btnTurnos.ForeColor = Color.White;
            btnConsultas.BackColor = Color.LightGray;
            btnConsultas.ForeColor = Color.Black;

            // Configurar columnas para turnos
            ConfigurarColumnasTurnos();
            CargarTurnos();
        }

        private void ConfigurarColumnasConsultas()
        {
            // Mostrar columnas de consultas
            colDiagnostico.Visible = true;
            colTratamiento.Visible = true;
            colSintomas.Visible = true;
            colProximoControl.Visible = true;

            // Ajustar encabezados
            colDiagnostico.HeaderText = "Diagnóstico";
            colTratamiento.HeaderText = "Tratamiento";
            colSintomas.HeaderText = "Síntomas";
            colProximoControl.HeaderText = "Próximo Control";
        }

        private void ConfigurarColumnasTurnos()
        {
            // Ajustar encabezados para turnos
            colDiagnostico.HeaderText = "Estado";
            colDiagnostico.Visible = true;

            colTratamiento.HeaderText = "Activo";
            colTratamiento.Visible = true;

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

                txtDiagnostico.Text = row.Cells["colDiagnostico"].Value?.ToString() ?? "No especificado";
                txtTratamiento.Text = row.Cells["colTratamiento"].Value?.ToString() ?? "No especificado";
                txtObservaciones.Text = row.Cells["colSintomas"].Value?.ToString() ?? "No especificado";

                lblProximoControl.Visible = true;
                lblProximoControlValor.Visible = true;
                lblProximoControlValor.Text = row.Cells["colProximoControl"].Value?.ToString() ?? "N/A";
            }
            else
            {
                lblDetallesTitulo.Text = "Detalles del Turno";

                string estado = row.Cells["colDiagnostico"].Value?.ToString() ?? "";
                string activo = row.Cells["colTratamiento"].Value?.ToString() ?? "";
                string descripcion = row.Cells["colMotivo"].Value?.ToString() ?? "";
                string fechaFin = row.Cells["colProximoControl"].Value?.ToString() ?? "";

                txtDiagnostico.Text = $"Estado: {estado}";
                txtTratamiento.Text = $"Estado del turno: {activo}";
                txtObservaciones.Text = $"Descripción: {descripcion}\r\n\r\nFecha de finalización: {fechaFin}";

                lblProximoControl.Visible = false;
                lblProximoControlValor.Visible = false;
            }
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            if (mascotaIdActual == 0)
            {
                MessageBox.Show("Debe seleccionar una mascota primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir formulario de nueva consulta pasando el ID de la mascota
            // Ajusta esto según tu implementación
            Navegar(new ConsultasForm(mascotaIdActual));

            // O si tu formulario no recibe parámetros en el constructor:
            // Navegar<ConsultasForm>();
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
                    var veterinario = _context.Usuario.FirstOrDefault(u => u.id_usuario == consulta.id_veterinario);
                    string nombreVet = veterinario != null ? veterinario.nombre_usuario : "N/A";

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
                    var usuario = _context.Usuario.FirstOrDefault(u => u.id_usuario == turno.id_usuario);
                    string nombreUsuario = usuario != null ? usuario.nombre_usuario : "N/A";

                    writer.WriteLine($"Fecha: {turno.fecha_inicio:dd/MM/yyyy HH:mm}");
                    writer.WriteLine($"Veterinario: Dr. {nombreUsuario}");
                    writer.WriteLine($"Descripción: {turno.descripcion_turno}");
                    writer.WriteLine($"Estado: {turno.estado_turno}");
                    writer.WriteLine($"Activo: {(turno.activo ? "Sí" : "No")}");
                    writer.WriteLine("-------------------------------------------------");
                }
            }
        }

        private void HistorialClinico_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasConsultas();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (_context != null)
                {
                    _context.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}