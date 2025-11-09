using Proyecto_Taller_2.Models;
using Proyecto_Taller_2.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class TurnosForm : BaseUserControl
    {
        private MiDbContext _context;
        private int _idTurno;
        private bool _esEdicion = false;


        public TurnosForm()
        {
            InitializeComponent();
            _context = new MiDbContext();
            _esEdicion = false;
            MostrarCombos();
        }

        public TurnosForm(int idTurno) : this()
        {
            _idTurno = idTurno;
            _esEdicion = true;
            CargarDatosTurno();
        }

        private void MostrarCombos()
        {
            comboBoxMascota.DataSource = _context.Mascota
                .Select(m => new { m.IdMascota, m.Nombre })
                .ToList();
            comboBoxMascota.DisplayMember = "Nombre";
            comboBoxMascota.ValueMember = "IdMascota";
            comboBoxMascota.SelectedIndex = -1;

            comboBoxPropietario.DataSource = _context.Propietario
                .Select(p => new { p.Id, NombreCompleto = p.nombre + " " + p.apellido })
                .ToList();
            comboBoxPropietario.DisplayMember = "NombreCompleto";
            comboBoxPropietario.ValueMember = "Id";
            comboBoxPropietario.SelectedIndex = -1;

            comboBoxVeterinario.DataSource = _context.Veterinario
                .Select(v => new
                {
                    v.IdVeterinario,
                    NombreCompleto = v.Usuario.nombre + " " + v.Usuario.apellido
                })
                .ToList();
            comboBoxVeterinario.DisplayMember = "NombreCompleto";
            comboBoxVeterinario.ValueMember = "IdVeterinario";
            comboBoxVeterinario.SelectedIndex = -1;

            comboBoxHora.Items.AddRange(new[]
            {
                "08:00", "09:00", "10:00", "11:00",
                "14:00", "15:00", "16:00", "17:00"
            });

            comboBoxEstado.DataSource = _context.Estado
            .Select(e => new { e.IdEstado, e.Nombre })
            .ToList();
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "IdEstado";
            comboBoxEstado.SelectedIndex = -1;

        }

        private bool ValidarCampos()
        {
            return Validaciones.ValidarTodos(
                () => Validaciones.ValidarRequerido(comboBoxMascota, "Mascota"),
                () => Validaciones.ValidarRequerido(comboBoxPropietario, "Propietario"),
                () => Validaciones.ValidarRequerido(comboBoxVeterinario, "Veterinario"),
                () => Validaciones.ValidarRequerido(comboBoxHora, "Hora"),
                () => Validaciones.ValidarRequerido(txtMotivo, "Motivo"),
                () => Validaciones.ValidarRequerido(comboBoxEstado, "Estado")
            );
        }

        private void CrearTurno()
        {
            try
            {
                if (!ValidarCampos()) return;

                var fecha = dateTimePicker1.Value.Date;
                var hora = TimeSpan.Parse(comboBoxHora.SelectedItem.ToString());
                var fechaCompleta = fecha.Add(hora);

                var nuevoTurno = new Turno
                {
                    fecha_inicio = fechaCompleta,
                    fecha_fin = fechaCompleta.AddMinutes(30), // por ejemplo, 30 min de duración
                    descripcion_turno = txtMotivo.Texts.Trim(),
                    activo = true,
                    id_mascota = (int)comboBoxMascota.SelectedValue,
                    id_usuario = (int)comboBoxVeterinario.SelectedValue,
                    id_estado = (int)comboBoxEstado.SelectedValue

                };

                _context.Turno.Add(nuevoTurno);
                _context.SaveChanges();

                MessageBox.Show("Turno creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navegar<Turnos>();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                Exception inner = ex.InnerException;

                while (inner != null)
                {
                    mensaje += "\n\n➡ " + inner.Message;
                    inner = inner.InnerException;
                }

                MessageBox.Show(
                    "Error al crear turno:\n\n" + mensaje,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                //MessageBox.Show($"Error al crear turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosTurno()
        {
            try
            {
                var turno = _context.Turno.Find(_idTurno);
                if (turno != null)
                {
                    dateTimePicker1.Value = turno.fecha_inicio.Date;

                    comboBoxHora.SelectedItem = comboBoxHora.Items
                        .Cast<string>()
                        .FirstOrDefault(h => h == turno.fecha_inicio.ToString("HH:mm"));

                    comboBoxMascota.SelectedValue = turno.id_mascota;

                    var propietario = _context.Mascota
                        .Where(m => m.IdMascota == turno.id_mascota)
                        .Select(m => m.Propietario.Id)
                        .FirstOrDefault();

                    if (propietario != 0)
                        comboBoxPropietario.SelectedValue = propietario;

                    if (turno.id_usuario != 0)
                        comboBoxVeterinario.SelectedValue = turno.id_usuario;

                    if (turno.id_estado != 0)
                        comboBoxEstado.SelectedValue = turno.id_estado;

                    txtMotivo.Texts = turno.descripcion_turno;
                }
                else
                {
                    MessageBox.Show("El turno seleccionado no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarTurno()
        {
            try
            {
                if (!ValidarCampos()) return;

                var turno = _context.Turno.Find(_idTurno);
                if (turno != null)
                {
                    // Combinar fecha y hora del DateTimePicker y ComboBox
                    DateTime fechaSeleccionada = dateTimePicker1.Value.Date;
                    string horaSeleccionada = comboBoxHora.SelectedItem.ToString();
                    DateTime fechaHoraInicio = DateTime.Parse($"{fechaSeleccionada:yyyy-MM-dd} {horaSeleccionada}");

                    // Cargar los nuevos valores
                    turno.fecha_inicio = fechaHoraInicio;
                    turno.descripcion_turno = txtMotivo.Texts.Trim();
                    turno.id_mascota = (int)comboBoxMascota.SelectedValue;
                    turno.id_usuario = (int)comboBoxVeterinario.SelectedValue; // veterinario asignado
                    turno.id_estado = (int)comboBoxEstado.SelectedValue;

                    _context.SaveChanges();

                    MessageBox.Show("Turno actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Navegar<Turnos>();
                }
                else
                {
                    MessageBox.Show("El turno seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            if (_esEdicion)
                ActualizarTurno();
            else
                CrearTurno();
        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Seguro que desea salir sin guardar los cambios?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                Navegar<Turnos>();
            }
        }
    }
}
