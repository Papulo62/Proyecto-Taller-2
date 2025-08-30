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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void CargarUserControl(UserControl control)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

       


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void iconSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Mascotas());
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Propietarios());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Usuarios());
        }

	
        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            CargarUserControl(new Veterinario());
        }
    }
}
