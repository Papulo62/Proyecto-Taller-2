using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;
using iTextFont = iTextSharp.text.Font;
using iTextRectangle = iTextSharp.text.Rectangle;  

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
                    string nombreVet = "N/A";

                    if (consulta != null)
                    {
                        var veterinario = _context.Veterinario
                            .FirstOrDefault(v => v.IdVeterinario == consulta.id_veterinario);

                        if (veterinario != null)
                        {
                            var usuario = _context.Usuario
                                .FirstOrDefault(u => u.Id == veterinario.id_usuario);

                            if (usuario != null)
                            {
                                nombreVet = $"Dr. {usuario.nombre} {usuario.apellido}";
                            }
                        }
                    }

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
                    string estadoTexto = estado != null ? estado.Nombre : "Desconocido";

                    dataGridViewHistorial.Rows.Add(
                        turno.id_turno,
                        turno.fecha_inicio.ToString("dd/MM/yyyy HH:mm"),
                        turno.descripcion_turno,
                        nombreUsuario,
                        estadoTexto,
                        turno.activo ? "Activo" : "Inactivo",
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivos PDF|*.pdf|Archivos de texto|*.txt|Todos los archivos|*.*",
                    Title = "Exportar Historial Clínico",
                    FileName = $"Historial_{nombreMascotaActual}_{DateTime.Now:yyyyMMdd}.pdf",
                    DefaultExt = "pdf"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(saveDialog.FileName).ToLower();
                      ExportarHistorialPDF(saveDialog.FileName);
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

      
        private void ExportarHistorialPDF(string rutaArchivo)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();
                    var fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.DARK_GRAY);
                    var fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);
                    var fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                    var fontLabel = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.BLACK);
                    Paragraph titulo = new Paragraph($"HISTORIAL CLÍNICO - {nombreMascotaActual}", fontTitulo);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 10f;
                    document.Add(titulo);
                    Paragraph fecha = new Paragraph($"Fecha de exportación: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal);
                    fecha.Alignment = Element.ALIGN_CENTER;
                    fecha.SpacingAfter = 20f;
                    document.Add(fecha);
                    document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -1))));
                    document.Add(new Paragraph(" "));
                    Paragraph tituloConsultas = new Paragraph("CONSULTAS", fontSubtitulo);
                    tituloConsultas.SpacingBefore = 10f;
                    tituloConsultas.SpacingAfter = 10f;
                    document.Add(tituloConsultas);

                    var consultas = _context.Consulta
                        .Where(c => c.id_mascota == mascotaIdActual)
                        .OrderByDescending(c => c.fecha_consulta)
                        .ToList();

                    if (consultas.Any())
                    {
                        foreach (var consulta in consultas)
                        {
                            var veterinario = _context.Usuario.FirstOrDefault(u => u.Id == consulta.id_veterinario);
                            string nombreVet = veterinario != null ? veterinario.nombre : "N/A";

                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 1f, 3f });
                            table.SpacingBefore = 5f;
                            table.SpacingAfter = 10f;

                            AgregarFilaTabla(table, "Fecha:", consulta.fecha_consulta.ToString("dd/MM/yyyy"), fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Veterinario:", $"Dr. {nombreVet}", fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Motivo:", consulta.motivo, fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Diagnóstico:", consulta.diagnostico, fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Tratamiento:", consulta.tratamiento, fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Síntomas:", consulta.sintomas, fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Próximo control:", consulta.proximo_control.ToString("dd/MM/yyyy"), fontLabel, fontNormal);

                            document.Add(table);
                            document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.3f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1))));
                        }
                    }
                    else
                    {
                        document.Add(new Paragraph("No hay consultas registradas.", fontNormal));
                    }

                    document.Add(new Paragraph(" "));
                    Paragraph tituloTurnos = new Paragraph("TURNOS", fontSubtitulo);
                    tituloTurnos.SpacingBefore = 10f;
                    tituloTurnos.SpacingAfter = 10f;
                    document.Add(tituloTurnos);

                    var turnos = _context.Turno
                        .Where(t => t.id_mascota == mascotaIdActual)
                        .OrderByDescending(t => t.fecha_inicio)
                        .ToList();

                    if (turnos.Any())
                    {
                        foreach (var turno in turnos)
                        {
                            var estado = _context.Estado.FirstOrDefault(e => e.IdEstado == turno.id_estado);
                            string estadoTexto = estado != null ? estado.Nombre : "Desconocido";
                            var usuario = _context.Usuario.FirstOrDefault(u => u.Id == turno.id_usuario);
                            string nombreUsuario = usuario != null ? usuario.nombre : "N/A";

                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 1f, 3f });
                            table.SpacingBefore = 5f;
                            table.SpacingAfter = 10f;

                            AgregarFilaTabla(table, "Fecha:", turno.fecha_inicio.ToString("dd/MM/yyyy HH:mm"), fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Veterinario:", $"Dr. {nombreUsuario}", fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Descripción:", turno.descripcion_turno, fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Estado:", estadoTexto, fontLabel, fontNormal);
                            AgregarFilaTabla(table, "Activo:", turno.activo ? "Sí" : "No", fontLabel, fontNormal);

                            document.Add(table);
                            document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.3f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1))));
                        }
                    }
                    else
                    {
                        document.Add(new Paragraph("No hay turnos registrados.", fontNormal));
                    }

                    document.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void AgregarFilaTabla(PdfPTable table, string label, string valor, iTextFont fontLabel, iTextFont fontNormal)
        {
            PdfPCell cellLabel = new PdfPCell(new Phrase(label, fontLabel));
            cellLabel.Border = iTextRectangle.NO_BORDER; 
            cellLabel.PaddingBottom = 5f;
            table.AddCell(cellLabel);

            PdfPCell cellValor = new PdfPCell(new Phrase(valor ?? "N/A", fontNormal));
            cellValor.Border = iTextRectangle.NO_BORDER;  
            cellValor.PaddingBottom = 5f;
            table.AddCell(cellValor);
        }
        private void HistorialClinico_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasConsultas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Navegar<Mascotas>();
        }
    }
}