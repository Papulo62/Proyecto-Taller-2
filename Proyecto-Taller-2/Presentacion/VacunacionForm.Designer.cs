
namespace Proyecto_Taller_2
{
    partial class VacunacionForm
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
            this.txtObservaciones = new CustomControls.RJControls.RJTextBox();
            this.comboBoxMascota = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.txtLote = new CustomControls.RJControls.RJTextBox();
            this.txtLaboratorio = new CustomControls.RJControls.RJTextBox();
            this.comboBoxVacuna = new System.Windows.Forms.ComboBox();
            this.dateTimeVacuna = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new Proyecto_Taller_2.CustomButton();
            this.btnClose = new Proyecto_Taller_2.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veterinario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Vacunación";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservaciones.BorderColor = System.Drawing.Color.Black;
            this.txtObservaciones.BorderFocusColor = System.Drawing.Color.Black;
            this.txtObservaciones.BorderRadius = 8;
            this.txtObservaciones.BorderSize = 1;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservaciones.Location = new System.Drawing.Point(489, 241);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtObservaciones.PasswordChar = false;
            this.txtObservaciones.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservaciones.PlaceholderText = "";
            this.txtObservaciones.Size = new System.Drawing.Size(250, 96);
            this.txtObservaciones.TabIndex = 2;
            this.txtObservaciones.Texts = "";
            this.txtObservaciones.UnderlinedStyle = false;
            // 
            // comboBoxMascota
            // 
            this.comboBoxMascota.FormattingEnabled = true;
            this.comboBoxMascota.Location = new System.Drawing.Point(125, 142);
            this.comboBoxMascota.Name = "comboBoxMascota";
            this.comboBoxMascota.Size = new System.Drawing.Size(250, 26);
            this.comboBoxMascota.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proxima vacunación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observaciones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vacuna:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Laboratorio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mascota:";
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(125, 343);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(250, 26);
            this.comboBoxVeterinario.TabIndex = 10;
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.SystemColors.Window;
            this.txtLote.BorderColor = System.Drawing.Color.Black;
            this.txtLote.BorderFocusColor = System.Drawing.Color.Black;
            this.txtLote.BorderRadius = 8;
            this.txtLote.BorderSize = 1;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLote.Location = new System.Drawing.Point(489, 138);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtLote.Multiline = true;
            this.txtLote.Name = "txtLote";
            this.txtLote.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLote.PasswordChar = false;
            this.txtLote.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLote.PlaceholderText = "";
            this.txtLote.Size = new System.Drawing.Size(250, 30);
            this.txtLote.TabIndex = 11;
            this.txtLote.Texts = "";
            this.txtLote.UnderlinedStyle = false;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.BackColor = System.Drawing.SystemColors.Window;
            this.txtLaboratorio.BorderColor = System.Drawing.Color.Black;
            this.txtLaboratorio.BorderFocusColor = System.Drawing.Color.Black;
            this.txtLaboratorio.BorderRadius = 8;
            this.txtLaboratorio.BorderSize = 1;
            this.txtLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLaboratorio.Location = new System.Drawing.Point(125, 449);
            this.txtLaboratorio.Margin = new System.Windows.Forms.Padding(4);
            this.txtLaboratorio.Multiline = true;
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLaboratorio.PasswordChar = false;
            this.txtLaboratorio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLaboratorio.PlaceholderText = "";
            this.txtLaboratorio.Size = new System.Drawing.Size(250, 30);
            this.txtLaboratorio.TabIndex = 12;
            this.txtLaboratorio.Texts = "";
            this.txtLaboratorio.UnderlinedStyle = false;
            // 
            // comboBoxVacuna
            // 
            this.comboBoxVacuna.FormattingEnabled = true;
            this.comboBoxVacuna.Location = new System.Drawing.Point(125, 241);
            this.comboBoxVacuna.Name = "comboBoxVacuna";
            this.comboBoxVacuna.Size = new System.Drawing.Size(250, 26);
            this.comboBoxVacuna.TabIndex = 13;
            // 
            // dateTimeVacuna
            // 
            this.dateTimeVacuna.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimeVacuna.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeVacuna.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeVacuna.Location = new System.Drawing.Point(489, 445);
            this.dateTimeVacuna.Name = "dateTimeVacuna";
            this.dateTimeVacuna.Size = new System.Drawing.Size(250, 34);
            this.dateTimeVacuna.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardar.BorderRadius = 8;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(619, 512);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(489, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VacunacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimeVacuna);
            this.Controls.Add(this.comboBoxVacuna);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMascota);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VacunacionForm";
            this.Size = new System.Drawing.Size(896, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtObservaciones;
        private System.Windows.Forms.ComboBox comboBoxMascota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private CustomControls.RJControls.RJTextBox txtLote;
        private CustomControls.RJControls.RJTextBox txtLaboratorio;
        private System.Windows.Forms.ComboBox comboBoxVacuna;
        private System.Windows.Forms.DateTimePicker dateTimeVacuna;
        private CustomButton btnClose;
        private CustomButton btnGuardar;
    }
}
