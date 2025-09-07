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

namespace Proyecto_Taller_2.Presentacion
{
    public partial class UsuariosForm : UserControl
    {
        private MiDbContext _context;
        private int _idUsuario;
        private bool _esEdicion = false;

   
        public UsuariosForm()
        {
            InitializeComponent();
            _context = new MiDbContext();
            _esEdicion = false;
        
        }

      
        public UsuariosForm(int idUsuario) : this()
        {
            _idUsuario = idUsuario;
            _esEdicion = true;
            CargarDatosUsuario();
        }

        private void CrearUsuario()
        {
            try
            {
               
                if (!ValidarCampos())
                    return;

                var nuevoUsuario = new Usuario
                {
                    nombre = txtNombre.Texts.Trim(),
                    correo = txtCorreo.Texts.Trim(),
                    contraseña = txtContraseña.Texts,
                    rolId = (int)comboBoxRol.SelectedValue,
                    fecha_creacion = DateTime.Now,
                };

                _context.Usuario.Add(nuevoUsuario);
                _context.SaveChanges();

                MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosUsuario()
        {
            try
            {
                var usuario = _context.Usuario.Find(_idUsuario);
                if (usuario != null)
                {
                    txtNombre.Texts = usuario.nombre;
                    txtCorreo.Texts = usuario.correo;
                    txtContraseña.Texts = usuario.contraseña;
                    comboBoxRol.SelectedValue = usuario.rolId;
                }
                else
                {
                    MessageBox.Show("El usuario no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarUsuario()
        {
            try
            {
                
                if (!ValidarCampos())
                    return;

                var usuario = _context.Usuario.Find(_idUsuario);
                if (usuario != null)
                {
                    usuario.nombre = txtNombre.Texts.Trim();
                    usuario.correo = txtCorreo.Texts.Trim();
                    usuario.contraseña = txtContraseña.Texts;
                    usuario.rolId = (int)comboBoxRol.SelectedValue;

                    _context.SaveChanges();
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Texts))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Texts))
            {
                MessageBox.Show("El correo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Texts))
            {
                MessageBox.Show("La contraseña es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

            if (comboBoxRol.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxRol.Focus();
                return false;
            }

            if (!txtCorreo.Texts.Contains("@") || !txtCorreo.Texts.Contains("."))
            {
                MessageBox.Show("El formato del correo no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private void CargarRoles()
        {
            try
            {
                var roles = _context.Rol.ToList();
                comboBoxRol.DataSource = roles;
                comboBoxRol.DisplayMember = "nombre";
                comboBoxRol.ValueMember = "Id";

                if (!_esEdicion)
                {
                    comboBoxRol.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_esEdicion)
            {
                ActualizarUsuario();
            }
            else
            {
                CrearUsuario();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    pictureBoxPerfil.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
        }
    }
}