namespace Proyecto_Taller_2
{
    partial class Turnos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarTurno = new Proyecto_Taller_2.CustomButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltroFecha = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new CustomControls.RJControls.RJTextBox();
            this.customDataGridView1 = new Proyecto_Taller_2.CustomDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnAnterior = new Proyecto_Taller_2.CustomButton();
            this.btnSiguiente = new Proyecto_Taller_2.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarTurno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarTurno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarTurno.BorderRadius = 8;
            this.btnAgregarTurno.BorderSize = 0;
            this.btnAgregarTurno.FlatAppearance.BorderSize = 0;
            this.btnAgregarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTurno.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTurno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTurno.Location = new System.Drawing.Point(627, 171);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarTurno.TabIndex = 8;
            this.btnAgregarTurno.Text = "Agregar Turno";
            this.btnAgregarTurno.TextColor = System.Drawing.Color.White;
            this.btnAgregarTurno.UseVisualStyleBackColor = false;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(353, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(151, 53);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Turnos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(362, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 30);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filtrar Por Fecha:";
            // 
            // cmbFiltroFecha
            // 
            this.cmbFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroFecha.FormattingEnabled = true;
            this.cmbFiltroFecha.Location = new System.Drawing.Point(527, 111);
            this.cmbFiltroFecha.Name = "cmbFiltroFecha";
            this.cmbFiltroFecha.Size = new System.Drawing.Size(250, 28);
            this.cmbFiltroFecha.TabIndex = 10;
            this.cmbFiltroFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroFecha_SelectedIndexChanged_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.BorderColor = System.Drawing.Color.Black;
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBuscar.BorderRadius = 8;
            this.txtBuscar.BorderSize = 1;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.Location = new System.Drawing.Point(105, 111);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(250, 30);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.Texts = "";
            this.txtBuscar.UnderlinedStyle = false;
            // 
            // customDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.customDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.customDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.customDataGridView1.EnableHeadersVisualStyles = false;
            this.customDataGridView1.Location = new System.Drawing.Point(105, 313);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.customDataGridView1.RowHeadersWidth = 51;
            this.customDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customDataGridView1.Size = new System.Drawing.Size(642, 150);
            this.customDataGridView1.TabIndex = 15;
            // 
            // Editar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 125;
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(393, 466);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(62, 18);
            this.lblPagina.TabIndex = 22;
            this.lblPagina.Text = "Correo:";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAnterior.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAnterior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAnterior.BorderRadius = 8;
            this.btnAnterior.BorderSize = 0;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(116, 455);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(150, 40);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextColor = System.Drawing.Color.White;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSiguiente.BorderRadius = 8;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(635, 455);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(150, 40);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.customDataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFiltroFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.labelTitle);
            this.Name = "Turnos";
            this.Size = new System.Drawing.Size(872, 520);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnAgregarTurno;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltroFecha;
        private CustomControls.RJControls.RJTextBox txtBuscar;
        private CustomDataGridView customDataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label lblPagina;
        private CustomButton btnAnterior;
        private CustomButton btnSiguiente;
    }
}
