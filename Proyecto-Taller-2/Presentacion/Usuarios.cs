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
    public partial class Usuarios : BaseUserControl
    {
        private MiDbContext _context;
        private int _idUsuario;
     

        public Usuarios()
        {
            InitializeComponent();
            _context = new MiDbContext();

            // Eventos
            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            cmbRol.SelectedIndexChanged += Filtro_SelectedIndexChanged;
            cmbCreación.SelectedIndexChanged += Filtro_SelectedIndexChanged;
        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este método se llama cuando el Rol o el Orden de Fecha cambian.
            AplicarFiltros();
        }

        public Usuarios(int idUsuario)
        {
            InitializeComponent();
            _context = new MiDbContext();
            _idUsuario = idUsuario;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            customDataGridView1.CellContentClick += customDataGridView1_CellContentClick;
        }

        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _context.Usuario.Where(u => u.activo == true).ToList();

               
                customDataGridView1.DataSource = usuarios;

                customDataGridView1.Columns["Id"].Visible = false;
                if (customDataGridView1.Columns["imagen_perfil"] != null)
                    customDataGridView1.Columns["imagen_perfil"].Visible = false;

                if (customDataGridView1.Columns["contraseña"] != null)
                    customDataGridView1.Columns["contraseña"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void EliminarUsuario(int idUsuario)
        {
            try
            {
                var usuario = _context.Usuario.Find(idUsuario);
                if (usuario != null)
                {
                    usuario.activo = false;
                    _context.SaveChanges();
                    MessageBox.Show("Usuario desactivado correctamente.");
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("El usuario seleccionado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desactivar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            Navegar<UsuariosForm>();
        }

        // ===========================================
        // APLICAR FILTROS COMBINADOS (NOMBRE, ROL, Creación)
        // ===========================================
        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Texts.Trim();

            // 1. OBTENER VALORES LIMPIOS Y ESTANDARIZADOS
            // Asumo que cmbRol y cmbOrdenFecha existen en el diseñador
            string rolSeleccionadoLimpio = cmbRol.SelectedItem?.ToString().Trim().ToUpper();
            string ordenFecha = cmbCreación.SelectedItem?.ToString();

            try
            {
                IQueryable<Usuario> query = _context.Usuario.Where(u => u.activo == true);

                // A. APLICAR FILTRO DE ROL
                if (rolSeleccionadoLimpio != "VER TODO")
                {
                    // Asumo que puedes filtrar por el nombre del rol (RolName) si tienes la navegación.
                    // Si solo tienes el ID del rol (rolId), esto es un ejemplo que DEBE SER AJUSTADO
                    // para acceder al nombre del rol a través de la relación de navegación.
                    query = query.Where(u => u.Rol.nombre.ToUpper() == rolSeleccionadoLimpio); // 👈 AJUSTE DE RELACIÓN
                }

                // B. APLICAR BÚSQUEDA DE TEXTO (Nombre, Apellido, Correo)
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    string busquedaUpper = textoBusqueda.ToUpper();

                    // 🟢 CORRECCIÓN: Usar nombres exactos del modelo (nombre, apellido, correo)
                    query = query.Where(u => u.nombre.ToUpper().Contains(busquedaUpper) ||
                                             u.apellido.ToUpper().Contains(busquedaUpper) ||
                                             u.correo.ToUpper().Contains(busquedaUpper));
                }

                // C. APLICAR ORDENACIÓN POR FECHA DE CREACIÓN
                // 🟢 CORRECCIÓN: Usar el nombre exacto del modelo (fecha_creacion)
                if (ordenFecha == "Ordenar de mas nuevo")
                {
                    query = query.OrderByDescending(u => u.fecha_creacion);
                }
                else if (ordenFecha == "Ordenar de mas antiguo")
                {
                    query = query.OrderBy(u => u.fecha_creacion);
                }

                // 3. Asignar resultados al DataGridView (Proyectar solo lo necesario)
                var listaUsuarios = query.Select(u => new
                {
                    u.Id,
                    NombreCompleto = u.nombre + " " + u.apellido, // Combinamos Nombre y Apellido
                    u.correo,
                    // 🚨 Requerirá la relación de navegación: RolName = u.Rol.Nombre,
                    u.fecha_creacion,
                    u.activo,
                    u.contraseña // Dejamos la contraseña para ocultarla después
                }).ToList();

                customDataGridView1.DataSource = listaUsuarios;

                // 4. Ocultar columnas de seguridad
                if (customDataGridView1.Columns["contraseña"] != null)
                    customDataGridView1.Columns["contraseña"].Visible = false;

                // Asumo que ya ocultaste 'imagen_perfil' en CargarUsuarios o en otro lugar
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

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
        

                int idUsuario = (int)customDataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                if (e.ColumnIndex == 0)
                {
                    Navegar(new UsuariosForm(idUsuario));
                }
                else if (e.ColumnIndex == 1)
                {
                    var result = MessageBox.Show("¿Está seguro de que desea desactivar este usuario?",
                        "Confirmar desactivación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        EliminarUsuario(idUsuario);
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