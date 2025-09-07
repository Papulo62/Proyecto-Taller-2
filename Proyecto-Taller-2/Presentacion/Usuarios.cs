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
    public partial class Usuarios : UserControl
    {
        private MiDbContext _context;
        private int _idUsuario;
        public event Action CargarNuevoUsuario;
        public event Action<int> EditarUsuario;

        public Usuarios()
        {
            InitializeComponent();
            _context = new MiDbContext();
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
                var result = MessageBox.Show("¿Está seguro de que desea desactivar este usuario?",
                    "Confirmar desactivación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                    return;

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
            CargarNuevoUsuario?.Invoke();
        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                int idUsuario = (int)customDataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                if (e.ColumnIndex == 0)
                {
                    EditarUsuario?.Invoke(idUsuario);
                }
                else if (e.ColumnIndex == 1)
                {
                    EliminarUsuario(idUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}