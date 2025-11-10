
namespace Proyecto_Taller_2
{
    partial class MascotasForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dptNacimiento = new System.Windows.Forms.DateTimePicker();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstadoReproductivo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVivo = new System.Windows.Forms.ComboBox();
            this.txtPeso = new CustomControls.RJControls.RJTextBox();
            this.customButton3 = new Proyecto_Taller_2.CustomButton();
            this.btnGuardar = new Proyecto_Taller_2.CustomButton();
            this.btnAgregarFoto = new Proyecto_Taller_2.CustomButton();
            this.txtNombre = new CustomControls.RJControls.RJTextBox();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(300, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(131, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(131, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Raza:";
            // 
            // cmbRaza
            // 
            this.cmbRaza.DisplayMember = "nombre_raza";
            this.cmbRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(134, 204);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(250, 24);
            this.cmbRaza.TabIndex = 20;
            this.cmbRaza.ValueMember = "id_raza";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cmbSexo.Location = new System.Drawing.Point(134, 267);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(250, 24);
            this.cmbSexo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(131, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sexo:";
            // 
            // dptNacimiento
            // 
            this.dptNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptNacimiento.Location = new System.Drawing.Point(502, 420);
            this.dptNacimiento.Name = "dptNacimiento";
            this.dptNacimiento.Size = new System.Drawing.Size(250, 20);
            this.dptNacimiento.TabIndex = 24;
            // 
            // picFoto
            // 
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFoto.Image = global::Proyecto_Taller_2.Properties.Resources._3813f97e7bb75310640248af5c06e2eb;
            this.picFoto.Location = new System.Drawing.Point(502, 93);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(250, 215);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 25;
            this.picFoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(499, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(131, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Estado reproductivo:";
            // 
            // cmbEstadoReproductivo
            // 
            this.cmbEstadoReproductivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoReproductivo.FormattingEnabled = true;
            this.cmbEstadoReproductivo.Items.AddRange(new object[] {
            "Castrado ",
            "No castrado "});
            this.cmbEstadoReproductivo.Location = new System.Drawing.Point(134, 338);
            this.cmbEstadoReproductivo.Name = "cmbEstadoReproductivo";
            this.cmbEstadoReproductivo.Size = new System.Drawing.Size(250, 24);
            this.cmbEstadoReproductivo.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(131, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(503, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Está vivo?: ";
            // 
            // cmbVivo
            // 
            this.cmbVivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVivo.FormattingEnabled = true;
            this.cmbVivo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbVivo.Location = new System.Drawing.Point(502, 493);
            this.cmbVivo.Name = "cmbVivo";
            this.cmbVivo.Size = new System.Drawing.Size(250, 24);
            this.cmbVivo.TabIndex = 35;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.Window;
            this.txtPeso.BorderColor = System.Drawing.Color.Black;
            this.txtPeso.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPeso.BorderRadius = 8;
            this.txtPeso.BorderSize = 1;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPeso.Location = new System.Drawing.Point(134, 410);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeso.PasswordChar = false;
            this.txtPeso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeso.PlaceholderText = "Ingrese el  peso de la mascota:";
            this.txtPeso.Size = new System.Drawing.Size(250, 30);
            this.txtPeso.TabIndex = 34;
            this.txtPeso.Texts = "";
            this.txtPeso.UnderlinedStyle = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.LightGray;
            this.customButton3.BackgroundColor = System.Drawing.Color.LightGray;
            this.customButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton3.BorderRadius = 8;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.Location = new System.Drawing.Point(502, 545);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(123, 35);
            this.customButton3.TabIndex = 31;
            this.customButton3.Text = "Cerrar";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(637, 545);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 35);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarFoto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarFoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregarFoto.BorderRadius = 8;
            this.btnAgregarFoto.BorderSize = 0;
            this.btnAgregarFoto.FlatAppearance.BorderSize = 0;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFoto.Location = new System.Drawing.Point(502, 332);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(250, 35);
            this.btnAgregarFoto.TabIndex = 29;
            this.btnAgregarFoto.Text = "Agregar foto";
            this.btnAgregarFoto.TextColor = System.Drawing.Color.White;
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.Black;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.Black;
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(134, 122);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Ingrese el nombre de la mascota:";
            this.txtNombre.Size = new System.Drawing.Size(250, 30);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DisplayMember = "nombre_raza";
            this.cmbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(134, 493);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(250, 24);
            this.cmbPropietario.TabIndex = 36;
            this.cmbPropietario.ValueMember = "id_raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Propietario:";
            // 
            // MascotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPropietario);
            this.Controls.Add(this.cmbVivo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarFoto);
            this.Controls.Add(this.cmbEstadoReproductivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.dptNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "MascotasForm";
            this.Size = new System.Drawing.Size(896, 599);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dptNacimiento;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstadoReproductivo;
        private CustomButton btnAgregarFoto;
        private CustomButton btnGuardar;
        private CustomButton customButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox txtPeso;
        private System.Windows.Forms.ComboBox cmbVivo;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.Label label2;
    }
}
