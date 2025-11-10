using Proyecto_Taller_2.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Propietarios : BaseUserControl
    {
        private MiDbContext _context;

        private int _nroPagina = 1;
        private int _cantidadPagina = 5;
        private int _totalRegistros = 0;

        public Propietarios()
        {
            InitializeComponent();
            _context = new MiDbContext();

            cmbOrdenamiento.SelectedIndexChanged += cmbOrdenamiento_SelectedIndexChanged;
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
        }

        private void Propietarios_Load(object sender, EventArgs e)
        {
            CargarPropietarios();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void CargarPropietarios()
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Texts.Trim();
            string ordenamientoSeleccionado = cmbOrdenamiento.SelectedItem?.ToString() ?? "Por Nombre (A-Z)";

            try
            {
                IQueryable<Proyecto_Taller_2.Models.Propietario> query = _context.Propietario.AsQueryable();

                // 🔹 Filtro de búsqueda
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    string busquedaUpper = textoBusqueda.ToUpper();
                    query = query.Where(p =>
                        p.nombre.ToUpper().Contains(busquedaUpper) ||
                        p.apellido.ToUpper().Contains(busquedaUpper) ||
                        p.telefono.ToUpper().Contains(busquedaUpper) ||
                        p.telefono_alternativo.ToUpper().Contains(busquedaUpper) ||
                        p.dni.ToString().Contains(textoBusqueda)
                    );
                }

                // 🔹 Ordenamiento
                switch (ordenamientoSeleccionado)
                {
                    case "Por Nombre (A-Z)":
                        query = query.OrderBy(p => p.nombre);
                        break;
                    case "Por Nombre (Z-A)":
                        query = query.OrderByDescending(p => p.nombre);
                        break;
                    case "Por DNI (Menor a Mayor)":
                        query = query.OrderBy(p => p.dni);
                        break;
                    case "Por DNI (Mayor a Menor)":
                        query = query.OrderByDescending(p => p.dni);
                        break;
                    case "Por Apellido (A-Z)":
                        query = query.OrderBy(p => p.apellido);
                        break;
                }

                _totalRegistros = query.Count();

                var pagina = query
                    .Skip((_nroPagina - 1) * _cantidadPagina)
                    .Take(_cantidadPagina)
                    .Select(p => new
                    {
                        p.Id,
                        NombreCompleto = p.nombre + " " + p.apellido,
                        p.dni,
                        p.direccion,
                        p.telefono,
                        p.telefono_alternativo,
                        Estado = p.Activo ? "Activo" : "Inactivo"
                    })
                    .ToList();

                dataGridView1.DataSource = pagina;

                if (dataGridView1.Columns["Id"] != null)
                    dataGridView1.Columns["Id"].Visible = false;

                int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
                lblPagina.Text = $"Página {_nroPagina} de {totalPaginas}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros de Propietarios: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlternarEstadoPropietario(int idPropietario)
        {
            try
            {
                var propietario = _context.Propietario.Find(idPropietario);
                if (propietario != null)
                {
                    propietario.Activo = !propietario.Activo;
                    _context.SaveChanges();

                    string mensaje = propietario.Activo
                        ? "El propietario ha sido activado nuevamente."
                        : "El propietario ha sido desactivado correctamente.";

                    MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show("No se encontró el propietario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado del propietario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nroPagina = 1;
            AplicarFiltros();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                int idPropietario = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                if (e.ColumnIndex == 0) 
                {
                    Navegar(new PropietariosForm(idPropietario));
                }
                else if (e.ColumnIndex == 1) 
                {
                    var propietario = _context.Propietario.Find(idPropietario);
                    if (propietario == null)
                    {
                        MessageBox.Show("No se encontró el propietario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string accion = propietario.Activo ? "desactivar" : "activar";
                    var result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} este propietario?",
                        "Confirmar acción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        AlternarEstadoPropietario(idPropietario);
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
            Navegar<PropietariosForm>();
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
