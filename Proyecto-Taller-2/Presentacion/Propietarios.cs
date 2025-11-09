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

namespace Proyecto_Taller_2
{
    public partial class Propietarios : BaseUserControl
    {
        private MiDbContext _context;

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
        
        // 🟢 MÉTODO MANEJADOR DEL COMBOBOX
        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llama al método que aplica la búsqueda y el nuevo orden.
            AplicarFiltros();
        }

        private void EliminarPropietario(int idPropietario)
        {
            try
            {
                var propietario = _context.Propietario.Find(idPropietario);
                if (propietario != null)
                {
                    _context.Propietario.Remove(propietario);
                    _context.SaveChanges();
                    MessageBox.Show("Propietario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPropietarios();
                }
                else
                {
                    MessageBox.Show("El propietario seleccionado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el propietario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Navegar<PropietariosForm>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int idPropietario = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                if (e.ColumnIndex == 0)
                {
                    Navegar(new PropietariosForm(idPropietario));
                }
               
                else if (e.ColumnIndex == 1)
                {
                    var result = MessageBox.Show(
                        "¿Está seguro de que desea eliminar este propietario?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        EliminarPropietario(idPropietario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🟢 2. MÉTODO PARA APLICAR FILTROS DE BÚSQUEDA
        private void AplicarFiltros()
        {
            // Obtener el texto de búsqueda y limpiarlo
            string textoBusqueda = txtBuscar.Texts.Trim();
            string ordenamientoSeleccionado = cmbOrdenamiento.SelectedItem?.ToString() ?? "Por Nombre (A-Z)";

            try
            {
                // 1. Iniciar la consulta (Solo activos, si tienes la columna 'Activo', sino, elimínalo)
                // Usaremos AsQueryable() para construir la consulta paso a paso
                IQueryable<Proyecto_Taller_2.Models.Propietario> query = _context.Propietario.AsQueryable();

                // --- INICIO: FILTRO DE BÚSQUEDA DE TEXTO ---
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    string busquedaUpper = textoBusqueda.ToUpper();

                    // Asumiendo que las propiedades son: nombre, apellido, dni (int), telefono, telefono_alternativo
                    query = query.Where(p =>
                        p.nombre.ToUpper().Contains(busquedaUpper) ||
                        p.apellido.ToUpper().Contains(busquedaUpper) ||
                        p.telefono.ToUpper().Contains(busquedaUpper) ||
                        p.telefono_alternativo.ToUpper().Contains(busquedaUpper) ||
                        p.dni.ToString().Contains(textoBusqueda) // Convierte DNI a string para búsqueda parcial
                    );
                }
                // --- FIN: FILTRO DE BÚSQUEDA DE TEXTO ---


                // 2. APLICAR EL ORDENAMIENTO (switch)
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
                        // No se necesita un 'default' si no quieres un orden específico cuando no hay coincidencia.
                }

                // 3. 🟢 CORRECCIÓN CRÍTICA: PROYECCIÓN Y ASIGNACIÓN
                // Ejecutamos la consulta y la proyectamos para mostrar solo las columnas deseadas.
                var listaPropietarios = query.Select(p => new
                {
                    p.Id,
                    NombreCompleto = p.nombre + " " + p.apellido,
                    p.dni,
                    p.direccion,
                    p.telefono,
                    p.telefono_alternativo
                }).ToList(); // Ejecuta la consulta y trae los datos a memoria

                dataGridView1.DataSource = listaPropietarios; // ✅ Asigna la lista de objetos

                // 4. Ocultar la columna Id
                if (dataGridView1.Columns["Id"] != null)
                    dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros de Propietarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================
        //  BOTÓN BUSCAR
        // ===============================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // ===============================
        //  BUSCAR CON ENTER
        // ===============================
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AplicarFiltros();
            }
        }
    }
}