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
    public partial class Turnos : UserControl
    {
        public Turnos()
        {
            InitializeComponent();
        }

        private void CargarDatosDePrueba()
        {
            dataGridViewTurnos.Rows.Add("Juan Pérez", "40256321", "Veterinario Rural", "1122334455");
            dataGridViewTurnos.Rows.Add("Javier Milei", "37894562", "Veterinario Exotico", "1144556677");
            dataGridViewTurnos.Rows.Add("Leo Messi", "31567890", "Veterinario Domestio", "1199887766");

        }

        private void Veterinario_Load(object sender, EventArgs e)
        {
            CargarDatosDePrueba();
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            Form2 formPrincipal = (Form2)this.ParentForm;

            formPrincipal.CargarUserControl(new TurnosForm());
        }

        private void dataGridViewTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
