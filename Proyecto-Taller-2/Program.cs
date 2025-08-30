using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                LoginForm loginForm = new LoginForm();
                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Application.Run(new Form2());
                }
         }
    }
}
