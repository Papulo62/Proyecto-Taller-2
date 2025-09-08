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
    public partial class Form4 : UserControl
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            // Validar Nombre
            if (string.IsNullOrWhiteSpace(rjTextBox1.Texts))
            {
                MessageBox.Show("Por favor, ingrese el nombre del veterinario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox1.Focus();
                return;
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(rjTextBox2.Texts) || !long.TryParse(rjTextBox2.Texts, out _) || rjTextBox2.Texts.Length < 7)
            {
                MessageBox.Show("Ingrese un DNI válido (solo números, mínimo 7 dígitos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox2.Focus();
                return;
            }

            // Validar Especialidad
            if (string.IsNullOrWhiteSpace(rjTextBox3.Texts))
            {
                MessageBox.Show("Ingrese la especialidad del veterinario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox3.Focus();
                return;
            }

            // Validar Matrícula
            if (string.IsNullOrWhiteSpace(rjTextBox4.Texts) || !int.TryParse(rjTextBox4.Texts, out _))
            {
                MessageBox.Show("Ingrese una matrícula válida (solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox4.Focus();
                return;
            }

            // Si pasa todas las validaciones
            MessageBox.Show("✅ Veterinario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rjTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
