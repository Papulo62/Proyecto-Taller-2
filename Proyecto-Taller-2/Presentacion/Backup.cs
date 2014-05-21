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
        public Backup()
        {
            InitializeComponent();
        }

       

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }



        private void customButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxBackup.Texts))
                {
                    MessageBox.Show("Debe ingresar la ruta del archivo.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBackup.Focus();
                    return;
                }

                string rutaBackup = textBoxBackup.Texts.Trim();
                string directorio = Path.GetDirectoryName(rutaBackup);
                if (!Directory.Exists(directorio))
                {
                    MessageBox.Show("La carpeta de destino no existe.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombreBaseDatos = "My_Vet";

                string connectionString = "Data Source=.;Initial Catalog=" + nombreBaseDatos + ";Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $@"
                BACKUP DATABASE [{nombreBaseDatos}]
                TO DISK = @rutaBackup
                WITH FORMAT,
                     INIT,
                     NAME = 'Backup de {nombreBaseDatos}',
                     SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@rutaBackup", rutaBackup);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(" Backup generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el backup:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
