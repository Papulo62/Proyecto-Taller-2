using Proyecto_Taller_2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Taller_2.Presentacion
{
    public partial class Mascotas : BaseUserControl
    {
        private MiDbContext _context;
        private int _idMascota;

        private int _nroPagina = 1;
        private int _cantidadPagina = 2;
        private int _totalRegistros = 0;

        public event Action CargarNuevaMascota;
        public event Action<int> EditarMascota;

        public Mascotas()
        {
            InitializeComponent();
            _context = new MiDbContext();

            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;

            AplicarFiltros();
        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nroPagina = 1;
            AplicarFiltros();
        }

        private void CargarFiltrosIniciales()
        {
            // Filtro Sexo
            cmbFiltroSexo.Items.Clear();
            cmbFiltroSexo.Items.Add("Ver Todo");
            cmbFiltroSexo.Items.Add("Macho");
            cmbFiltroSexo.Items.Add("Hembra");
            cmbFiltroSexo.SelectedIndex = 0;

            // Filtro Especie
            cmbFiltroEspecie.Items.Clear();
            cmbFiltroEspecie.Items.Add("Ver Todo");
            cmbFiltroEspecie.Items.Add("Perro");
            cmbFiltroEspecie.Items.Add("Gato");
            cmbFiltroEspecie.Items.Add("Ave");
            cmbFiltroEspecie.Items.Add("Reptil");
            cmbFiltroEspecie.Items.Add("Roedor");
            cmbFiltroEspecie.SelectedIndex = 0;
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            CargarFiltrosIniciales();
            cmbFiltroSexo.SelectedIndexChanged += Filtro_SelectedIndexChanged;
            cmbFiltroEspecie.SelectedIndexChanged += Filtro_SelectedIndexChanged;

            if (cmbFiltroSexo.Items.Count > 0 && cmbFiltroSexo.SelectedIndex == -1)
                cmbFiltroSexo.SelectedIndex = 0;

            if (cmbFiltroEspecie.Items.Count > 0 && cmbFiltroEspecie.SelectedIndex == -1)
                cmbFiltroEspecie.SelectedIndex = 0;

            AplicarFiltros();
        }

   
   
        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Texts.Trim();
            string sexoSeleccionadoLimpio = cmbFiltroSexo.SelectedItem?.ToString().Trim().ToUpper();
            string especieSeleccionadaLimpio = cmbFiltroEspecie.SelectedItem?.ToString().Trim().ToUpper();

            try
            {
                var consulta =
                    from m in _context.Mascota
                    join r in _context.Raza on m.id_raza equals r.id_raza
                    join e in _context.Especie on r.id_especie equals e.id_especie
                   
                    select new
                    {
                        IdMascota = m.IdMascota,
                        Nombre = m.Nombre,
                        Sexo = m.Sexo,
                        Raza = r.nombre_raza,
                        Especie = e.nombre_especie,
                        Peso = m.Peso,
                        Activo = m.Activo,
                    };

                // 🔹 Filtros
                if (sexoSeleccionadoLimpio != "VER TODO")
                    consulta = consulta.Where(m => m.Sexo.ToUpper() == sexoSeleccionadoLimpio);

                if (especieSeleccionadaLimpio != "VER TODO")
                    consulta = consulta.Where(m => m.Especie.ToUpper() == especieSeleccionadaLimpio);

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    string busquedaUpper = textoBusqueda.ToUpper();
                    consulta = consulta.Where(m =>
                        m.Nombre.ToUpper().Contains(busquedaUpper) ||
                        m.Raza.ToUpper().Contains(busquedaUpper) ||
                        m.Especie.ToUpper().Contains(busquedaUpper));
                }

                _totalRegistros = consulta.Count();

                var pagina = consulta
                    .OrderBy(m => m.IdMascota)
                    .Skip((_nroPagina - 1) * _cantidadPagina)
                    .Take(_cantidadPagina)
                    .ToList();

                customDataGridView1.DataSource = pagina;

                if (customDataGridView1.Columns["IdMascota"] != null)
                    customDataGridView1.Columns["IdMascota"].Visible = false;

                int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
                lblPagina.Text = $"Página {_nroPagina} de {totalPaginas}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }

     

        private void AlternarEstadoMascota(int idMascota)
        {
            try
            {
                var mascota = _context.Mascota.Find(idMascota);
                if (mascota != null)
                {
                    mascota.Activo = !mascota.Activo;

                    _context.SaveChanges();

                    string mensaje = mascota.Activo
                        ? "La mascota ha sido activada nuevamente."
                        : "La mascota ha sido desactivada correctamente.";

                    MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show("No se encontró la mascota seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado de la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        

        // ===============================
        //  BOTÓN BUSCAR
        // ===============================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _nroPagina = 1;
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
                _nroPagina = 1;
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
                    Navegar(new MascotasForm(idMascota));
                }
                else if (e.ColumnIndex == 1)
                {
                    var mascota = _context.Mascota.Find(idMascota);
                    if (mascota == null)
                    {
                        MessageBox.Show("No se encontró la mascota seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string accion = mascota.Activo ? "desactivar" : "activar";
                    var result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} esta mascota?",
                        "Confirmar acción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        AlternarEstadoMascota(idMascota);
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    Navegar(new HistorialClinico(idMascota));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            Navegar<MascotasForm>();
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
