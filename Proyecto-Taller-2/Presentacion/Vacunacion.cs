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
    public partial class Vacunacion : UserControl
    {
        public Vacunacion()
        {
            InitializeComponent();
        }

        private void btnVacunacion_Click(object sender, EventArgs e)
        {
            Form2 formPrincipal = (Form2)this.ParentForm;

            formPrincipal.CargarUserControl(new VacunacionForm());
        }
    }
}
