using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_2
{
    [ToolboxItem(true)] 
    [DesignTimeVisible(true)] 
    class CustomDataGridView : DataGridView
    {

        public CustomDataGridView()
        {
            SetDefaultStyles();
        }

        private void SetDefaultStyles()
        {
        
       
            this.AllowUserToAddRows = true;
            this.AllowUserToDeleteRows = true;
           
        
            this.ReadOnly = false;
            this.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            this.MultiSelect = true;
            this.RowHeadersVisible = true;
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;


            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.DefaultCellStyle.Font = new Font("Inter", 10F, FontStyle.Bold);

            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Inter", 10F, FontStyle.Bold);
            this.EnableHeadersVisualStyles = false;

            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightGray;
            this.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.AlternatingRowsDefaultCellStyle.Font = new Font("Inter", 10F, FontStyle.Bold);

            this.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.RowHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            this.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            this.RowHeadersDefaultCellStyle.Font = new Font("Inter", 10F, FontStyle.Bold);
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            this.RowHeadersVisible = true;
            this.ScrollBars = ScrollBars.Vertical;
        }
    }
}

    





 
 



 