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
    public partial class PropietariosForm : UserControl
    {
        public PropietariosForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rjTextBox1.Texts))
            {
                MessageBox.Show("Por favor, ingrese el nombre del propietario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Texts))
            {
                MessageBox.Show("Por favor, ingrese el apellido del propietario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rjTextBox2.Texts) || !long.TryParse(rjTextBox2.Texts, out _) || rjTextBox2.Texts.Length < 7)
            {
                MessageBox.Show("Ingrese un DNI válido (solo números, mínimo 7 dígitos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rjTextBox3.Texts))
            {
                MessageBox.Show("Ingrese el numero de teléfono del propietario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rjTextBox4.Texts) || !int.TryParse(rjTextBox4.Texts, out _))
            {
                MessageBox.Show("Ingrese una dirección válida .", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rjTextBox4.Focus();
                return;
            }

            MessageBox.Show("✅ Propietario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }


        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rjTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rjTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void rjTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Seguro que desea salir sin guardar el turno?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                Form2 formPrincipal = (Form2)this.ParentForm;

                formPrincipal.CargarUserControl(new Propietarios());
            }
        }

    }
}
