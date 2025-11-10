using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Backup : UserControl
    {
        private const string NOMBRE_BASE_DATOS = "My_Vet";
        private const string CONNECTION_STRING = "Data Source=.;Initial Catalog=My_Vet;Integrated Security=True;";

        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            string rutaPorDefecto = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Backups_MyVet"
            );

            textBoxBackup.Texts = rutaPorDefecto;
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione la carpeta donde guardar el backup";
                    folderDialog.ShowNewFolderButton = true;

                    if (!string.IsNullOrEmpty(textBoxBackup.Texts))
                    {
                        string directorioActual = textBoxBackup.Texts;
                        if (File.Exists(directorioActual))
                        {
                            directorioActual = Path.GetDirectoryName(directorioActual);
                        }

                        if (Directory.Exists(directorioActual))
                        {
                            folderDialog.SelectedPath = directorioActual;
                        }
                    }

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        textBoxBackup.Texts = folderDialog.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar carpeta: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxBackup.Texts))
                {
                    MessageBox.Show("Debe seleccionar una carpeta de destino.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string carpetaDestino = textBoxBackup.Texts.Trim();

                if (!Directory.Exists(carpetaDestino))
                {
                    var resultado = MessageBox.Show(
                        "La carpeta seleccionada no existe. ¿Desea crearla?",
                        "Crear Carpeta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(carpetaDestino);
                    }
                    else
                    {
                        return;
                    }
                }

                string nombreArchivo = $"Backup_{NOMBRE_BASE_DATOS}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

                var confirmacion = MessageBox.Show(
                    $"Se generará el backup en:\n\n{rutaCompleta}\n\n¿Desea continuar?",
                    "Confirmar Backup",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                Cursor = Cursors.WaitCursor;
                btnGenerarBackup.Enabled = false;
                btnSeleccionarRuta.Enabled = false;

                GenerarBackup(rutaCompleta);

                Cursor = Cursors.Default;
                btnGenerarBackup.Enabled = true;
                btnSeleccionarRuta.Enabled = true;

                var abrirCarpeta = MessageBox.Show(
                    $"✓ Backup generado correctamente:\n\n{rutaCompleta}\n\n" +
                    $"Tamaño: {ObtenerTamañoArchivo(rutaCompleta)}\n\n" +
                    "¿Desea abrir la carpeta de destino?",
                    "Éxito",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (abrirCarpeta == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{rutaCompleta}\"");
                }
            }
            catch (SqlException sqlEx)
            {
                Cursor = Cursors.Default;
                btnGenerarBackup.Enabled = true;
                btnSeleccionarRuta.Enabled = true;

                MessageBox.Show(
                    $"Error de SQL al generar el backup:\n\n{sqlEx.Message}\n\n" +
                    "Posibles causas:\n" +
                    "• El servicio de SQL Server no está iniciado\n" +
                    "• No tiene permisos suficientes\n" +
                    "• La base de datos no existe o está en uso",
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                btnGenerarBackup.Enabled = true;
                btnSeleccionarRuta.Enabled = true;

                MessageBox.Show($"Error al generar el backup:\n\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarBackup(string rutaBackup)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string editionQuery = "SELECT SERVERPROPERTY('Edition')";
                string edition = new SqlCommand(editionQuery, connection).ExecuteScalar().ToString();

                bool esExpress = edition.Contains("Express");

                string query = $@"
            BACKUP DATABASE [{NOMBRE_BASE_DATOS}]
            TO DISK = @rutaBackup
            WITH FORMAT,
                 INIT,
                 NAME = 'Backup de {NOMBRE_BASE_DATOS} - {DateTime.Now:dd/MM/yyyy HH:mm}',
                 SKIP,
                 NOREWIND,
                 NOUNLOAD,
                 STATS = 10
                 {(esExpress ? "" : ", COMPRESSION")}
        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@rutaBackup", rutaBackup);
                    command.CommandTimeout = 300;
                    command.ExecuteNonQuery();
                }
            }
        }


        private string ObtenerTamañoArchivo(string rutaArchivo)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(rutaArchivo);
                long tamañoBytes = fileInfo.Length;

                string[] tamaños = { "B", "KB", "MB", "GB" };
                double tamaño = tamañoBytes;
                int orden = 0;

                while (tamaño >= 1024 && orden < tamaños.Length - 1)
                {
                    orden++;
                    tamaño = tamaño / 1024;
                }

                return $"{tamaño:0.##} {tamaños[orden]}";
            }
            catch
            {
                return "Desconocido";
            }
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}