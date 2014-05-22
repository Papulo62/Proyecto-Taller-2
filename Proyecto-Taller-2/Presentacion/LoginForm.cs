using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;

namespace Proyecto_Taller_2
{
    public partial class LoginForm : Form
    {
        private MiDbContext _context;
       
        public Usuario UsuarioLogueado { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _context = new MiDbContext();
        }

        private void ValidarLogin()
        {
            try
            {
                string correo = txtCorreo.Texts.Trim();
                string contraseña = txtContraseña.Texts.Trim();

              
                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             
                var usuario = _context.Usuario
                    .FirstOrDefault(u => u.correo == correo && u.contraseña == contraseña && u.activo);

                if (usuario != null)
                {
                    UsuarioLogueado = usuario;
                    this.DialogResult = DialogResult.OK;
                    
                   
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.", "Error de autenticación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Texts = "";
                    txtCorreo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
       (ex.InnerException != null ? ex.InnerException.Message : ex.Message),
       "Error al abrir la conexión",
       MessageBoxButtons.OK,
       MessageBoxIcon.Error
   );
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidarLogin();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtCorreo.Focus(); 
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidarLogin();
                e.Handled = true;
            }
        }
    }
}