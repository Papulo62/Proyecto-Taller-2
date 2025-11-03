using Proyecto_Taller_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    public partial class Mascotas : UserControl
    {

        private MiDbContext _context;
        private int _idMascota;
        public event Action CargarNuevaMascota;
        public event Action<int> EditarMascota;


        public Mascotas()
        {
            InitializeComponent();
            _context = new MiDbContext();


            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void CargarFiltrosIniciales()
        {
            // Limpiar y cargar cmbFiltroSexo
            cmbFiltroSexo.Items.Clear();
            cmbFiltroSexo.Items.Add("Ver Todo");
            cmbFiltroSexo.Items.Add("Macho");
            cmbFiltroSexo.Items.Add("Hembra");
            cmbFiltroSexo.SelectedIndex = 0; // Selecciona "Ver Todo"

            // Limpiar y cargar cmbFiltroEspecie
            cmbFiltroEspecie.Items.Clear();
            cmbFiltroEspecie.Items.Add("Ver Todo");
            cmbFiltroEspecie.Items.Add("Perro");
            cmbFiltroEspecie.Items.Add("Gato");
            // Agrega aquí todas las demás especies que necesites
            cmbFiltroEspecie.SelectedIndex = 0; // Selecciona "Ver Todo"
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            CargarFiltrosIniciales();
            cmbFiltroSexo.SelectedIndexChanged += Filtro_SelectedIndexChanged;
            cmbFiltroEspecie.SelectedIndexChanged += Filtro_SelectedIndexChanged;

            // Opcional: Asegurar que los ComboBox tengan un valor seleccionado al inicio (e.g., "Ver Todo")
            if (cmbFiltroSexo.Items.Count > 0 && cmbFiltroSexo.SelectedIndex == -1)
            {
                cmbFiltroSexo.SelectedIndex = 0;
            }
            if (cmbFiltroEspecie.Items.Count > 0 && cmbFiltroEspecie.SelectedIndex == -1)
            {
                cmbFiltroEspecie.SelectedIndex = 0;
            }
            AplicarFiltros();


        }

        // ===============================
        //  CARGAR LISTADO DE MASCOTAS
        // ===============================
        private void CargarMascotas()
        {
            try
            {
                var mascotas = _context.Mascota.Where(m => m.Activo).ToList();
                customDataGridView1.DataSource = mascotas;

                // Ocultar columnas que no quieras mostrar
                if (customDataGridView1.Columns["IdMascota"] != null)
                    customDataGridView1.Columns["IdMascota"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message);
            }
        }

        // ===========================================
        // APLICAR FILTROS COMBINADOS (NOMBRE, ESPECIE, SEXO)
        // ===========================================
        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Texts.Trim();

            // OBTENEMOS LOS VALORES LIMPIOS Y ESTANDARIZADOS UNA SOLA VEZ
            string sexoSeleccionadoLimpio = cmbFiltroSexo.SelectedItem?.ToString().Trim().ToUpper();
            string especieSeleccionadaLimpio = cmbFiltroEspecie.SelectedItem?.ToString().Trim().ToUpper();

            try
            {
                IQueryable<Mascota> query = _context.Mascota.Where(m => m.Activo);

                // A. APLICAR FILTRO DE SEXO
                // Usamos la variable ya limpia (sexoSeleccionadoLimpio)
                if (sexoSeleccionadoLimpio != "VER TODO")
                {
                    // ⬇️ USAR VALOR LIMPIO DIRECTAMENTE EN LA COMPARACIÓN ⬇️
                    query = query.Where(m => m.Sexo.Trim().ToUpper() == sexoSeleccionadoLimpio);
                }

                // B. APLICAR FILTRO DE ESPECIE
                // Usamos la variable ya limpia (especieSeleccionadaLimpio)
                if (especieSeleccionadaLimpio != "VER TODO")
                {
                    // Si la base de datos es sensible a mayúsculas, la comparamos con UPPER
                    query = query.Where(m => m.Especie.ToUpper() == especieSeleccionadaLimpio);
                }

                // C. APLICAR BÚSQUEDA DE TEXTO
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    string busquedaUpper = textoBusqueda.ToUpper();
                    query = query.Where(m => m.Nombre.ToUpper().Contains(busquedaUpper) ||
                                             m.Raza.ToUpper().Contains(busquedaUpper));
                }

                // Asignar resultados al DataGridView
                customDataGridView1.DataSource = query.ToList();

                if (customDataGridView1.Columns["IdMascota"] != null)
                    customDataGridView1.Columns["IdMascota"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }

        // ===============================
        //  ELIMINAR (LÓGICO)
        // ===============================
        private void EliminarMascota(int idMascota)
        {
            try
            {

                var mascota = _context.Mascota.Find(idMascota);
                if (mascota != null)
                {

                    mascota.Activo = false;
                    _context.SaveChanges();

                    MessageBox.Show("Mascota eliminada correctamente.");
                    CargarMascotas();
                }
                else
                {
                    MessageBox.Show("La mascota seleccionada no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // ===============================
        //  NUEVA MASCOTA
        // ===============================
        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            CargarNuevaMascota?.Invoke();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form2 formPrincipal = (Form2)this.ParentForm;
            formPrincipal.CargarUserControl(new MascotasForm());
        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int idMascota = (int)customDataGridView1.Rows[e.RowIndex].Cells["IdMascota"].Value;

                if (e.ColumnIndex == 0)
                {
                    EditarMascota?.Invoke(idMascota);
                }
                else if (e.ColumnIndex == 1)
                {
                    var result = MessageBox.Show("¿Está seguro de que desea eliminar esta mascota?",
                        "Confirmar desactivación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        EliminarMascota(idMascota);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
