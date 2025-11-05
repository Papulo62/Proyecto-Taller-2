using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;
using Proyecto_Taller_2.Utils;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class VeterinariosForm : BaseUserControl
    {
        private MiDbContext _context;
        private int _idVeterinario;
        private bool _esEdicion = false;
        private string rutaImagenSeleccionada = "";

        public VeterinariosForm()
        {
            InitializeComponent();
            _context = new MiDbContext();
            _esEdicion = false;

            MostrarCombobox();

            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            btnCambiarFoto.Click += btnCambiarFoto_Click;

            rjTextBox4.KeyPress += SoloNumeros_KeyPress;
        }

        public VeterinariosForm(int idVeterinario) : this()
        {
            _idVeterinario = idVeterinario;
            _esEdicion = true;
            CargarDatosVeterinario();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void MostrarCombobox()
        {
            var especialidades = _context.Especialidad.ToList();
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "nombre_especialidad";
            cmbEspecialidad.ValueMember = "id_especialidad";
            cmbEspecialidad.SelectedIndex = -1;

            var usuarios = _context.Usuario
                .Select(u => new
                {
                    u.Id,
                    NombreCompleto = u.nombre + " " + u.apellido,
                    u.imagen_perfil
                }).ToList();

            cmbUsuario.DataSource = usuarios;
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.SelectedIndex = -1;

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem != null)
            {
                dynamic usuario = cmbUsuario.SelectedItem;
                string foto = usuario.imagen_perfil;

                if (!string.IsNullOrEmpty(foto) && File.Exists(foto))
                {
                    ImagenVeterinario.Image = Image.FromFile(foto);
                    ImagenVeterinario.SizeMode = PictureBoxSizeMode.Zoom;
                    rutaImagenSeleccionada = foto;
                }
                else
                {
                    ImagenVeterinario.Image = null;
                    rutaImagenSeleccionada = "";
                }
            }
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Seleccionar imagen de perfil";
                dialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImagenVeterinario.Image = Image.FromFile(dialog.FileName);
                    ImagenVeterinario.SizeMode = PictureBoxSizeMode.Zoom;
                    rutaImagenSeleccionada = dialog.FileName;
                }
            }
        }

        private bool ValidarCampos()
        {
            return Validaciones.ValidarTodos(
                () => Validaciones.ValidarRequerido(rjTextBox4, "Matrícula"),
                () => Validaciones.ValidarSoloNumeros(rjTextBox4, "Matrícula")
            );
        }

        private void CrearVeterinario()
        {
            try
            {
                if (!ValidarCampos()) return;

                Veterinario nuevoVet = new Veterinario
                {
                    id_usuario = (int)cmbUsuario.SelectedValue,
                    id_especialidad = (int)cmbEspecialidad.SelectedValue,
                    matricula = rjTextBox4.Texts.Trim(),
                    activo = true
                };

                _context.Veterinario.Add(nuevoVet);

                var usuario = _context.Usuario.Find((int)cmbUsuario.SelectedValue);
                if (usuario != null)
                    usuario.imagen_perfil = rutaImagenSeleccionada;

                _context.SaveChanges();
                MessageBox.Show("Veterinario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navegar<Veterinarios>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear veterinario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosVeterinario()
        {
            try
            {
                var vet = _context.Veterinario.Find(_idVeterinario);
                if (vet != null)
                {
                    cmbUsuario.SelectedValue = vet.id_usuario;
                    cmbEspecialidad.SelectedValue = vet.id_especialidad;
                    rjTextBox4.Texts = vet.matricula;

                    var usuario = _context.Usuario.Find(vet.id_usuario);
                    if (usuario != null && !string.IsNullOrEmpty(usuario.imagen_perfil) && File.Exists(usuario.imagen_perfil))
                    {
                        ImagenVeterinario.Image = Image.FromFile(usuario.imagen_perfil);
                        ImagenVeterinario.SizeMode = PictureBoxSizeMode.Zoom;
                        rutaImagenSeleccionada = usuario.imagen_perfil;
                    }
                }
                else
                {
                    MessageBox.Show("El veterinario seleccionado no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del veterinario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarVeterinario()
        {
            try
            {
                if (!ValidarCampos()) return;

                var vet = _context.Veterinario.Find(_idVeterinario);
                if (vet != null)
                {
                    vet.id_usuario = (int)cmbUsuario.SelectedValue;
                    vet.id_especialidad = (int)cmbEspecialidad.SelectedValue;
                    vet.matricula = rjTextBox4.Texts.Trim();

                    var usuario = _context.Usuario.Find(vet.id_usuario);
                    if (usuario != null)
                        usuario.imagen_perfil = rutaImagenSeleccionada;

                    _context.SaveChanges();
                    MessageBox.Show("Veterinario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Navegar<Veterinarios>();
                }
                else
                {
                    MessageBox.Show("El veterinario seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar veterinario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_esEdicion)
                ActualizarVeterinario();
            else
                CrearVeterinario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Seguro que desea salir sin guardar los cambios?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                Navegar<Veterinarios>();
            }
        }
    }
}
