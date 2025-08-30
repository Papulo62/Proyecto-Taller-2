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
    public partial class Mascotas : UserControl
    {
        public Mascotas()
        {
            InitializeComponent();
            
        }

        private void CargarDatosDePrueba()
        {
           
            dataGridView1.Rows.Add("Firulais", "Perro", "5 años");
            dataGridView1.Rows.Add("Michi", "Gato", "3 años");
            dataGridView1.Rows.Add("Toby", "Conejo", "2 años");
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            CargarDatosDePrueba();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form2 formPrincipal = (Form2)this.ParentForm;
            formPrincipal.CargarUserControl(new MascotasForm());
        }
    }
}
