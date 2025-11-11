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
using Proyecto_Taller_2.Presentacion;
using System.Globalization;

namespace Proyecto_Taller_2
{
    public partial class MascotasForm : BaseUserControl
    {
        private MiDbContext _context;
        private bool _esEdicion = false;
        private int _idMascota;
        private string _rutaImagenSeleccionada = "";
        public MascotasForm()
        {
            InitializeComponent();
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtPeso.KeyPress += txtPeso_KeyPress;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            _context = new MiDbContext();
            cmbVivo.SelectedIndex = 0;
            _esEdicion = false;
            mostrarCombobox();
        }

        public MascotasForm(int idUsuario) : this()
        {
            _idMascota = idUsuario;
            _esEdicion = true;
            CargarDatosMascota();
        }

        private void mostrarCombobox()
        {
            var razas = _context.Raza.ToList();
            MessageBox.Show($"Se encontraron {razas.Count} razas");
            cmbRaza.DataSource = razas;
            cmbRaza.DisplayMember = "nombre_raza"; 
            cmbRaza.ValueMember = "id_raza";
            cmbRaza.SelectedIndex = -1;

            var propietarios = _context.Propietario
        .Select(p => new
        {
            p.Id,
            NombreCompleto = p.nombre + " " + p.apellido
        })
        .ToList();

            cmbPropietario.DataSource = propietarios;
            cmbPropietario.DisplayMember = "NombreCompleto";
            cmbPropietario.ValueMember = "Id";  
            cmbPropietario.SelectedIndex = -1;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox != null)
            {
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void CargarDatosMascota()
        {
            try
            {
                var mascota = _context.Mascota.Find(_idMascota);
                if (mascota != null)
                {
                    txtNombre.Texts = mascota.Nombre;
                    cmbRaza.SelectedValue = mascota.id_raza;
                    int indexSexo = cmbSexo.FindStringExact(mascota.Sexo);
                    if (indexSexo != -1)
                    {
                        cmbSexo.SelectedIndex = indexSexo; 
                    }
                    int indexEstado = cmbEstadoReproductivo.FindStringExact(mascota.EstadoReproductivo);
                    if (indexEstado != -1)
                    {
                        cmbEstadoReproductivo.SelectedIndex = indexEstado; 
                    }
                    txtPeso.Texts = mascota.Peso.ToString(CultureInfo.InvariantCulture);
                    cmbPropietario.SelectedValue = mascota.id_propietario;
                    dptNacimiento.Value = mascota.FechaNacimiento;
                    cmbVivo.SelectedValue = mascota.Activo ? "Sí" : "No";   

                    if (!string.IsNullOrEmpty(mascota.foto))
                    {
                        _rutaImagenSeleccionada = mascota.foto;
                        try
                        {
                            if (System.IO.File.Exists(mascota.foto))
                            {
                                picFoto.Image = Image.FromFile(mascota.foto);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La mascota no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_esEdicion)
                ActualizarMascota();
            else
                CrearMascota();


        }

        private void CrearMascota()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Texts))
            {
                MessageBox.Show("Debe ingresar el nombre de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Texts, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRaza.Text))
            {
                MessageBox.Show("Debe ingresar o seleccionar una raza.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRaza.Focus();
                return;
            }

            if (cmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el sexo de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSexo.Focus();
                return;
            }

            if (cmbEstadoReproductivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el estado reproductivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstadoReproductivo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Texts))
            {
                MessageBox.Show("Debe ingresar el peso de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }
            if (!decimal.TryParse(txtPeso.Texts, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("El peso debe ser un número válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            if (dptNacimiento.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dptNacimiento.Focus();
                return;
            }

            if (cmbVivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar si la mascota está viva.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVivo.Focus();
                return;
            }

            try
            {
                using (var context = new MiDbContext())
                {

                    Mascota nuevaMascota = new Mascota
                    {
                        Nombre = txtNombre.Texts.Trim(),
                        id_raza = (int)cmbRaza.SelectedValue,
                        Sexo = cmbSexo.SelectedItem.ToString(),
                        EstadoReproductivo = cmbEstadoReproductivo.SelectedItem.ToString(),
                        Peso = decimal.Parse(txtPeso.Texts),
                        FechaNacimiento = dptNacimiento.Value.Date,
                        id_propietario = (int)cmbPropietario.SelectedValue,
                        Activo = true
                    };

                    _context.Mascota.Add(nuevaMascota);
                    _context.SaveChanges();
                }

                MessageBox.Show("Mascota registrada correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navegar al CRUD de mascotas
                Form2 formPrincipal = (Form2)this.ParentForm;

                // Eliminamos el control actual (para evitar que siga activo)
                formPrincipal.Controls.Remove(this);

                // Cargar el CRUD de mascotas
                formPrincipal.CargarUserControl(new Mascotas());


            }
            catch (Exception ex)
            {
                string mensajeCompleto = $"Error al guardar la mascota: {ex.Message}";
                Exception inner = ex.InnerException;
                while (inner != null)
                {
                    mensajeCompleto += $"\n→ {inner.Message}";
                    inner = inner.InnerException;
                }

                MessageBox.Show(mensajeCompleto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMascota()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Texts))
                {
                    MessageBox.Show("Debe ingresar el nombre de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Texts, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (cmbRaza.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una raza.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbRaza.Focus();
                    return;
                }

                if (cmbSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el sexo de la mascota.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSexo.Focus();
                    return;
                }

                if (cmbEstadoReproductivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el estado reproductivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbEstadoReproductivo.Focus();
                    return;
                }

                if (!decimal.TryParse(txtPeso.Texts, out decimal peso) || peso <= 0)
                {
                    MessageBox.Show("El peso debe ser un número válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPeso.Focus();
                    return;
                }

                if (dptNacimiento.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dptNacimiento.Focus();
                    return;
                }

                if (cmbVivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe indicar si la mascota está viva.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbVivo.Focus();
                    return;
                }

                var mascota = _context.Mascota.Find(_idMascota);
                if (mascota != null)
                {
                    mascota.Nombre = txtNombre.Texts.Trim();
                    mascota.id_raza = (int)cmbRaza.SelectedValue;
                    mascota.Sexo = cmbSexo.SelectedItem.ToString();
                    mascota.EstadoReproductivo = cmbEstadoReproductivo.SelectedItem.ToString();
                    decimal.Parse(txtPeso.Texts.Trim());
                    mascota.FechaNacimiento = dptNacimiento.Value.Date;
                    mascota.id_propietario = (int)cmbPropietario.SelectedValue;
                    mascota.Activo = cmbVivo.SelectedItem.ToString() == "Sí";
                    mascota.foto = _rutaImagenSeleccionada;

                    _context.SaveChanges();

                    MessageBox.Show("Mascota actualizada correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Navegar<Mascotas>();
                }
                else
                {
                    MessageBox.Show("La mascota seleccionada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string mensajeCompleto = $"Error al actualizar la mascota: {ex.Message}";
                Exception inner = ex.InnerException;
                while (inner != null)
                {
                    mensajeCompleto += $"\n→ {inner.Message}";
                    inner = inner.InnerException;
                }

                MessageBox.Show(mensajeCompleto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void customButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "¿Seguro que desea salir sin guardar la mascota?",
              "Confirmar salida",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                Form2 formPrincipal = (Form2)this.ParentForm;

                formPrincipal.CargarUserControl(new Mascotas());
            }
        }


        private void MascotasForm_Load(object sender, EventArgs e)
        {
            cmbVivo.SelectedIndex = 0;
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Seleccionar imagen de perfil";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _rutaImagenSeleccionada = openFileDialog.FileName;

                        picFoto.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void customButton3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "¿Seguro que desea salir sin guardar la mascota?",
             "Confirmar salida",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

            if (result == DialogResult.Yes)
            {
                Form2 formPrincipal = (Form2)this.ParentForm;

                formPrincipal.CargarUserControl(new Mascotas());
            }
        }
    }
}