using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Taller_2.Models;
using System.Data.Entity;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Consultas : BaseUserControl
    {
        private MiDbContext _context;
        private int _nroPagina = 1;
        private int _cantidadPagina = 5; 
        private int _totalRegistros = 0;

        public Consultas()
        {
            InitializeComponent();
            _context = new MiDbContext();
            AplicarFiltros();
            this.Load += Consultas_Load;

            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            dataGridViewConsultas.CellContentClick += dataGridViewConsultas_CellContentClick;
            btnSiguiente.Click += btnSiguiente_Click;
            btnAnterior.Click += btnAnterior_Click;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            CargarFiltrosIniciales();
            cmbFiltroFecha.SelectedIndexChanged += cmbFiltroFecha_SelectedIndexChanged_1;
            AplicarFiltros();
        }

        private void CargarFiltrosIniciales()
        {
            cmbFiltroFecha.Items.Clear();
            cmbFiltroFecha.Items.Add("Ver Todo");
            cmbFiltroFecha.Items.Add("Hoy");
            cmbFiltroFecha.Items.Add("Esta Semana");
            cmbFiltroFecha.Items.Add("Este Mes");
            cmbFiltroFecha.SelectedIndex = 0; 

            cmbFiltroFecha.DropDownStyle = ComboBoxStyle.DropDownList; 
        }

        private void cmbFiltroFecha_SelectedIndexChanged_1(object sender, EventArgs e)
        {
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

                IQueryable<Consulta> query = _context.Consulta
           .Include(c => c.Mascota) 
           .Include(c => c.Veterinario);

                if (filtroFecha != "Ver Todo")
                {
                    query = query.Where(c => c.fecha_consulta >= inicio && c.fecha_consulta < fin);
                }

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    query = query.Where(c =>
                        (c.Mascota != null && c.Mascota.Nombre.ToLower().Contains(textoBusqueda)) ||
                        (c.Veterinario.Usuario != null && (c.Veterinario.Usuario.nombre + " " + c.Veterinario.Usuario.apellido).ToLower().Contains(textoBusqueda)) ||
                        (c.motivo.ToLower().Contains(textoBusqueda))
                    );
                }

                _totalRegistros = query.Count();

                var consultasPagina = query
                    .OrderBy(c => c.fecha_consulta)
                    .Skip((_nroPagina - 1) * _cantidadPagina)
                    .Take(_cantidadPagina)
                    .Select(c => new
                    {
                        Id = c.Id,
                        Mascota = c.Mascota.Nombre,
                        Veterinario = c.Veterinario.Usuario.nombre + " " + c.Veterinario.Usuario.apellido,
                        Fecha = c.fecha_consulta,
                        Motivo = c.motivo
                    })
                    .ToList();

                dataGridViewConsultas.DataSource = consultasPagina;

                int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
                lblPagina.Text = $"Página {_nroPagina} de {totalPaginas}";
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
            _nroPagina = 1; // Reiniciar a la primera página
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
                _nroPagina = 1; // Reiniciar a la primera página
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
            if (_nroPagina < totalPaginas)
            {
                _nroPagina++;
                AplicarFiltros();
            }
        }


        private void AlternarEstadoConsulta(int idConsulta)
        {
            try
            {
                var consulta = _context.Consulta.Find(idConsulta);
                if (consulta != null)
                {
                    consulta.activo = !consulta.activo;
                    _context.SaveChanges();
                    string mensaje = consulta.activo ? "Consulta activada." : "Consulta desactivada.";
                    MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show("No se encontró la consulta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado de la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    var result = MessageBox.Show("¿Está seguro de que desea desactivar/activar esta consulta?",
                        "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        AlternarEstadoConsulta(idConsulta);
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
