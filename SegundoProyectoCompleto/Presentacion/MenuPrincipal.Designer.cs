
namespace SegundoProyectoCompleto.Presentacion
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panelPadre = new System.Windows.Forms.Panel();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEstaciones = new System.Windows.Forms.Button();
            this.btnRespaldo = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPadre.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Teal;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(0, 37);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(178, 53);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Pre planilla";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // panelPadre
            // 
            this.panelPadre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelPadre.Controls.Add(this.panelBienvenida);
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(175, 0);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(1195, 708);
            this.panelPadre.TabIndex = 2;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBienvenida.Controls.Add(this.label3);
            this.panelBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBienvenida.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(1195, 257);
            this.panelBienvenida.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 84.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(62, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 187);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenido ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnEstaciones
            // 
            this.btnEstaciones.BackColor = System.Drawing.Color.Teal;
            this.btnEstaciones.BackgroundImage = global::SegundoProyectoCompleto.Properties.Resources.rectangulo_redondeado2;
            this.btnEstaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstaciones.FlatAppearance.BorderSize = 0;
            this.btnEstaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstaciones.ForeColor = System.Drawing.Color.White;
            this.btnEstaciones.Image = global::SegundoProyectoCompleto.Properties.Resources.cohete;
            this.btnEstaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstaciones.Location = new System.Drawing.Point(0, 320);
            this.btnEstaciones.Name = "btnEstaciones";
            this.btnEstaciones.Size = new System.Drawing.Size(178, 63);
            this.btnEstaciones.TabIndex = 3;
            this.btnEstaciones.Text = "Estaciones";
            this.btnEstaciones.UseVisualStyleBackColor = false;
            this.btnEstaciones.Click += new System.EventHandler(this.btnEstaciones_Click);
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.BackColor = System.Drawing.Color.Teal;
            this.btnRespaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRespaldo.FlatAppearance.BorderSize = 0;
            this.btnRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldo.ForeColor = System.Drawing.Color.White;
            this.btnRespaldo.Image = global::SegundoProyectoCompleto.Properties.Resources.transferencia_de_datos;
            this.btnRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldo.Location = new System.Drawing.Point(0, 160);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Size = new System.Drawing.Size(178, 72);
            this.btnRespaldo.TabIndex = 3;
            this.btnRespaldo.Text = "Respaldo";
            this.btnRespaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldo.UseVisualStyleBackColor = false;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.Teal;
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Image = global::SegundoProyectoCompleto.Properties.Resources.actualizar;
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar.Location = new System.Drawing.Point(0, 232);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(178, 70);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar BD";
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Teal;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::SegundoProyectoCompleto.Properties.Resources.empleados;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 71);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(178, 71);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Teal;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.Location = new System.Drawing.Point(0, 90);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(178, 65);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 18);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 37);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(101, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.Location = new System.Drawing.Point(38, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEstaciones);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnRestaurar);
            this.panel4.Controls.Add(this.btnRespaldo);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.btnUsuarios);
            this.panel4.Controls.Add(this.btnRegistro);
            this.panel4.Location = new System.Drawing.Point(0, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 551);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 18);
            this.panel6.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::SegundoProyectoCompleto.Properties.Resources.Logo_final;
            this.pictureBox1.Location = new System.Drawing.Point(0, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Teal;
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = global::SegundoProyectoCompleto.Properties.Resources.reloj_de_pared;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(178, 71);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistro.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 708);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPersonal);
            this.panel5.Controls.Add(this.btnConsultas);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 153);
            this.panel5.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 708);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelPadre.ResumeLayout(false);
            this.panelBienvenida.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.Button btnRespaldo;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEstaciones;
        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}