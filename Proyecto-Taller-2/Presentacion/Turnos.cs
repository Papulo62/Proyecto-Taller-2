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
        private int _nroPagina = 1;
        private int _cantidadPagina = 5; 
        private int _totalRegistros = 0;

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
            btnSiguiente.Click += btnSiguiente_Click;
            btnAnterior.Click += btnAnterior_Click;
        }

        private void CargarFiltrosIniciales()
        {
            cmbFiltroFecha.Items.Clear();
            cmbFiltroFecha.Items.Add("Ver Todo");
            cmbFiltroFecha.Items.Add("Hoy");
            cmbFiltroFecha.Items.Add("Esta Semana");
            cmbFiltroFecha.Items.Add("Este Mes");
            cmbFiltroFecha.SelectedIndex = 0; // "Ver Todo"

            cmbFiltroFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroFecha.SelectedIndexChanged += cmbFiltroFecha_SelectedIndexChanged_1;
        }

        private void cmbFiltroFecha_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            CargarFiltrosIniciales();
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            try
            {
                string filtroFecha = cmbFiltroFecha.SelectedItem?.ToString();
                string textoBusqueda = (txtBuscar.Texts ?? "").Trim().ToLower();

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

                var query = _context.Turno
                .Include("Mascota")
                .Include("Usuario")
                .Include("Estado")
                .AsQueryable(); 

                if (filtroFecha != "Ver Todo")
                {
                    query = query.Where(t => t.fecha_inicio >= inicio && t.fecha_inicio < fin);
                }

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    query = query.Where(t =>
                        t.Mascota.Nombre.ToLower().Contains(textoBusqueda) ||
                        t.Usuario.nombre.ToLower().Contains(textoBusqueda) ||
                        t.Usuario.apellido.ToLower().Contains(textoBusqueda) ||
                        t.descripcion_turno.ToLower().Contains(textoBusqueda) ||
                        t.Estado.Nombre.ToLower().Contains(textoBusqueda)
                    );
                }

                // Paginación
                _totalRegistros = query.Count();

                var turnosPagina = query
                    .OrderBy(t => t.fecha_inicio)
                    .Skip((_nroPagina - 1) * _cantidadPagina)
                    .Take(_cantidadPagina)
                    .Select(t => new
                    {
                        Mascota = t.Mascota.Nombre,
                        Veterinario = t.Usuario.nombre + " " + t.Usuario.apellido,
                        Fecha = t.fecha_inicio,
                        Motivo = t.descripcion_turno,
                        Estado = t.Estado.Nombre,
                        t.id_turno,
                        t.activo
                    })
                    .ToList();

                customDataGridView1.DataSource = turnosPagina;

                // Actualizar información de paginación
                int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
                lblPagina.Text = $"Página {_nroPagina} de {totalPaginas}";
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
            _nroPagina = 1; // Reiniciar a la primera página
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
                _nroPagina = 1; // Reiniciar a la primera página
                AplicarFiltros();
            }
        }

        // ===============================
        //  BOTÓN ANTERIOR
        // ===============================
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_nroPagina > 1)
            {
                _nroPagina--;
                AplicarFiltros();
            }
        }

        // ===============================
        //  BOTÓN SIGUIENTE
        // ===============================
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
            if (_nroPagina < totalPaginas)
            {
                _nroPagina++;
                AplicarFiltros();
            }
        }

        // ===============================
        //  ALTERNAR ESTADO DE TURNO
        // ===============================
        private void AlternarEstadoTurno(int idTurno)
        {
            try
            {
                var turno = _context.Turno.Find(idTurno);
                if (turno != null)
                {
                    turno.activo = !turno.activo;
                    _context.SaveChanges();
                    string mensaje = turno.activo ? "Turno activado." : "Turno desactivado.";
                    MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show("No se encontró el turno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado del turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        //  CÉLULAS DEL DATA GRID (editar o alternar estado)
        // ===============================
        private void dataGridViewTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                int idTurno = Convert.ToInt32(customDataGridView1.Rows[e.RowIndex].Cells["id_turno"].Value);

                if (e.ColumnIndex == 0) // Editar turno
                {
                    Navegar(new TurnosForm(idTurno));
                }
                else if (e.ColumnIndex == 1) // Alternar estado
                {
                    var result = MessageBox.Show("¿Está seguro de que desea desactivar/activar este turno?",
                        "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        AlternarEstadoTurno(idTurno);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        //  AGREGAR TURNO
        // ===============================
        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            Navegar<TurnosForm>();
        }
    }
}
