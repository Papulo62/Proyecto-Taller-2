namespace Proyecto_Taller_2.Presentacion
{
    partial class HistorialClinico
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
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProximoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.lblProximoControlValor = new System.Windows.Forms.Label();
            this.lblProximoControl = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetallesTitulo = new System.Windows.Forms.Label();
            this.btnExportar = new Proyecto_Taller_2.CustomButton();
            this.btnCerrar = new Proyecto_Taller_2.CustomButton();
            this.panelTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.panelDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.ForeColor = System.Drawing.Color.Black;
            this.lblNombreMascota.Location = new System.Drawing.Point(20, 15);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(469, 45);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "🐶 Historial Clínico - Firulais";
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.White;
            this.panelTabs.Controls.Add(this.btnTurnos);
            this.panelTabs.Controls.Add(this.btnConsultas);
            this.panelTabs.Location = new System.Drawing.Point(28, 80);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(300, 45);
            this.panelTabs.TabIndex = 1;
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.LightGray;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.Location = new System.Drawing.Point(150, 0);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(150, 45);
            this.btnTurnos.TabIndex = 1;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = false;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(0, 0);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(150, 45);
            this.btnConsultas.TabIndex = 0;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // dataGridViewHistorial
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHistorial.ColumnHeadersHeight = 35;
            this.dataGridViewHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFecha,
            this.colMotivo,
            this.colVeterinario,
            this.colDiagnostico,
            this.colTratamiento,
            this.colSintomas,
            this.colProximoControl});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHistorial.EnableHeadersVisualStyles = false;
            this.dataGridViewHistorial.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(28, 140);
            this.dataGridViewHistorial.MultiSelect = false;
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.ReadOnly = true;
            this.dataGridViewHistorial.RowHeadersVisible = false;
            this.dataGridViewHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(815, 250);
            this.dataGridViewHistorial.TabIndex = 2;
            this.dataGridViewHistorial.SelectionChanged += new System.EventHandler(this.dataGridViewHistorial_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 120;
            // 
            // colMotivo
            // 
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;
            this.colMotivo.Width = 200;
            // 
            // colVeterinario
            // 
            this.colVeterinario.HeaderText = "Veterinario";
            this.colVeterinario.Name = "colVeterinario";
            this.colVeterinario.ReadOnly = true;
            this.colVeterinario.Width = 150;
            // 
            // colDiagnostico
            // 
            this.colDiagnostico.HeaderText = "Diagnóstico";
            this.colDiagnostico.Name = "colDiagnostico";
            this.colDiagnostico.ReadOnly = true;
            this.colDiagnostico.Visible = false;
            this.colDiagnostico.Width = 200;
            // 
            // colTratamiento
            // 
            this.colTratamiento.HeaderText = "Tratamiento";
            this.colTratamiento.Name = "colTratamiento";
            this.colTratamiento.ReadOnly = true;
            this.colTratamiento.Visible = false;
            this.colTratamiento.Width = 200;
            // 
            // colSintomas
            // 
            this.colSintomas.HeaderText = "Síntomas";
            this.colSintomas.Name = "colSintomas";
            this.colSintomas.ReadOnly = true;
            this.colSintomas.Visible = false;
            this.colSintomas.Width = 150;
            // 
            // colProximoControl
            // 
            this.colProximoControl.HeaderText = "Próximo Control";
            this.colProximoControl.Name = "colProximoControl";
            this.colProximoControl.ReadOnly = true;
            this.colProximoControl.Visible = false;
            this.colProximoControl.Width = 120;
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.White;
            this.panelDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalles.Controls.Add(this.lblProximoControlValor);
            this.panelDetalles.Controls.Add(this.lblProximoControl);
            this.panelDetalles.Controls.Add(this.txtObservaciones);
            this.panelDetalles.Controls.Add(this.label4);
            this.panelDetalles.Controls.Add(this.txtTratamiento);
            this.panelDetalles.Controls.Add(this.label3);
            this.panelDetalles.Controls.Add(this.txtDiagnostico);
            this.panelDetalles.Controls.Add(this.label2);
            this.panelDetalles.Controls.Add(this.lblDetallesTitulo);
            this.panelDetalles.Location = new System.Drawing.Point(28, 410);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(815, 280);
            this.panelDetalles.TabIndex = 3;
            // 
            // lblProximoControlValor
            // 
            this.lblProximoControlValor.AutoSize = true;
            this.lblProximoControlValor.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoControlValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblProximoControlValor.Location = new System.Drawing.Point(185, 240);
            this.lblProximoControlValor.Name = "lblProximoControlValor";
            this.lblProximoControlValor.Size = new System.Drawing.Size(92, 21);
            this.lblProximoControlValor.TabIndex = 8;
            this.lblProximoControlValor.Text = "01/11/2025";
            // 
            // lblProximoControl
            // 
            this.lblProximoControl.AutoSize = true;
            this.lblProximoControl.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoControl.Location = new System.Drawing.Point(20, 240);
            this.lblProximoControl.Name = "lblProximoControl";
            this.lblProximoControl.Size = new System.Drawing.Size(134, 21);
            this.lblProximoControl.TabIndex = 7;
            this.lblProximoControl.Text = "Próximo Control:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(420, 100);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(370, 120);
            this.txtObservaciones.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observaciones:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.BackColor = System.Drawing.Color.White;
            this.txtTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTratamiento.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(24, 170);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.ReadOnly = true;
            this.txtTratamiento.Size = new System.Drawing.Size(370, 50);
            this.txtTratamiento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tratamiento:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.Color.White;
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(24, 100);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ReadOnly = true;
            this.txtDiagnostico.Size = new System.Drawing.Size(370, 30);
            this.txtDiagnostico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnóstico:";
            // 
            // lblDetallesTitulo
            // 
            this.lblDetallesTitulo.AutoSize = true;
            this.lblDetallesTitulo.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblDetallesTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblDetallesTitulo.Name = "lblDetallesTitulo";
            this.lblDetallesTitulo.Size = new System.Drawing.Size(241, 27);
            this.lblDetallesTitulo.TabIndex = 0;
            this.lblDetallesTitulo.Text = "Detalles de la Consulta";
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
            this.btnExportar.Location = new System.Drawing.Point(710, 85);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(133, 40);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar PDF";
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Silver;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCerrar.BorderRadius = 8;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(543, 85);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.Black;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // HistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.dataGridViewHistorial);
            this.Controls.Add(this.panelTabs);
            this.Controls.Add(this.lblNombreMascota);
            this.Name = "HistorialClinico";
            this.Size = new System.Drawing.Size(872, 720);
            this.Load += new System.EventHandler(this.HistorialClinico_Load);
            this.panelTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblDetallesTitulo;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProximoControl;
        private System.Windows.Forms.Label lblProximoControlValor;
        private CustomButton btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximoControl;
        private CustomButton btnCerrar;
    }
}