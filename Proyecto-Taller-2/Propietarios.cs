using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    public partial class Propietarios : UserControl
    {
        public Propietarios()
        {
            InitializeComponent();
        }

        private void CargarDatosDePrueba()
        {
            dataGridView1.Rows.Add("Juan Pérez", "40256321", "Calle belgrano 123", "1122334455");
            dataGridView1.Rows.Add("Javier Milei", "37894562", "Av. Perón 742", "1144556677");
            dataGridView1.Rows.Add("Leo Messi", "31567890", "San Martín 456", "1199887766");

        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Propietarios_Load(object sender, EventArgs e)
        {
            CargarDatosDePrueba();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            PropietariosForm nuevoPro = new Form3();

            nuevoPro.Show();
        }
    }
}
