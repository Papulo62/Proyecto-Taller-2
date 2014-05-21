
using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;
using Proyecto_Taller_2.Utils;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class PropietariosForm : BaseUserControl
    {
        private MiDbContext _context;
        private int _idPropietario;
        private bool _esEdicion = false;

        public PropietariosForm()
        {
            InitializeComponent();
            _context = new MiDbContext();
            _esEdicion = false;

           
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtApellido.KeyPress += SoloLetras_KeyPress;
            txtDni.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
            txtTelefonoAlt.KeyPress += SoloNumeros_KeyPress;
        }

        public PropietariosForm(int idPropietario) : this()
        {
            _idPropietario = idPropietario;
            _esEdicion = true;
           CargarDatosPropietario();
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidarCampos()
        {
            return Validaciones.ValidarTodos(
                () => Validaciones.ValidarRequerido(txtNombre, "Nombre"),
                () => Validaciones.ValidarSoloLetras(txtNombre, "Nombre"),
                () => Validaciones.ValidarRequerido(txtApellido, "Apellido"),
                () => Validaciones.ValidarSoloLetras(txtApellido, "Apellido"),
                () => Validaciones.ValidarRequerido(txtDni, "DNI"),
                () => Validaciones.ValidarSoloNumeros(txtDni, "DNI"),
                () => Validaciones.ValidarLongitudMinima(txtDni, "DNI", 8),
                () => Validaciones.ValidarRequerido(txtDireccion, "Dirección"),
                () => Validaciones.ValidarRequerido(txtTelefono, "Teléfono"),
                () => Validaciones.ValidarSoloNumeros(txtTelefono, "Teléfono"),
                () => Validaciones.ValidarRangoNumerico(txtTelefono, "Teléfono", 1000000, 9999999999),
                () => Validaciones.ValidarSoloNumeros(txtTelefonoAlt, "Teléfono alternativo")
            );
        }

        private void CrearPropietario()
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var nuevoPropietario = new Propietario
                {
                    nombre = txtNombre.Texts.Trim(),
                    apellido = txtApellido.Texts.Trim(),
                    dni = int.Parse(txtDni.Texts),
                    direccion = txtDireccion.Texts.Trim(),
                    telefono = txtTelefono.Texts.Trim(),
                };

                _context.Propietario.Add(nuevoPropietario);
                _context.SaveChanges();

                MessageBox.Show("Propietario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navegar<Propietarios>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el propietario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosPropietario()
        {
            try
            {
                var propietario = _context.Propietario.Find(_idPropietario);
                if (propietario != null)
                {
                    txtNombre.Texts = propietario.nombre;
                    txtApellido.Texts = propietario.apellido;
                    txtDni.Texts = propietario.dni.ToString();
                    txtDireccion.Texts = propietario.direccion;
                    txtTelefono.Texts = propietario.telefono.ToString();
                  
                }
                else
                {
                    MessageBox.Show("El propietario no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del propietario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPropietario()
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var propietario = _context.Propietario.Find(_idPropietario);
                if (propietario != null)
                {
                    propietario.nombre = txtNombre.Texts.Trim();
                    propietario.apellido = txtApellido.Texts.Trim();
                    propietario.dni = int.Parse(txtDni.Texts);
                    propietario.direccion = txtDireccion.Texts.Trim();
                    propietario.telefono = txtTelefono.Texts.Trim();

                    _context.SaveChanges();
                    MessageBox.Show("Propietario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Navegar<Propietarios>();
                }
                else
                {
                    MessageBox.Show("El propietario seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el propietario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                Navegar<Propietarios>();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_esEdicion)
                ActualizarPropietario();
            else
                CrearPropietario();
        }
    }
}
