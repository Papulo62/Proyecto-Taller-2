
namespace Proyecto_Taller_2
{
    partial class Form2
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
            this.navbar = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPropietarios = new FontAwesome.Sharp.IconButton();
            this.btnMascotas = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnTurnos = new FontAwesome.Sharp.IconButton();
            this.btnConsultas = new FontAwesome.Sharp.IconButton();
            this.btnBackup = new FontAwesome.Sharp.IconButton();
            this.btnVeterinario = new FontAwesome.Sharp.IconButton();
            this.btnVacunas = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.navbar.Controls.Add(this.iconPictureBox1);
            this.navbar.Controls.Add(this.label2);
            this.navbar.Controls.Add(this.label1);
            this.navbar.Controls.Add(this.iconButton2);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1161, 62);
            this.navbar.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(57, 50);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(982, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome, Dr.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veterinary Software";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1103, 12);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(58, 44);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnPropietarios);
            this.panel1.Controls.Add(this.btnMascotas);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnTurnos);
            this.panel1.Controls.Add(this.btnConsultas);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnVeterinario);
            this.panel1.Controls.Add(this.btnVacunas);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 599);
            this.panel1.TabIndex = 1;
            // 
            // btnPropietarios
            // 
            this.btnPropietarios.FlatAppearance.BorderSize = 0;
            this.btnPropietarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropietarios.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropietarios.ForeColor = System.Drawing.Color.White;
            this.btnPropietarios.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnPropietarios.IconColor = System.Drawing.Color.White;
            this.btnPropietarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPropietarios.IconSize = 30;
            this.btnPropietarios.Location = new System.Drawing.Point(17, 125);
            this.btnPropietarios.Name = "btnPropietarios";
            this.btnPropietarios.Size = new System.Drawing.Size(171, 36);
            this.btnPropietarios.TabIndex = 12;
            this.btnPropietarios.Text = "Propietarios";
            this.btnPropietarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPropietarios.UseVisualStyleBackColor = true;
            this.btnPropietarios.Click += new System.EventHandler(this.iconButton12_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.FlatAppearance.BorderSize = 0;
            this.btnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMascotas.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotas.ForeColor = System.Drawing.Color.White;
            this.btnMascotas.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.btnMascotas.IconColor = System.Drawing.Color.White;
            this.btnMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMascotas.IconSize = 30;
            this.btnMascotas.Location = new System.Drawing.Point(17, 72);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(138, 36);
            this.btnMascotas.TabIndex = 11;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.Location = new System.Drawing.Point(17, 426);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(138, 36);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.White;
            this.btnTurnos.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnTurnos.IconColor = System.Drawing.Color.White;
            this.btnTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTurnos.IconSize = 30;
            this.btnTurnos.Location = new System.Drawing.Point(12, 180);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(138, 36);
            this.btnTurnos.TabIndex = 9;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnConsultas.IconColor = System.Drawing.Color.White;
            this.btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultas.IconSize = 30;
            this.btnConsultas.Location = new System.Drawing.Point(17, 240);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(138, 36);
            this.btnConsultas.TabIndex = 8;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnBackup.IconColor = System.Drawing.Color.White;
            this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackup.IconSize = 30;
            this.btnBackup.Location = new System.Drawing.Point(12, 539);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(138, 36);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnVeterinario
            // 
            this.btnVeterinario.FlatAppearance.BorderSize = 0;
            this.btnVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeterinario.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeterinario.ForeColor = System.Drawing.Color.White;
            this.btnVeterinario.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.btnVeterinario.IconColor = System.Drawing.Color.White;
            this.btnVeterinario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVeterinario.IconSize = 30;
            this.btnVeterinario.Location = new System.Drawing.Point(17, 371);
            this.btnVeterinario.Name = "btnVeterinario";
            this.btnVeterinario.Size = new System.Drawing.Size(147, 36);
            this.btnVeterinario.TabIndex = 6;
            this.btnVeterinario.Text = "Veterinario";
            this.btnVeterinario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVeterinario.UseVisualStyleBackColor = true;
            this.btnVeterinario.Click += new System.EventHandler(this.iconButton6_Click_1);
            // 
            // btnVacunas
            // 
            this.btnVacunas.FlatAppearance.BorderSize = 0;
            this.btnVacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacunas.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacunas.ForeColor = System.Drawing.Color.White;
            this.btnVacunas.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.btnVacunas.IconColor = System.Drawing.Color.White;
            this.btnVacunas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVacunas.IconSize = 30;
            this.btnVacunas.Location = new System.Drawing.Point(17, 305);
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Size = new System.Drawing.Size(138, 36);
            this.btnVacunas.TabIndex = 5;
            this.btnVacunas.Text = "Vacunas";
            this.btnVacunas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVacunas.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.Location = new System.Drawing.Point(12, 20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(157, 36);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 30;
            this.btnReportes.Location = new System.Drawing.Point(12, 488);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(149, 36);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(288, 62);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(873, 599);
            this.panelContainer.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 661);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navbar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnVacunas;
        private FontAwesome.Sharp.IconButton btnBackup;
        private FontAwesome.Sharp.IconButton btnVeterinario;
        private FontAwesome.Sharp.IconButton btnPropietarios;
        private FontAwesome.Sharp.IconButton btnMascotas;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnTurnos;
        private FontAwesome.Sharp.IconButton btnConsultas;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelContainer;
    }
}