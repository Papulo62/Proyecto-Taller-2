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

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Consultas : BaseUserControl
    {
        private MiDbContext _context;

        public Consultas()
        {
            InitializeComponent();
            _context = new MiDbContext();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            CargarConsultas();
            dataGridViewConsultas.CellContentClick += dataGridViewConsultas_CellContentClick;
        }

        private void CargarConsultas()
        {
            try
            {
                var lista = _context.Consulta.ToList();
                dataGridViewConsultas.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las consultas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarConsulta(int idConsulta)
        {
            try
            {
                var consulta = _context.Consulta.Find(idConsulta);
                if (consulta != null)
                {
                    _context.Consulta.Remove(consulta);
                    _context.SaveChanges();
                    MessageBox.Show("Consulta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarConsultas();
                }
                else
                {
                    MessageBox.Show("La consulta seleccionada no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Navegar<ConsultasForm>();
        }

        private void dataGridViewConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                if (e.RowIndex < 0) return;

                int idConsulta = (int)dataGridViewConsultas.Rows[e.RowIndex].Cells["Id"].Value;

               
                if (e.ColumnIndex == 0)
                {
                    Navegar(new ConsultasForm(idConsulta));
                }
        
                else if (e.ColumnIndex == 1)
                {
                    var result = MessageBox.Show(
                        "¿Está seguro de que desea eliminar esta consulta?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        EliminarConsulta(idConsulta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultasAdd_Click(object sender, EventArgs e)
        {
            Navegar<ConsultasForm>();
        }
    }
}