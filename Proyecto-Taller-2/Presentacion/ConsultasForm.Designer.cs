
namespace Proyecto_Taller_2.Presentacion
{
    partial class ConsultasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivo = new CustomControls.RJControls.RJTextBox();
            this.dateTimePickerProxControl = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMascota = new System.Windows.Forms.ComboBox();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnostico = new CustomControls.RJControls.RJTextBox();
            this.txtTratamiento = new CustomControls.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iblArchivoSeleccionado = new CustomControls.RJControls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSintomas = new CustomControls.RJControls.RJTextBox();
            this.btnClose = new Proyecto_Taller_2.CustomButton();
            this.btnAdd = new Proyecto_Taller_2.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tratamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diagnostico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motivo de la consulta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Veterinario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sintomas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mascota:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.SystemColors.Window;
            this.txtMotivo.BorderColor = System.Drawing.Color.Black;
            this.txtMotivo.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMotivo.BorderRadius = 8;
            this.txtMotivo.BorderSize = 1;
            this.txtMotivo.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMotivo.Location = new System.Drawing.Point(143, 362);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMotivo.PasswordChar = false;
            this.txtMotivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMotivo.PlaceholderText = "Ingrese el motivo de la consulta:";
            this.txtMotivo.Size = new System.Drawing.Size(250, 51);
            this.txtMotivo.TabIndex = 8;
            this.txtMotivo.Texts = "";
            this.txtMotivo.UnderlinedStyle = false;
            // 
            // dateTimePickerProxControl
            // 
            this.dateTimePickerProxControl.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerProxControl.Location = new System.Drawing.Point(501, 403);
            this.dateTimePickerProxControl.Name = "dateTimePickerProxControl";
            this.dateTimePickerProxControl.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerProxControl.TabIndex = 10;
            // 
            // comboBoxMascota
            // 
            this.comboBoxMascota.FormattingEnabled = true;
            this.comboBoxMascota.Location = new System.Drawing.Point(143, 120);
            this.comboBoxMascota.Name = "comboBoxMascota";
            this.comboBoxMascota.Size = new System.Drawing.Size(250, 26);
            this.comboBoxMascota.TabIndex = 11;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(143, 196);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(250, 26);
            this.comboBoxVeterinario.TabIndex = 14;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Location = new System.Drawing.Point(143, 276);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerFecha.TabIndex = 15;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiagnostico.BorderColor = System.Drawing.Color.Black;
            this.txtDiagnostico.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDiagnostico.BorderRadius = 8;
            this.txtDiagnostico.BorderSize = 1;
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnostico.Location = new System.Drawing.Point(501, 213);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiagnostico.PasswordChar = false;
            this.txtDiagnostico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiagnostico.PlaceholderText = "Ingrese el diagnostico:";
            this.txtDiagnostico.Size = new System.Drawing.Size(250, 51);
            this.txtDiagnostico.TabIndex = 16;
            this.txtDiagnostico.Texts = "";
            this.txtDiagnostico.UnderlinedStyle = false;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtTratamiento.BorderColor = System.Drawing.Color.Black;
            this.txtTratamiento.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTratamiento.BorderRadius = 8;
            this.txtTratamiento.BorderSize = 1;
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTratamiento.Location = new System.Drawing.Point(501, 308);
            this.txtTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTratamiento.PasswordChar = false;
            this.txtTratamiento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTratamiento.PlaceholderText = "Ingrese el tratamiento:";
            this.txtTratamiento.Size = new System.Drawing.Size(250, 51);
            this.txtTratamiento.TabIndex = 17;
            this.txtTratamiento.Texts = "";
            this.txtTratamiento.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Proxima consulta:";
            // 
            // iblArchivoSeleccionado
            // 
            this.iblArchivoSeleccionado.BackColor = System.Drawing.SystemColors.Window;
            this.iblArchivoSeleccionado.BorderColor = System.Drawing.Color.Black;
            this.iblArchivoSeleccionado.BorderFocusColor = System.Drawing.Color.Black;
            this.iblArchivoSeleccionado.BorderRadius = 8;
            this.iblArchivoSeleccionado.BorderSize = 1;
            this.iblArchivoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblArchivoSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iblArchivoSeleccionado.Location = new System.Drawing.Point(143, 472);
            this.iblArchivoSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.iblArchivoSeleccionado.Multiline = true;
            this.iblArchivoSeleccionado.Name = "iblArchivoSeleccionado";
            this.iblArchivoSeleccionado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.iblArchivoSeleccionado.PasswordChar = false;
            this.iblArchivoSeleccionado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.iblArchivoSeleccionado.PlaceholderText = "Ingrese el historial clinico:";
            this.iblArchivoSeleccionado.Size = new System.Drawing.Size(250, 30);
            this.iblArchivoSeleccionado.TabIndex = 19;
            this.iblArchivoSeleccionado.Texts = "";
            this.iblArchivoSeleccionado.UnderlinedStyle = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Historial clínico:";
            // 
            // txtSintomas
            // 
            this.txtSintomas.BackColor = System.Drawing.SystemColors.Window;
            this.txtSintomas.BorderColor = System.Drawing.Color.Black;
            this.txtSintomas.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSintomas.BorderRadius = 8;
            this.txtSintomas.BorderSize = 1;
            this.txtSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSintomas.Location = new System.Drawing.Point(501, 120);
            this.txtSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSintomas.PasswordChar = false;
            this.txtSintomas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSintomas.PlaceholderText = "Ingrese los sintomas:";
            this.txtSintomas.Size = new System.Drawing.Size(250, 51);
            this.txtSintomas.TabIndex = 21;
            this.txtSintomas.Texts = "";
            this.txtSintomas.UnderlinedStyle = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnClose.BorderRadius = 8;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(501, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(631, 514);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iblArchivoSeleccionado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.comboBoxMascota);
            this.Controls.Add(this.dateTimePickerProxControl);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultasForm";
            this.Size = new System.Drawing.Size(896, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dateTimePickerProxControl;
        private System.Windows.Forms.ComboBox comboBoxMascota;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private CustomControls.RJControls.RJTextBox txtDiagnostico;
        private CustomControls.RJControls.RJTextBox txtTratamiento;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox iblArchivoSeleccionado;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJControls.RJTextBox txtSintomas;
        private CustomButton btnClose;
        private CustomButton btnAdd;
    }
}
