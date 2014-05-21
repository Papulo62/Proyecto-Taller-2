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
    public partial class Veterinario : UserControl
    {
        private MiDbContext _context;
        public event Action<int> EditarVeterinario;
        public event Action CargarNuevoVeterinario;

        public Veterinario()
        {
            InitializeComponent();
            _context = new MiDbContext();
            rjTextBox1.KeyDown += rjTextBox1_KeyDown; // Manejar Enter en el campo de búsqueda
            iconButton1.Click += iconButton1_Click;   // Manejar clic en botón Buscar
            customButton1.Click += customButton1_Click; // Manejar clic en botón Agregar
            customDataGridView1.CellContentClick += customDataGridView1_CellContentClick;
        }

        private void CargarVeterinarios()
        {
            try
            {
                var veterinarios = _context.Veterinario.Where(v => v.Activo).ToList();
                customDataGridView1.DataSource = veterinarios;
   


                // Ocultar columnas que no quieras mostrar
                if (customDataGridView1.Columns["IdVeterinario"] != null)
                    customDataGridView1.Columns["IdVeterinario"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los veterinarios: " + ex.Message);
            }
        }

        private void Veterinario_Load(object sender, EventArgs e)
        {
            CargarVeterinarios();
        }

        private void EliminarVeterinario(int idVeterinario)
        {
            try
            {

                var veterinario = _context.Veterinario.Find(idVeterinario);
                if (veterinario != null)
                {

                    veterinario.Activo = false;
                    _context.SaveChanges();

                    MessageBox.Show("Veterinario eliminado correctamente.");
                    CargarVeterinarios();
                }
                else
                {
                    MessageBox.Show("El veterinario seleccionado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el veterinario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarVeterinarios(string texto)
        {
            try
            {
                var veterinario = _context.Veterinario
                    .Where(v => v.Activo == true &&
                                (v.Nombre.Contains(texto) || string.IsNullOrEmpty(texto)))
                    .ToList();

                customDataGridView1.DataSource = veterinario;

                if (customDataGridView1.Columns["Imagen"] != null)
                    customDataGridView1.Columns["Imagen"].Visible = false;

                if (customDataGridView1.Columns["contraseña"] != null)
                    customDataGridView1.Columns["contraseña"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los veterinarios: " + ex.Message);
            }
        }

        // ===============================
        //  BOTÓN BUSCAR
        // ===============================
        private void iconButton1_Click(object sender, EventArgs e)
        {
            // 🟢 Este método se dispara al hacer clic en el botón 'Buscar' (iconButton1)
            string textoBusqueda = rjTextBox1.Texts.Trim();
            BuscarVeterinarios(textoBusqueda);
        }

        // ===============================
        //  BUSCAR CON ENTER
        // ===============================

        private void rjTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el "beep"

                // 🟢 Usamos el nombre REAL del control
                string textoBusqueda = rjTextBox1.Texts.Trim();
                BuscarVeterinarios(textoBusqueda); // Llama a tu método de búsqueda
            }
        }

        // ===============================
        //  NUEVA VETERINARIO
        // ===============================
        private void btnNuevoVeterinario_Click(object sender, EventArgs e)
        {
            CargarNuevoVeterinario?.Invoke();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            Form2 formPrincipal = (Form2)this.ParentForm;
            formPrincipal.CargarUserControl(new VeterinariosForm());

        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
