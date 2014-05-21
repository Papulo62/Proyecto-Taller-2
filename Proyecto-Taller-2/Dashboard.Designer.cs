namespace Proyecto_Taller_2
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMascotas = new System.Windows.Forms.Panel();
            this.lblTotalMascotas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCitasHoy = new System.Windows.Forms.Panel();
            this.lblCitasHoy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelProximasCitas = new System.Windows.Forms.Panel();
            this.dataGridViewProximasCitas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.chartTiposMascotas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCitasMensuales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizar = new Proyecto_Taller_2.CustomButton();
            this.panelMascotas.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelCitasHoy.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.panelProximasCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProximasCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiposMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCitasMensuales)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(224, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dashboard";
            // 
            // panelMascotas
            // 
            this.panelMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panelMascotas.Controls.Add(this.lblTotalMascotas);
            this.panelMascotas.Controls.Add(this.label2);
            this.panelMascotas.Location = new System.Drawing.Point(30, 85);
            this.panelMascotas.Name = "panelMascotas";
            this.panelMascotas.Size = new System.Drawing.Size(190, 110);
            this.panelMascotas.TabIndex = 1;
            // 
            // lblTotalMascotas
            // 
            this.lblTotalMascotas.AutoSize = true;
            this.lblTotalMascotas.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMascotas.ForeColor = System.Drawing.Color.White;
            this.lblTotalMascotas.Location = new System.Drawing.Point(15, 45);
            this.lblTotalMascotas.Name = "lblTotalMascotas";
            this.lblTotalMascotas.Size = new System.Drawing.Size(48, 54);
            this.lblTotalMascotas.TabIndex = 1;
            this.lblTotalMascotas.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Mascotas";
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelClientes.Controls.Add(this.lblTotalClientes);
            this.panelClientes.Controls.Add(this.label4);
            this.panelClientes.Location = new System.Drawing.Point(235, 85);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(190, 110);
            this.panelClientes.TabIndex = 2;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.White;
            this.lblTotalClientes.Location = new System.Drawing.Point(15, 45);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(48, 54);
            this.lblTotalClientes.TabIndex = 1;
            this.lblTotalClientes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Clientes";
            // 
            // panelCitasHoy
            // 
            this.panelCitasHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panelCitasHoy.Controls.Add(this.lblCitasHoy);
            this.panelCitasHoy.Controls.Add(this.label6);
            this.panelCitasHoy.Location = new System.Drawing.Point(440, 85);
            this.panelCitasHoy.Name = "panelCitasHoy";
            this.panelCitasHoy.Size = new System.Drawing.Size(190, 110);
            this.panelCitasHoy.TabIndex = 3;
            // 
            // lblCitasHoy
            // 
            this.lblCitasHoy.AutoSize = true;
            this.lblCitasHoy.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasHoy.ForeColor = System.Drawing.Color.White;
            this.lblCitasHoy.Location = new System.Drawing.Point(15, 45);
            this.lblCitasHoy.Name = "lblCitasHoy";
            this.lblCitasHoy.Size = new System.Drawing.Size(48, 54);
            this.lblCitasHoy.TabIndex = 1;
            this.lblCitasHoy.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Citas Hoy";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.panelUsuarios.Controls.Add(this.lblUsuarios);
            this.panelUsuarios.Controls.Add(this.label8);
            this.panelUsuarios.Location = new System.Drawing.Point(645, 85);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(190, 110);
            this.panelUsuarios.TabIndex = 4;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(15, 50);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(39, 43);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Usuarios";
            // 
            // panelProximasCitas
            // 
            this.panelProximasCitas.BackColor = System.Drawing.Color.White;
            this.panelProximasCitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProximasCitas.Controls.Add(this.dataGridViewProximasCitas);
            this.panelProximasCitas.Controls.Add(this.label9);
            this.panelProximasCitas.Location = new System.Drawing.Point(30, 465);
            this.panelProximasCitas.Name = "panelProximasCitas";
            this.panelProximasCitas.Size = new System.Drawing.Size(805, 230);
            this.panelProximasCitas.TabIndex = 5;
            // 
            // dataGridViewProximasCitas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProximasCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProximasCitas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProximasCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProximasCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProximasCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProximasCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProximasCitas.ColumnHeadersHeight = 35;
            this.dataGridViewProximasCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProximasCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProximasCitas.EnableHeadersVisualStyles = false;
            this.dataGridViewProximasCitas.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewProximasCitas.Location = new System.Drawing.Point(15, 50);
            this.dataGridViewProximasCitas.Name = "dataGridViewProximasCitas";
            this.dataGridViewProximasCitas.RowHeadersVisible = false;
            this.dataGridViewProximasCitas.Size = new System.Drawing.Size(775, 165);
            this.dataGridViewProximasCitas.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hora";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mascota";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Propietario";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Motivo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Próximas Citas Hoy";
            // 
            // chartTiposMascotas
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartTiposMascotas.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartTiposMascotas.Legends.Add(legend1);
            this.chartTiposMascotas.Location = new System.Drawing.Point(30, 210);
            this.chartTiposMascotas.Name = "chartTiposMascotas";
            this.chartTiposMascotas.Size = new System.Drawing.Size(395, 240);
            this.chartTiposMascotas.TabIndex = 6;
            this.chartTiposMascotas.Text = "chart1";
            // 
            // chartCitasMensuales
            // 
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartCitasMensuales.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartCitasMensuales.Legends.Add(legend2);
            this.chartCitasMensuales.Location = new System.Drawing.Point(440, 210);
            this.chartCitasMensuales.Name = "chartCitasMensuales";
            this.chartCitasMensuales.Size = new System.Drawing.Size(395, 240);
            this.chartCitasMensuales.TabIndex = 7;
            this.chartCitasMensuales.Text = "chart2";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnActualizar.BorderRadius = 8;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(700, 24);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 40);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.chartCitasMensuales);
            this.Controls.Add(this.chartTiposMascotas);
            this.Controls.Add(this.panelProximasCitas);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panelCitasHoy);
            this.Controls.Add(this.panelClientes);
            this.Controls.Add(this.panelMascotas);
            this.Controls.Add(this.labelTitle);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(872, 720);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMascotas.ResumeLayout(false);
            this.panelMascotas.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.panelCitasHoy.ResumeLayout(false);
            this.panelCitasHoy.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.panelProximasCitas.ResumeLayout(false);
            this.panelProximasCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProximasCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiposMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCitasMensuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMascotas;
        private System.Windows.Forms.Label lblTotalMascotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCitasHoy;
        private System.Windows.Forms.Label lblCitasHoy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelProximasCitas;
        private System.Windows.Forms.DataGridView dataGridViewProximasCitas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiposMascotas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCitasMensuales;
        private CustomButton btnActualizar;
    }
}