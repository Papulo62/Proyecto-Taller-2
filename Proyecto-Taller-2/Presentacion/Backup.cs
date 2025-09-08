using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(textBoxBackup.Texts))
            {
                MessageBox.Show("Debe Ingresar la ruta de archivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBackup.Focus();
                return;
            }

            MessageBox.Show("Backuo generado correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
