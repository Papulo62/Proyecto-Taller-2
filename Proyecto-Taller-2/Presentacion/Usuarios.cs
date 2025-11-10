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
    public partial class Usuarios : BaseUserControl
    {
        private MiDbContext _context;
        private int _idUsuario;
        private int _nroPagina = 1;
        private int _cantidadPagina = 5;
        private int _totalRegistros = 0;



        public Usuarios()
        {
            InitializeComponent();
            _context = new MiDbContext();

            txtBuscar.Controls[0].KeyDown += txtBuscar_KeyDown;
            btnBuscar.Click += btnBuscar_Click;
            cmbRol.SelectedIndexChanged += Filtro_SelectedIndexChanged;
            cmbCreación.SelectedIndexChanged += Filtro_SelectedIndexChanged;
        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void CargarUsuarios()

        {
            AplicarFiltros();
            try
            {
                var usuarios = _context.Usuario.ToList();


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

       

       


        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Texts.Trim();
            string rolSeleccionadoLimpio = cmbRol.SelectedItem?.ToString().Trim().ToUpper();
            string ordenFecha = cmbCreación.SelectedItem?.ToString();

            try
            {
                var query = from u in _context.Usuario
                            join r in _context.Rol on u.rolId equals r.Id
                            where u.activo == true
                            select new
                            {
                                u.Id,
                                u.nombre,
                                u.apellido,
                                u.correo,
                                u.fecha_creacion,
                                RolNombre = r.nombre,
                                u.activo
                            };

                
                if (!string.IsNullOrEmpty(rolSeleccionadoLimpio) && rolSeleccionadoLimpio != "VER TODO")
                {
                    query = query.Where(u => u.RolNombre.ToUpper() == rolSeleccionadoLimpio);
                }

            
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    string busquedaUpper = textoBusqueda.ToUpper();
                    query = query.Where(u => u.nombre.ToUpper().Contains(busquedaUpper) ||
                                             u.apellido.ToUpper().Contains(busquedaUpper) ||
                                             u.correo.ToUpper().Contains(busquedaUpper));
                }

                
                if (ordenFecha == "Ordenar de más nuevo")
                {
                    query = query.OrderByDescending(u => u.fecha_creacion);
                }
                else if (ordenFecha == "Ordenar de más antiguo")
                {
                    query = query.OrderBy(u => u.fecha_creacion);
                }

                var listaUsuarios = query.ToList(); 

                _totalRegistros = listaUsuarios.Count();

                var usuariosPagina = listaUsuarios
                    .Skip((_nroPagina - 1) * _cantidadPagina) 
                    .Take(_cantidadPagina)  
                    .ToList();

                customDataGridView1.DataSource = usuariosPagina;

                customDataGridView1.Columns["Id"].Visible = false;
                
                if (customDataGridView1.Columns.Contains("imagen_perfil"))
                {
                    customDataGridView1.Columns["imagen_perfil"].Visible = false;
                }
                if (customDataGridView1.Columns.Contains("contraseña"))
                {
                    customDataGridView1.Columns["contraseña"].Visible = false;
                }

                int totalPaginas = (int)Math.Ceiling((double)_totalRegistros / _cantidadPagina);
                lblPagina.Text = $"Página {_nroPagina} de {totalPaginas}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }


        private void AlternarEstadoUsuario(int idUsuario)
        {
            try
            {
                var usuario = _context.Usuario.Find(idUsuario);
                if (usuario != null)
                {
                    usuario.activo = !usuario.activo; 

                    _context.SaveChanges();

                    string mensaje = usuario.activo
                        ? "El usuario ha sido activado nuevamente."
                        : "El usuario ha sido desactivado correctamente.";

                    MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (e.RowIndex < 0) return;

                int idUsuario = (int)customDataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                if (e.ColumnIndex == 0)  
                {
                    Navegar(new UsuariosForm(idUsuario));
                }
                else if (e.ColumnIndex == 1)  
                {
                    var result = MessageBox.Show("¿Está seguro de que desea desactivar/activar este usuario?",
                        "Confirmar acción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        AlternarEstadoUsuario(idUsuario); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_nroPagina < _totalRegistros)
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

        private void btnUserAdd_Click_1(object sender, EventArgs e)
        {
            Navegar<UsuariosForm>();
        }
    }
    }