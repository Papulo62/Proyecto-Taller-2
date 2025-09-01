namespace Proyecto_Taller_2
{
    partial class TurnosForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxMascota = new System.Windows.Forms.ComboBox();
            this.comboBoxPropietario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.btnCerrarTurno = new Proyecto_Taller_2.CustomButton();
            this.btnGuardarTurno = new Proyecto_Taller_2.CustomButton();
            this.txtMotivo = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 50);
            this.label8.TabIndex = 22;
            this.label8.Text = "Asignar Turno";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha del turno:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(474, 243);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hora del turno:";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.comboBoxHora.Location = new System.Drawing.Point(67, 204);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(250, 21);
            this.comboBoxHora.TabIndex = 30;
            // 
            // comboBoxMascota
            // 
            this.comboBoxMascota.FormattingEnabled = true;
            this.comboBoxMascota.Items.AddRange(new object[] {
            "Perro",
            "Gato ",
            "Pajaro",
            "Conejo",
            "Tortuga"});
            this.comboBoxMascota.Location = new System.Drawing.Point(67, 264);
            this.comboBoxMascota.Name = "comboBoxMascota";
            this.comboBoxMascota.Size = new System.Drawing.Size(250, 21);
            this.comboBoxMascota.TabIndex = 31;
            // 
            // comboBoxPropietario
            // 
            this.comboBoxPropietario.FormattingEnabled = true;
            this.comboBoxPropietario.Items.AddRange(new object[] {
            "Pedro",
            "Juan ",
            "Tomas ",
            "Luis"});
            this.comboBoxPropietario.Location = new System.Drawing.Point(67, 328);
            this.comboBoxPropietario.Name = "comboBoxPropietario";
            this.comboBoxPropietario.Size = new System.Drawing.Size(250, 21);
            this.comboBoxPropietario.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mascota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Propietario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Veterinario Asignado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(471, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Motivo de la consulta:";
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Items.AddRange(new object[] {
            "Sanchéz",
            "Medina",
            "Valdés"});
            this.comboBoxVeterinario.Location = new System.Drawing.Point(67, 387);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(250, 21);
            this.comboBoxVeterinario.TabIndex = 38;
            // 
            // btnCerrarTurno
            // 
            this.btnCerrarTurno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrarTurno.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrarTurno.BorderColor = System.Drawing.Color.White;
            this.btnCerrarTurno.BorderRadius = 8;
            this.btnCerrarTurno.BorderSize = 0;
            this.btnCerrarTurno.FlatAppearance.BorderSize = 0;
            this.btnCerrarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarTurno.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarTurno.Location = new System.Drawing.Point(265, 452);
            this.btnCerrarTurno.Name = "btnCerrarTurno";
            this.btnCerrarTurno.Size = new System.Drawing.Size(105, 31);
            this.btnCerrarTurno.TabIndex = 43;
            this.btnCerrarTurno.Text = "Cerrar";
            this.btnCerrarTurno.TextColor = System.Drawing.Color.Black;
            this.btnCerrarTurno.UseVisualStyleBackColor = false;
            this.btnCerrarTurno.Click += new System.EventHandler(this.btnCerrarTurno_Click);
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardarTurno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardarTurno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardarTurno.BorderRadius = 8;
            this.btnGuardarTurno.BorderSize = 0;
            this.btnGuardarTurno.FlatAppearance.BorderSize = 0;
            this.btnGuardarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTurno.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTurno.Location = new System.Drawing.Point(420, 452);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(105, 31);
            this.btnGuardarTurno.TabIndex = 42;
            this.btnGuardarTurno.Text = "Guardar Turno";
            this.btnGuardarTurno.TextColor = System.Drawing.Color.White;
            this.btnGuardarTurno.UseVisualStyleBackColor = false;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.SystemColors.Window;
            this.txtMotivo.BorderColor = System.Drawing.Color.Black;
            this.txtMotivo.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMotivo.BorderRadius = 8;
            this.txtMotivo.BorderSize = 1;
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMotivo.Location = new System.Drawing.Point(474, 153);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMotivo.PasswordChar = false;
            this.txtMotivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.Size = new System.Drawing.Size(218, 72);
            this.txtMotivo.TabIndex = 37;
            this.txtMotivo.Texts = "";
            this.txtMotivo.UnderlinedStyle = false;
            this.txtMotivo._TextChanged += new System.EventHandler(this.txtMotivo__TextChanged);
            // 
            // TurnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCerrarTurno);
            this.Controls.Add(this.btnGuardarTurno);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPropietario);
            this.Controls.Add(this.comboBoxMascota);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Name = "TurnosForm";
            this.Size = new System.Drawing.Size(774, 511);
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.ComboBox comboBoxMascota;
        private System.Windows.Forms.ComboBox comboBoxPropietario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox txtMotivo;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private CustomButton btnCerrarTurno;
        private CustomButton btnGuardarTurno;
    }
}
