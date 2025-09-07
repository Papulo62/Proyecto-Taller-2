namespace Proyecto_Taller_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoReporte = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCerrarReporte = new Proyecto_Taller_2.CustomButton();
            this.generarReporte = new Proyecto_Taller_2.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportes Veterinaria";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(508, 138);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 0;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(230, 138);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipo de reporte:";
            // 
            // comboBoxTipoReporte
            // 
            this.comboBoxTipoReporte.FormattingEnabled = true;
            this.comboBoxTipoReporte.Items.AddRange(new object[] {
            "Turnos por fecha",
            "Mascotas por especie",
            "Vacunas aplicadas",
            "Consultas por veterinario"});
            this.comboBoxTipoReporte.Location = new System.Drawing.Point(288, 204);
            this.comboBoxTipoReporte.Name = "comboBoxTipoReporte";
            this.comboBoxTipoReporte.Size = new System.Drawing.Size(142, 21);
            this.comboBoxTipoReporte.TabIndex = 26;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGreen;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(436, 176);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 223);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnCerrarReporte
            // 
            this.btnCerrarReporte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrarReporte.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrarReporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCerrarReporte.BorderRadius = 8;
            this.btnCerrarReporte.BorderSize = 0;
            this.btnCerrarReporte.FlatAppearance.BorderSize = 0;
            this.btnCerrarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarReporte.ForeColor = System.Drawing.Color.White;
            this.btnCerrarReporte.Location = new System.Drawing.Point(316, 418);
            this.btnCerrarReporte.Name = "btnCerrarReporte";
            this.btnCerrarReporte.Size = new System.Drawing.Size(114, 36);
            this.btnCerrarReporte.TabIndex = 30;
            this.btnCerrarReporte.Text = "Cerrar";
            this.btnCerrarReporte.TextColor = System.Drawing.Color.White;
            this.btnCerrarReporte.UseVisualStyleBackColor = false;
            // 
            // generarReporte
            // 
            this.generarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.generarReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.generarReporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.generarReporte.BorderRadius = 8;
            this.generarReporte.BorderSize = 0;
            this.generarReporte.FlatAppearance.BorderSize = 0;
            this.generarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarReporte.ForeColor = System.Drawing.Color.White;
            this.generarReporte.Location = new System.Drawing.Point(508, 418);
            this.generarReporte.Name = "generarReporte";
            this.generarReporte.Size = new System.Drawing.Size(114, 36);
            this.generarReporte.TabIndex = 27;
            this.generarReporte.Text = "Generar Reporte";
            this.generarReporte.TextColor = System.Drawing.Color.White;
            this.generarReporte.UseVisualStyleBackColor = false;
            this.generarReporte.Click += new System.EventHandler(this.generarReporte_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCerrarReporte);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.generarReporte);
            this.Controls.Add(this.comboBoxTipoReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label1);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(885, 516);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoReporte;
        private CustomButton generarReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CustomButton btnCerrarReporte;
    }
}
