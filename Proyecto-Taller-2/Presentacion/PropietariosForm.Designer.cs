namespace Proyecto_Taller_2
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
            this.customButton3 = new Proyecto_Taller_2.CustomButton();
            this.customButton1 = new Proyecto_Taller_2.CustomButton();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.customButton3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.customButton3.BorderColor = System.Drawing.Color.White;
            this.customButton3.BorderRadius = 8;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.Location = new System.Drawing.Point(463, 370);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(96, 31);
            this.customButton3.TabIndex = 41;
            this.customButton3.Text = "Cerrar";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton1.BorderRadius = 8;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(617, 370);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(96, 31);
            this.customButton1.TabIndex = 37;
            this.customButton1.Text = "Registrar";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.Black;
            this.rjTextBox5.BorderRadius = 8;
            this.rjTextBox5.BorderSize = 1;
            this.rjTextBox5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox5.Location = new System.Drawing.Point(463, 294);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = true;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "Ingrese el tel alternativo:";
            this.rjTextBox5.Size = new System.Drawing.Size(250, 30);
            this.rjTextBox5.TabIndex = 33;
            this.rjTextBox5.Texts = "";
            this.rjTextBox5.UnderlinedStyle = false;
            this.rjTextBox5._TextChanged += new System.EventHandler(this.rjTextBox5__TextChanged);
            this.rjTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox5_KeyPress);
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.Black;
            this.rjTextBox4.BorderRadius = 8;
            this.rjTextBox4.BorderSize = 1;
            this.rjTextBox4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(93, 294);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = true;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "Ingrese la dirección:";
            this.rjTextBox4.Size = new System.Drawing.Size(250, 30);
            this.rjTextBox4.TabIndex = 31;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            this.rjTextBox4._TextChanged += new System.EventHandler(this.rjTextBox4__TextChanged);
            this.rjTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox4_KeyPress);
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.Black;
            this.rjTextBox3.BorderRadius = 8;
            this.rjTextBox3.BorderSize = 1;
            this.rjTextBox3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(463, 192);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = true;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "Ingrese el telefono:";
            this.rjTextBox3.Size = new System.Drawing.Size(250, 30);
            this.rjTextBox3.TabIndex = 29;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            this.rjTextBox3._TextChanged += new System.EventHandler(this.rjTextBox3__TextChanged);
            this.rjTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox3_KeyPress);
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.Black;
            this.rjTextBox2.BorderRadius = 8;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(463, 99);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = true;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "Ingrese el dni:";
            this.rjTextBox2.Size = new System.Drawing.Size(250, 30);
            this.rjTextBox2.TabIndex = 27;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            this.rjTextBox2._TextChanged += new System.EventHandler(this.rjTextBox2__TextChanged);
            this.rjTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox2_KeyPress);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.rjTextBox1.BorderRadius = 8;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(93, 99);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Ingrese el nombre:";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 30);
            this.rjTextBox1.TabIndex = 26;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            this.rjTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox1_KeyPress);
            // 
            // PropietariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rjTextBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rjTextBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjTextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "PropietariosForm";
            this.Size = new System.Drawing.Size(827, 470);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private System.Windows.Forms.Label label5;
        private CustomButton customButton1;
        private CustomButton customButton3;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox txtApellido;
    }
}