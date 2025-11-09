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
using System.Data.Entity;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Consultas : BaseUserControl
    {
        private MiDbContext _context;

        public Consultas()
        {
            InitializeComponent();
            _context = new MiDbContext();
            CargarConsultas();
            this.Load += Consultas_Load;
            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            dataGridViewConsultas.CellContentClick += dataGridViewConsultas_CellContentClick;
        }

        private void CargarFiltrosIniciales()
        {
            cmbFiltroFecha.Items.Clear();
            cmbFiltroFecha.Items.Add("Ver Todo");
            cmbFiltroFecha.Items.Add("Hoy");
            cmbFiltroFecha.Items.Add("Esta Semana");
            cmbFiltroFecha.Items.Add("Este Mes");
            cmbFiltroFecha.SelectedIndex = 0; // “Ver Todo”

            cmbFiltroFecha.DropDownStyle = ComboBoxStyle.DropDownList; // que no se pueda escribir
            cmbFiltroFecha.SelectedIndexChanged += cmbFiltroFecha_SelectedIndexChanged_1;
        }

        private void cmbFiltroFecha_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AplicarFiltros();
        }


        private void Consultas_Load(object sender, EventArgs e)
        {
            CargarFiltrosIniciales();
            cmbFiltroFecha.SelectedIndexChanged += cmbFiltroFecha_SelectedIndexChanged_1;
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

                // Incluir relaciones para que las propiedades de navegación estén disponibles
                 var query = _context.Consulta
                    .Include("Mascota")
                    .Include("Veterinario")
                    .Include("Estado")
                    .Where(c => c.activo);

                if (filtroFecha != "Ver Todo")
                {
                    query = query.Where(c => c.fecha_consulta >= inicio && c.fecha_consulta < fin);
                }

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    query = query.Where(c =>
                        // Búsqueda en Mascota
                        (c.Mascota != null && c.Mascota.Nombre.ToLower().Contains(textoBusqueda)) ||
                        // Búsqueda en Veterinario (doble navegación)
                        (c.Veterinario.Usuario != null && (c.Veterinario.Usuario.nombre + " " + c.Veterinario.Usuario.apellido).ToLower().Contains(textoBusqueda)) ||
                        // Búsqueda en Motivo
                        (c.motivo.ToLower().Contains(textoBusqueda))
                    );
                }

                var lista = query
                    .Select(c => new
                    {
                        Id = c.Id,
                        Mascota = c.Mascota.Nombre,
                        Veterinario = c.Veterinario.Usuario.nombre + " " + c.Veterinario.Usuario.apellido,
                        Fecha = c.fecha_consulta,
                        Motivo = c.motivo,
                        
                    })
                    .OrderBy(c => c.Fecha)
                    .ToList();

                dataGridViewConsultas.DataSource = lista;
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

        private void CargarConsultas()
        {
            try
            {
                var lista = _context.Consulta.ToList();
                MessageBox.Show(lista.Count.ToString());
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