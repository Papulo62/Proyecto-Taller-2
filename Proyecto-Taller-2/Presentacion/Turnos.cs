using Proyecto_Taller_2.Models;
using Proyecto_Taller_2.Presentacion;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    public partial class Turnos : BaseUserControl
    {
        private MiDbContext _context;

        public Turnos()
        {
            InitializeComponent();
            _context = new MiDbContext();
            this.Load += Turnos_Load;
            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            CargarFiltrosIniciales();
            customDataGridView1.CellContentClick += dataGridViewTurnos_CellContentClick;
            btnAgregarTurno.Click += btnAgregarTurno_Click;

        }

        private void CargarFiltrosIniciales()
        {
            cmbFiltroFecha.Items.Clear();
            cmbFiltroFecha.Items.Add("Ver Todo");
            cmbFiltroFecha.Items.Add("Hoy");
            cmbFiltroFecha.Items.Add("Esta Semana");
            cmbFiltroFecha.Items.Add("Este Mes");
            cmbFiltroFecha.SelectedIndex = 0; // “Ver Todo”

            cmbFiltroFecha.DropDownStyle = ComboBoxStyle.DropDownList; // que no se pueda escribir
            cmbFiltroFecha.SelectedIndexChanged += cmbFiltroFecha_SelectedIndexChanged_1;
        }

        private void cmbFiltroFecha_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            CargarFiltrosIniciales();
            cmbFiltroFecha.SelectedIndexChanged += cmbFiltroFecha_SelectedIndexChanged_1;
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            try
            {
                string filtroFecha = cmbFiltroFecha.SelectedItem?.ToString();
                string textoBusqueda = (txtBuscar.Texts ?? "").Trim().ToLower(); // <-- usar Texts

                DateTime hoy = DateTime.Today;
                DateTime inicio = DateTime.MinValue;
                DateTime fin = DateTime.MaxValue;

                if (filtroFecha == "Hoy")
                {
                    inicio = hoy;
                    fin = hoy.AddDays(1);
                }
                else if (filtroFecha == "Esta Semana")
                {
                    int diff = (7 + (int)hoy.DayOfWeek - (int)DayOfWeek.Monday) % 7;
                    inicio = hoy.AddDays(-diff);
                    fin = inicio.AddDays(7);
                }
                else if (filtroFecha == "Este Mes")
                {
                    inicio = new DateTime(hoy.Year, hoy.Month, 1);
                    fin = inicio.AddMonths(1);
                }

                // Incluir relaciones para que las propiedades de navegación estén disponibles
                var query = _context.Turno
                    .Include("Mascota")
                    .Include("Usuario")
                    .Include("Estado")
                    .Where(t => t.activo);

                if (filtroFecha != "Ver Todo")
                {
                    query = query.Where(t => t.fecha_inicio >= inicio && t.fecha_inicio < fin);
                }

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    // IMPORTANT: usamos ToLower() en el servidor — EF lo traduce
                    query = query.Where(t =>
                        t.Mascota.Nombre.ToLower().Contains(textoBusqueda) ||
                        t.Usuario.nombre.ToLower().Contains(textoBusqueda) ||
                        t.Usuario.apellido.ToLower().Contains(textoBusqueda) ||
                        t.descripcion_turno.ToLower().Contains(textoBusqueda) ||
                        t.Estado.Nombre.ToLower().Contains(textoBusqueda)
                    );
                }

                var lista = query
                    .Select(t => new
                    {
                        Mascota = t.Mascota.Nombre,
                        Veterinario = t.Usuario.nombre + " " + t.Usuario.apellido,
                        Fecha = t.fecha_inicio,
                        Motivo = t.descripcion_turno,
                        Estado = t.Estado.Nombre,
                        t.id_turno
                    })
                    .OrderBy(t => t.Fecha)
                    .ToList();

                customDataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }


        // ===============================
        //  BOTÓN BUSCAR
        // ===============================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Llama al método de filtrado combinado
            AplicarFiltros();
        }

        // ===============================
        //  BUSCAR CON ENTER
        // ===============================
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Llama al método de filtrado combinado
                AplicarFiltros();
            }
        }

        private void CargarTurnos()
        {
            try
            {
                var turnosBD = _context.Turno
                    .Where(t => t.activo == true)
                    .Select(t => new
                    {
                        t.id_turno,
                        t.fecha_inicio,
                        t.fecha_fin,
                        t.descripcion_turno,
                        MascotaNombre = t.Mascota.Nombre,
                        PropietarioNombre = t.Mascota.Propietario.nombre,
                        PropietarioApellido = t.Mascota.Propietario.apellido,
                        VeterinarioNombre = t.Usuario.nombre,
                        VeterinarioApellido = t.Usuario.apellido
                    })
                    .ToList(); // acá ejecuta en SQL

                // Ahora sí, se puede usar ToString() y concatenaciones
                var turnos = turnosBD.Select(t => new
                {
                    t.id_turno,
                    Fecha = t.fecha_inicio.ToString("dd/MM/yyyy HH:mm"),
                    Mascota = t.MascotaNombre,
                    Propietario = $"{t.PropietarioNombre} {t.PropietarioApellido}",
                    Veterinario = $"{t.VeterinarioNombre} {t.VeterinarioApellido}",
                    Motivo = t.descripcion_turno
                }).ToList();

                customDataGridView1.DataSource = turnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EliminarTurno(int idTurno)
        {
            try
            {
                var turno = _context.Turno.Find(idTurno);
                if (turno != null)
                {
                    var confirm = MessageBox.Show(
                        "¿Está seguro de que desea eliminar este turno?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        turno.activo = false;
                        _context.SaveChanges();
                        MessageBox.Show("Turno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTurnos();
                    }
                }
                else
                {
                    MessageBox.Show("El turno seleccionado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            Navegar<TurnosForm>();
        }

        private void dataGridViewTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                int idTurno = Convert.ToInt32(customDataGridView1.Rows[e.RowIndex].Cells["id_turno"].Value);

                if (e.ColumnIndex == 0)
                {
                    Navegar(new TurnosForm(idTurno));
                }
                else if (e.ColumnIndex == 1)
                {
                    EliminarTurno(idTurno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
