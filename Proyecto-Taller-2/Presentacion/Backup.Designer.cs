namespace Proyecto_Taller_2.Presentacion
{
    partial class Backup
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBackup = new System.Windows.Forms.Panel();
            this.btnGenerarBackup = new Proyecto_Taller_2.CustomButton();
            this.btnSeleccionarRuta = new Proyecto_Taller_2.CustomButton();
            this.textBoxBackup = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(336, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Backup de Datos";
            // 
            // panelBackup
            // 
            this.panelBackup.BackColor = System.Drawing.Color.White;
            this.panelBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackup.Controls.Add(this.btnGenerarBackup);
            this.panelBackup.Controls.Add(this.btnSeleccionarRuta);
            this.panelBackup.Controls.Add(this.textBoxBackup);
            this.panelBackup.Controls.Add(this.label2);
            this.panelBackup.Controls.Add(this.label1);
            this.panelBackup.Controls.Add(this.pictureBox1);
            this.panelBackup.Location = new System.Drawing.Point(30, 85);
            this.panelBackup.Name = "panelBackup";
            this.panelBackup.Size = new System.Drawing.Size(815, 280);
            this.panelBackup.TabIndex = 1;
            // 
            // btnGenerarBackup
            // 
            this.btnGenerarBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerarBackup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerarBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerarBackup.BorderRadius = 8;
            this.btnGenerarBackup.BorderSize = 0;
            this.btnGenerarBackup.FlatAppearance.BorderSize = 0;
            this.btnGenerarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarBackup.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarBackup.ForeColor = System.Drawing.Color.White;
            this.btnGenerarBackup.Location = new System.Drawing.Point(300, 210);
            this.btnGenerarBackup.Name = "btnGenerarBackup";
            this.btnGenerarBackup.Size = new System.Drawing.Size(200, 45);
            this.btnGenerarBackup.TabIndex = 5;
            this.btnGenerarBackup.Text = "💾 Generar Backup";
            this.btnGenerarBackup.TextColor = System.Drawing.Color.White;
            this.btnGenerarBackup.UseVisualStyleBackColor = false;
            this.btnGenerarBackup.Click += new System.EventHandler(this.btnGenerarBackup_Click);
            // 
            // btnSeleccionarRuta
            // 
            this.btnSeleccionarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSeleccionarRuta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSeleccionarRuta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSeleccionarRuta.BorderRadius = 8;
            this.btnSeleccionarRuta.BorderSize = 0;
            this.btnSeleccionarRuta.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarRuta.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarRuta.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarRuta.Location = new System.Drawing.Point(620, 150);
            this.btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            this.btnSeleccionarRuta.Size = new System.Drawing.Size(170, 35);
            this.btnSeleccionarRuta.TabIndex = 4;
            this.btnSeleccionarRuta.Text = "📁 Seleccionar";
            this.btnSeleccionarRuta.TextColor = System.Drawing.Color.White;
            this.btnSeleccionarRuta.UseVisualStyleBackColor = false;
            this.btnSeleccionarRuta.Click += new System.EventHandler(this.btnSeleccionarRuta_Click);
            // 
            // textBoxBackup
            // 
            this.textBoxBackup.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.textBoxBackup.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.textBoxBackup.BorderRadius = 8;
            this.textBoxBackup.BorderSize = 2;
            this.textBoxBackup.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBackup.Location = new System.Drawing.Point(180, 150);
            this.textBoxBackup.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBackup.Multiline = false;
            this.textBoxBackup.Name = "textBoxBackup";
            this.textBoxBackup.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxBackup.PasswordChar = false;
            this.textBoxBackup.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxBackup.PlaceholderText = "Seleccione la carpeta de destino...";
            this.textBoxBackup.Size = new System.Drawing.Size(430, 43);
            this.textBoxBackup.TabIndex = 3;
            this.textBoxBackup.Texts = "";
            this.textBoxBackup.UnderlinedStyle = false;
            this.textBoxBackup._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carpeta de Destino:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(180, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genere una copia de seguridad de su base de datos para proteger la información de" +
    " su veterinaria.\r\n\r\nSeleccione la carpeta donde desea guardar el backup y haga c" +
    "lic en \"Generar Backup\".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelBackup);
            this.Controls.Add(this.labelTitle);
            this.Name = "Backup";
            this.Size = new System.Drawing.Size(872, 720);
            this.Load += new System.EventHandler(this.Backup_Load);
            this.panelBackup.ResumeLayout(false);
            this.panelBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox textBoxBackup;
        private CustomButton btnSeleccionarRuta;
        private CustomButton btnGenerarBackup;
    }
}