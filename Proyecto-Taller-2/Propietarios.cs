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

            customDataGridView1.Rows.Add("Firulais", "Perro", "5 años");
            customDataGridView1.Rows.Add("Michi", "Gato", "3 años");
            customDataGridView1.Rows.Add("Toby", "Conejo", "2 años");
        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Propietarios_Load(object sender, EventArgs e)
        {
            CargarDatosDePrueba();
        }
    }
}
