namespace Proyecto_Taller_2.Presentacion
{
    partial class Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnExportar = new Proyecto_Taller_2.CustomButton();
            this.btnGenerarReporte = new Proyecto_Taller_2.CustomButton();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Reportes";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.btnExportar);
            this.panelFiltros.Controls.Add(this.btnGenerarReporte);
            this.panelFiltros.Controls.Add(this.dateTimePickerFin);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Controls.Add(this.dateTimePickerInicio);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.comboBoxTipoReporte);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Location = new System.Drawing.Point(30, 85);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(815, 120);
            this.panelFiltros.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExportar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExportar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExportar.BorderRadius = 8;
            this.btnExportar.BorderSize = 0;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(650, 65);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(140, 40);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerarReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerarReporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerarReporte.BorderRadius = 8;
            this.btnGenerarReporte.BorderSize = 0;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(490, 65);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(140, 40);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar";
            this.btnGenerarReporte.TextColor = System.Drawing.Color.White;
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(295, 75);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(165, 36);
            this.dateTimePickerFin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Fin:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(25, 75);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(165, 36);
            this.dateTimePickerInicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Inicio:";
            // 
            // comboBoxTipoReporte
            // 
            this.comboBoxTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoReporte.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoReporte.FormattingEnabled = true;
            this.comboBoxTipoReporte.Location = new System.Drawing.Point(165, 15);
            this.comboBoxTipoReporte.Name = "comboBoxTipoReporte";
            this.comboBoxTipoReporte.Size = new System.Drawing.Size(435, 26);
            this.comboBoxTipoReporte.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Reporte:";
            // 
            // dataGridViewReporte
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReporte.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReporte.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReporte.EnableHeadersVisualStyles = false;
            this.dataGridViewReporte.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewReporte.Location = new System.Drawing.Point(30, 240);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.ReadOnly = true;
            this.dataGridViewReporte.RowHeadersVisible = false;
            this.dataGridViewReporte.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReporte.Size = new System.Drawing.Size(815, 450);
            this.dataGridViewReporte.TabIndex = 2;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(30, 215);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(177, 22);
            this.lblTotalRegistros.TabIndex = 3;
            this.lblTotalRegistros.Text = "Total de Registros: 0";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.labelTitle);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(872, 720);
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox comboBoxTipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label3;
        private CustomButton btnGenerarReporte;
        private CustomButton btnExportar;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}