using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;
using Proyecto_Taller_2.Presentacion;

namespace Proyecto_Taller_2
{
    public partial class MascotasForm : UserControl
    {
        public MascotasForm()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtPeso.KeyPress += txtPeso_KeyPress;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox != null)
            {
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true; 
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Texts))
            {
                MessageBox.Show("Debe ingresar el nombre de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Texts, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cmbEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especie.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEspecie.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRaza.Text))
            {
                MessageBox.Show("Debe ingresar o seleccionar una raza.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRaza.Focus();
                return;
            }

            if (cmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el sexo de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSexo.Focus();
                return;
            }

            if (cmbEstadoReproductivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el estado reproductivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstadoReproductivo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Texts))
            {
                MessageBox.Show("Debe ingresar el peso de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }
            if (!decimal.TryParse(txtPeso.Text, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("El peso debe ser un número válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            if (dptNacimiento.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dptNacimiento.Focus();
                return;
            }

            if (cmbVivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar si la mascota está viva.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVivo.Focus();
                return;
            }

            MessageBox.Show("Mascota registrada correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "¿Seguro que desea salir sin guardar la mascota?",
              "Confirmar salida",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                Form2 formPrincipal = (Form2)this.ParentForm;

                formPrincipal.CargarUserControl(new Mascotas());
            }
        }
    }
    
}

