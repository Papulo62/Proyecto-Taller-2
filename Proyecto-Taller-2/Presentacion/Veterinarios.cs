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

        public Veterinarios()
        {
            InitializeComponent();
            _context = new MiDbContext();

            this.Load += Veterinarios_Load;

            customDataGridView1.CellContentClick += customDataGridView1_CellContentClick;
            customButton1.Click += customButton1_Click;
        }

        private void Veterinarios_Load(object sender, EventArgs e)
        {
            CargarVeterinarios();
        }

        private void CargarVeterinarios()
        {
            try
            {
                var veterinarios = _context.Veterinario
                    .Where(v => v.activo == true)
                    .ToList();

                customDataGridView1.DataSource = veterinarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar los veterinarios:\n{ex.Message}\n\nDetalles internos:\n{ex.InnerException?.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void EliminarVeterinario(int idVeterinario)
        {
            try
            {
                var veterinario = _context.Veterinario.Find(idVeterinario);
                if (veterinario != null)
                {
                    var confirm = MessageBox.Show(
                        "¿Está seguro de que desea eliminar este veterinario?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        _context.Veterinario.Remove(veterinario);
                        _context.SaveChanges();
                        MessageBox.Show("Veterinario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarVeterinarios();
                    }
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

        private void customButton1_Click(object sender, EventArgs e)
        {
            Navegar<VeterinariosForm>();
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
                    EliminarVeterinario(idVeterinario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
