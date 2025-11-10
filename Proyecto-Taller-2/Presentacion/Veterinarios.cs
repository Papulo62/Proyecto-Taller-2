using Proyecto_Taller_2.Models;
using Proyecto_Taller_2.Presentacion;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    public partial class Veterinarios : BaseUserControl
    {
        private MiDbContext _context;

        private int _nroPagina = 1;
        private int _cantidadPagina = 5;
        private int _totalRegistros = 0;

        public Veterinarios()
        {
            InitializeComponent();
            _context = new MiDbContext();

            this.Load += Veterinarios_Load;
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            customDataGridView1.CellContentClick += customDataGridView1_CellContentClick;
            customButton1.Click += customButton1_Click;
        }

        private void Veterinarios_Load(object sender, EventArgs e)
        {
            CargarEspecialidadesEnCombo();
            cmbEspecialidad.SelectedIndexChanged += (s, ev) =>
            {
                _nroPagina = 1;
                AplicarFiltros();
            };
            CargarVeterinarios();
        }

        private void CargarEspecialidadesEnCombo()
        {
            var especialidades = _context.Especialidad
                .Select(e => new { id_especialidad = e.id_especialidad, nombre_especialidad = e.nombre_especialidad })
                .ToList();

            especialidades.Insert(0, new { id_especialidad = 0, nombre_especialidad = "Ver Todo" });

            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "nombre_especialidad";
            cmbEspecialidad.ValueMember = "id_especialidad";
        }

        private void CargarVeterinarios()
        {
            AplicarFiltros();
        }


        private void AplicarFiltros()
        {
            int idEspSeleccionada = (cmbEspecialidad.SelectedValue as int?) ?? 0;
            string textoBusqueda = (txtBuscar.Texts ?? "").Trim().ToLower();

            try
            {
                var query = from v in _context.Veterinario
                            join u in _context.Usuario on v.id_usuario equals u.Id
                            join e in _context.Especialidad on v.id_especialidad equals e.id_especialidad
                            select new
                            {
                                v.IdVeterinario,
                                NombreCompleto = u.nombre + " " + u.apellido,
                                e.nombre_especialidad,
                                v.matricula,
                                v.id_especialidad,
                                v.activo
                            };

                // 🔹 Filtrar por especialidad
                if (idEspSeleccionada != 0)
                    query = query.Where(x => x.id_especialidad == idEspSeleccionada);

                // 🔹 Filtrar por texto
                if (!string.IsNullOrEmpty(textoBusqueda))
                    query = query.Where(x =>
                        x.NombreCompleto.ToLower().Contains(textoBusqueda) ||
                        x.matricula.ToLower().Contains(textoBusqueda));

                _totalRegistros = query.Count();

                var pagina = query
                    .OrderBy(x => x.NombreCompleto)
                    .Skip((_nroPagina - 1) * _cantidadPagina)
                    .Take(_cantidadPagina)
                    .Select(x => new
                    {
                        x.IdVeterinario,
                        x.NombreCompleto,
                        Especialidad = x.nombre_especialidad,
                        x.matricula,
                        Estado = x.activo ? "Activo" : "Inactivo"
                    })
                    .ToList();

                customDataGridView1.DataSource = pagina;

                if (customDataGridView1.Columns["IdVeterinario"] != null)
                    customDataGridView1.Columns["IdVeterinario"].Visible = false;

                int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
                lblPagina.Text = $"Página {_nroPagina} de {totalPaginas}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}");
            }
        }

       
        private void AlternarEstadoVeterinario(int idVeterinario)
        {
            try
            {
                var veterinario = _context.Veterinario.Find(idVeterinario);
                if (veterinario != null)
                {
                    veterinario.activo = !veterinario.activo;
                    _context.SaveChanges();

                    string mensaje = veterinario.activo
                        ? "El veterinario ha sido activado nuevamente."
                        : "El veterinario ha sido desactivado correctamente.";

                    MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show("No se encontró el veterinario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado del veterinario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _nroPagina = 1;
            AplicarFiltros();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _nroPagina = 1;
                AplicarFiltros();
            }
        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                int idVeterinario = Convert.ToInt32(customDataGridView1.Rows[e.RowIndex].Cells["IdVeterinario"].Value);

                if (e.ColumnIndex == 0)
                {
                    Navegar(new VeterinariosForm(idVeterinario));
                }
                else if (e.ColumnIndex == 1)
                {
                    var veterinario = _context.Veterinario.Find(idVeterinario);
                    if (veterinario == null)
                    {
                        MessageBox.Show("No se encontró el veterinario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string accion = veterinario.activo ? "desactivar" : "activar";
                    var result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} este veterinario?",
                        "Confirmar acción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        AlternarEstadoVeterinario(idVeterinario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Navegar<VeterinariosForm>();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
            if (_nroPagina < totalPaginas)
            {
                _nroPagina++;
                AplicarFiltros();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_nroPagina > 1)
            {
                _nroPagina--;
                AplicarFiltros();
            }
        }
    }
}
