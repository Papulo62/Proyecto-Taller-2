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
    public partial class TurnosForm : BaseUserControl
    {
        public TurnosForm()
        {
            InitializeComponent();
        }

        private void Turnos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {

            // Validar fecha futura
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy.");
                return;
            }

            if (comboBoxHora.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un horario.");
                return;
            }

            if (comboBoxMascota.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una mascota.");
                return;
            }

            if (comboBoxPropietario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un propietario.");
                return;
            }

            if (comboBoxVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un veterinario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMotivo.Texts))
            {
                MessageBox.Show("Debe ingresar el motivo de la consulta.");
                return;
            }

            MessageBox.Show("Turno registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtMotivo__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que desea salir sin guardar el turno?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Navegar<TurnosForm>();
            }
        }
    }
}
