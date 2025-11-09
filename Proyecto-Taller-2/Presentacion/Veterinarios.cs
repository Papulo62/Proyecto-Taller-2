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
            CargarVeterinarios();
            this.Load += Veterinarios_Load;
            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            customDataGridView1.CellContentClick += customDataGridView1_CellContentClick;
            customButton1.Click += customButton1_Click;
        }

        private void Veterinarios_Load(object sender, EventArgs e)
        {
            CargarVeterinarios();
            CargarEspecialidadesEnCombo();
            cmbEspecialidad.SelectedIndexChanged += (s, ev) => AplicarFiltros();

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
                            where v.activo == true
                            select new
                            {
                                
                                NombreCompleto = u.nombre + " " + u.apellido,
                                Especialidad = e.nombre_especialidad,
                                v.matricula,
                                v.id_especialidad,
                                v.IdVeterinario,
                               
                            };

                // 3. APLICAR FILTRO POR ESPECIALIDAD
                if (idEspSeleccionada != 0)
                {
                    query = query.Where(x => x.id_especialidad == idEspSeleccionada);
                }

                // 4. APLICAR FILTRO DE BÚSQUEDA POR TEXTO (Nombre/Apellido/Matrícula)
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    query = query.Where(x =>
                        x.NombreCompleto.ToLower().Contains(textoBusqueda) ||
                        x.matricula.ToLower().Contains(textoBusqueda)
                    );
                }

                // 5. ASIGNAR RESULTADOS
                customDataGridView1.DataSource = query.OrderBy(x => x.NombreCompleto).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}");
            }
        }

        // ===============================
        //  BOTÓN BUSCAR
        // ===============================
        private void btnBuscar_Click(object sender, EventArgs e)
        {

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

                AplicarFiltros();
            }
        }

        private void EliminarVeterinario(int idVeterinario)
        {
            try
            {
                var veterinario = _context.Veterinario.Find(idVeterinario);
                if (veterinario != null)
                {
                    veterinario.activo = false;
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
