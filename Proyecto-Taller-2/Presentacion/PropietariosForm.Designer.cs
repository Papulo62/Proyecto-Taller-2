namespace Proyecto_Taller_2.Presentacion
{
    partial class PropietariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new CustomControls.RJControls.RJTextBox();
            this.btnCerrar = new Proyecto_Taller_2.CustomButton();
            this.txtTelefonoAlt = new CustomControls.RJControls.RJTextBox();
            this.txtDireccion = new CustomControls.RJControls.RJTextBox();
            this.txtTelefono = new CustomControls.RJControls.RJTextBox();
            this.txtDni = new CustomControls.RJControls.RJTextBox();
            this.txtNombre = new CustomControls.RJControls.RJTextBox();
            this.btnGuardar = new Proyecto_Taller_2.CustomButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 45);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nuevo Propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Teléfono Alternativo (Opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderColor = System.Drawing.Color.Black;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.Black;
            this.txtApellido.BorderRadius = 8;
            this.txtApellido.BorderSize = 1;
            this.txtApellido.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.Location = new System.Drawing.Point(93, 192);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PlaceholderText = "Ingrese el apellido:";
            this.txtApellido.Size = new System.Drawing.Size(250, 30);
            this.txtApellido.TabIndex = 43;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.BorderRadius = 8;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(463, 370);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 31);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.Black;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTelefonoAlt
            // 
            this.txtTelefonoAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefonoAlt.BorderColor = System.Drawing.Color.Black;
            this.txtTelefonoAlt.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTelefonoAlt.BorderRadius = 8;
            this.txtTelefonoAlt.BorderSize = 1;
            this.txtTelefonoAlt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefonoAlt.Location = new System.Drawing.Point(463, 294);
            this.txtTelefonoAlt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoAlt.Multiline = true;
            this.txtTelefonoAlt.Name = "txtTelefonoAlt";
            this.txtTelefonoAlt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefonoAlt.PasswordChar = false;
            this.txtTelefonoAlt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoAlt.PlaceholderText = "Ingrese el tel alternativo:";
            this.txtTelefonoAlt.Size = new System.Drawing.Size(250, 30);
            this.txtTelefonoAlt.TabIndex = 33;
            this.txtTelefonoAlt.Texts = "";
            this.txtTelefonoAlt.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.Black;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDireccion.BorderRadius = 8;
            this.txtDireccion.BorderSize = 1;
            this.txtDireccion.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(93, 294);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.PlaceholderText = "Ingrese la dirección:";
            this.txtDireccion.Size = new System.Drawing.Size(250, 30);
            this.txtDireccion.TabIndex = 31;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.Black;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTelefono.BorderRadius = 8;
            this.txtTelefono.BorderSize = 1;
            this.txtTelefono.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(463, 192);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "Ingrese el telefono:";
            this.txtTelefono.Size = new System.Drawing.Size(250, 30);
            this.txtTelefono.TabIndex = 29;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.Window;
            this.txtDni.BorderColor = System.Drawing.Color.Black;
            this.txtDni.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDni.BorderRadius = 8;
            this.txtDni.BorderSize = 1;
            this.txtDni.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.Location = new System.Drawing.Point(463, 99);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDni.PasswordChar = false;
            this.txtDni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDni.PlaceholderText = "Ingrese el dni:";
            this.txtDni.Size = new System.Drawing.Size(250, 30);
            this.txtDni.TabIndex = 27;
            this.txtDni.Texts = "";
            this.txtDni.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.Black;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.Black;
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(93, 99);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Ingrese el nombre:";
            this.txtNombre.Size = new System.Drawing.Size(250, 30);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(617, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 31);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PropietariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoAlt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "PropietariosForm";
            this.Size = new System.Drawing.Size(827, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtNombre;
        private CustomControls.RJControls.RJTextBox txtDni;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txtTelefonoAlt;
        private System.Windows.Forms.Label label5;
        private CustomButton btnCerrar;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox txtApellido;
        private CustomButton btnGuardar;
    }
}