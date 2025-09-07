
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
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new Proyecto_Taller_2.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.customButton2 = new Proyecto_Taller_2.CustomButton();
            this.textBoxBackup = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkGray;
            this.customButton1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.customButton1.BorderColor = System.Drawing.Color.Silver;
            this.customButton1.BorderRadius = 8;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(308, 269);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(113, 40);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Cancelar";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generar backup:";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.customButton2.BorderRadius = 8;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(154, 269);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(124, 40);
            this.customButton2.TabIndex = 4;
            this.customButton2.Text = "Backup";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // textBoxBackup
            // 
            this.textBoxBackup.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBackup.BorderColor = System.Drawing.Color.Black;
            this.textBoxBackup.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxBackup.BorderRadius = 8;
            this.textBoxBackup.BorderSize = 1;
            this.textBoxBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBackup.Location = new System.Drawing.Point(171, 138);
            this.textBoxBackup.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBackup.Multiline = true;
            this.textBoxBackup.Name = "textBoxBackup";
            this.textBoxBackup.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxBackup.PasswordChar = false;
            this.textBoxBackup.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxBackup.PlaceholderText = "Ruta del backup:";
            this.textBoxBackup.Size = new System.Drawing.Size(250, 30);
            this.textBoxBackup.TabIndex = 5;
            this.textBoxBackup.Texts = "";
            this.textBoxBackup.UnderlinedStyle = false;
            this.textBoxBackup._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxBackup);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Backup";
            this.Size = new System.Drawing.Size(1045, 737);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomButton customButton1;
        private System.Windows.Forms.Label label2;
        private CustomButton customButton2;
        private CustomControls.RJControls.RJTextBox textBoxBackup;
    }
}
