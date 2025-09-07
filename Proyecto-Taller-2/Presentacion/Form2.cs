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
    public partial class Form2 : Form
    {
        private Usuario usuarioLogueado;

        public Form2(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

     

        private void PersonalizarSidebar()
        {
            try
            {
              
                if (usuarioLogueado.rolId == 1)
                {
                
                    btnPropietarios.Visible = true; 
                    btnUsuarios.Visible = true; 
                    btnVeterinario.Visible = true; 
                    btnTurnos.Visible = true; 
                    btnReportes.Visible = true; 
                    btnMascotas.Visible = true; 
                }
              
                else if (usuarioLogueado.rolId == 2)
                {
                    
                    btnPropietarios.Visible = false; 
                    btnUsuarios.Visible = false;
                    btnVeterinario.Visible = false;  
                    btnTurnos.Visible = true;   
                    btnReportes.Visible = true; 
                    btnMascotas.Visible = true; 
                }
            
                else if (usuarioLogueado.rolId == 3)
                {
                    
                    btnPropietarios.Visible = false; 
                    btnUsuarios.Visible = false; 
                    btnVeterinario.Visible = true;   
                    btnTurnos.Visible = false;  
                    btnReportes.Visible = false; 
                    btnMascotas.Visible = true;   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al personalizar el sidebar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarUserControl(UserControl control)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
          
            PersonalizarSidebar();
        }

       
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Mascotas());
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Propietarios());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            var usuariosControl = new Usuarios();
            CargarUserControl(usuariosControl);
            usuariosControl.CargarNuevoUsuario += () => CargarUserControl(new UsuariosForm());
            usuariosControl.EditarUsuario += (idUsuario) => CargarUserControl(new UsuariosForm(idUsuario));
            
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            CargarUserControl(new Veterinario());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Turnos());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Reportes());
        }
    }
}
