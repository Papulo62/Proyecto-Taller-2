using System;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    public partial class VacunacionForm : UserControl
    {
        public VacunacionForm()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click; 
        }

        private bool ValidarFormulario()
        {
            if (comboBoxMascota.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxVacuna.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una vacuna.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un veterinario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLote.Text))
            {
                MessageBox.Show("Debe ingresar el número de lote.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLaboratorio.Text))
            {
                MessageBox.Show("Debe ingresar el laboratorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtObservaciones.Text.Length > 250)
            {
                MessageBox.Show("Las observaciones no pueden superar los 250 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dateTimeVacuna.Value.Date <= DateTime.Today)
            {
                MessageBox.Show("La fecha de la próxima vacunación debe ser posterior a hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                MessageBox.Show("Vacunación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
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

                formPrincipal.CargarUserControl(new Vacunacion());
            }
        }
    }
}
