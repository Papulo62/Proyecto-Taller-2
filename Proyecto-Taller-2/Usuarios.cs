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
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
           
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            customDataGridView1.Rows.Add("Fabian", "hola123", "fabian123@gmail.com");
            customDataGridView1.Rows.Add("pedro", "123456", "pedroramirez@gmail.com");
            customDataGridView1.Rows.Add("Tomas", "12345", "tomas512@gmail.com");
        }
    }
}
