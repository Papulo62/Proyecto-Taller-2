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
using Proyecto_Taller_2.Utils;


using Proyecto_Taller_2.Presentacion;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class ConsultasForm : BaseUserControl
    {
        private MiDbContext _context;
        private int _idConsulta;
        private bool _esEdicion = false;
        private string _rutaArchivoSeleccionado = "";

        public ConsultasForm()
        {
            InitializeComponent();
            _context = new MiDbContext();
            _esEdicion = false;
            MostrarCombobox();
        }

        public ConsultasForm(int idConsulta) : this()
        {
            _idConsulta = idConsulta;
            _esEdicion = true;
            CargarDatosConsulta();
        }

        private void MostrarCombobox()
        {
            var mascotas = _context.Mascota.ToList();
            comboBoxMascota.DataSource = mascotas;
            comboBoxMascota.DisplayMember = "Nombre";
            comboBoxMascota.ValueMember = "IdMascota";
            comboBoxMascota.SelectedIndex = -1;

            var veterinarios = _context.Veterinario
      .Join(
          _context.Usuario,
          v => v.id_usuario,  
          u => u.Id,              
          (v, u) => new
          {
              v.IdVeterinario,
              NombreCompleto = u.nombre + " " + u.apellido,
              u.imagen_perfil
          }
      )
      .ToList();

            comboBoxVeterinario.DataSource = veterinarios;
            comboBoxVeterinario.DisplayMember = "NombreCompleto";
            comboBoxVeterinario.ValueMember = "IdVeterinario";
            comboBoxVeterinario.SelectedIndex = -1;

        }

        private void ConsultasForm_Load(object sender, EventArgs e)
        {
            CargarMascotas();
            CargarVeterinarios();
        }

        private void CargarMascotas()
        {
            try
            {
                var mascotas = _context.Mascota.ToList();

                comboBoxMascota.DataSource = mascotas;
                comboBoxMascota.DisplayMember = "Nombre";
                comboBoxMascota.ValueMember = "Id";
                if (!_esEdicion)
                    comboBoxMascota.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las mascotas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVeterinarios()
        {
            try
            {
                var veterinarios = _context.Usuario
                    .Where(u => u.rolId == 2) 
                    .Select(v => new { v.Id, Nombre = v.nombre + " " + v.apellido })
                    .ToList();

                comboBoxVeterinario.DataSource = veterinarios;
                comboBoxVeterinario.DisplayMember = "Nombre";
                comboBoxVeterinario.ValueMember = "Id";
                if (!_esEdicion)
                    comboBoxVeterinario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los veterinarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            return Validaciones.ValidarTodos(
                () => Validaciones.ValidarComboBoxRequerido(comboBoxMascota, "Mascota"),
                () => Validaciones.ValidarComboBoxRequerido(comboBoxVeterinario, "Veterinario"),
                () => Validaciones.ValidarRequerido(txtMotivo, "Motivo"),
                () => Validaciones.ValidarLongitudMinima(txtMotivo, "Motivo", 3),
                () => Validaciones.ValidarRequerido(txtSintomas, "Síntomas"),
                () => Validaciones.ValidarRequerido(txtDiagnostico, "Diagnóstico"),
                () => Validaciones.ValidarFecha(dateTimePickerFecha, "Fecha de consulta", DateTime.Now.AddYears(-10), DateTime.Now.AddDays(1)),
                () => Validaciones.ValidarFecha(dateTimePickerProxControl, "Próximo control", DateTime.Now)
            );
        }

        private void CrearConsulta()
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var nuevaConsulta = new Consulta
                {
                    id_mascota = (int)comboBoxMascota.SelectedValue,
                    id_veterinario = (int)comboBoxVeterinario.SelectedValue,
                    fecha_consulta = dateTimePickerFecha.Value,
                    motivo = txtMotivo.Texts.Trim(),
                    diagnostico = txtDiagnostico.Texts.Trim(),
                    tratamiento = txtTratamiento.Texts.Trim(),
                    sintomas = txtSintomas.Texts.Trim(),
                    proximo_control = dateTimePickerProxControl.Value,
                };

                _context.Consulta.Add(nuevaConsulta);
                _context.SaveChanges();

                MessageBox.Show("Consulta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navegar<Consultas>();
            }
            catch (Exception ex)
            {
                Exception inner = ex;
                string detalles = "";

                while (inner != null)
                {
                    detalles += $"→ {inner.Message}\n";
                    inner = inner.InnerException;
                }

                MessageBox.Show(
                    $"Error al crear la consulta:\n{ex.Message}\n\nDetalles internos:\n{detalles}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void CargarDatosConsulta()
        {
            try
            {
                var consulta = _context.Consulta.Find(_idConsulta);
                if (consulta != null)
                {
                    comboBoxMascota.SelectedValue = consulta.id_mascota;
                    comboBoxVeterinario.SelectedValue = consulta.id_veterinario;
                    dateTimePickerFecha.Value = consulta.fecha_consulta;
                    txtMotivo.Texts = consulta.motivo;
                    txtDiagnostico.Texts = consulta.diagnostico;
                    txtTratamiento.Texts = consulta.tratamiento;
                    txtSintomas.Texts = consulta.sintomas;
                    dateTimePickerProxControl.Value = consulta.proximo_control;
                }
                else
                {
                    MessageBox.Show("La consulta no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarConsulta()
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var consulta = _context.Consulta.Find(_idConsulta);
                if (consulta != null)
                {
                    consulta.id_mascota = (int)comboBoxMascota.SelectedValue;
                    consulta.id_veterinario = (int)comboBoxVeterinario.SelectedValue;
                    consulta.fecha_consulta = dateTimePickerFecha.Value;
                    consulta.motivo = txtMotivo.Texts.Trim();
                    consulta.diagnostico = txtDiagnostico.Texts.Trim();
                    consulta.tratamiento = txtTratamiento.Texts.Trim();
                    consulta.sintomas = txtSintomas.Texts.Trim();
                    consulta.proximo_control = dateTimePickerProxControl.Value;

                    _context.SaveChanges();

                    MessageBox.Show("Consulta actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Navegar<Consultas>();
                }
                else
                {
                    MessageBox.Show("La consulta seleccionada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

    

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Documentos|*.pdf;*.docx;*.jpg;*.png";
                openFileDialog.Title = "Seleccionar archivo adjunto";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoSeleccionado = openFileDialog.FileName;
                    //lblArchivoSeleccionado.Text = System.IO.Path.GetFileName(_rutaArchivoSeleccionado);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "¿Seguro que desea salir sin guardar la consulta?",
              "Confirmar salida",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                Navegar<Consultas>();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_esEdicion)
                ActualizarConsulta();
            else
                CrearConsulta();
        }
    }
}
