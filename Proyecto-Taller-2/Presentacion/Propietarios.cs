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
        }

        private void Propietarios_Load(object sender, EventArgs e)
        {
            CargarPropietarios();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void CargarPropietarios()
        {
            try
            {
            
                var propietarios = _context.Propietario.ToList();
                dataGridView1.DataSource = propietarios;


                /* if (dataGridView1.Columns["Id"] != null)
                     dataGridView1.Columns["Id"].Visible = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar los propietarios:\n{ex.Message}\n\nDetalles internos:\n{ex.InnerException?.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

            }
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
    }
}