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
    public partial class Veterinario : UserControl
    {
        public Veterinario()
        {
            InitializeComponent();
        }

        private void CargarDatosDePrueba()
        {
            dataGridView1.Rows.Add("Juan Pérez", "40256321", "Veterinario Rural", "1122334455");
            dataGridView1.Rows.Add("Javier Milei", "37894562", "Veterinario Exotico", "1144556677");
            dataGridView1.Rows.Add("Leo Messi", "31567890", "Veterinario Domestio", "1199887766");

        }

        private void Veterinario_Load(object sender, EventArgs e)
        {
            CargarDatosDePrueba();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            Form2 formPrincipal = (Form2)this.ParentForm;

            formPrincipal.CargarUserControl(new VeterinariosForm());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
