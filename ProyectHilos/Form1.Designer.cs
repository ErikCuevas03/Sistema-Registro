namespace ProyectHilos
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraOpciones = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ADMIN = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Registro = new System.Windows.Forms.Button();
            this.acvtividad = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IconoCasa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoTec = new System.Windows.Forms.PictureBox();
            this.ayuda = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.soporte = new System.Windows.Forms.PictureBox();
            this.MUESTREO = new System.Windows.Forms.Panel();
            this.Inicio = new System.Windows.Forms.Button();
            this.BarraOpciones.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuario)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acvtividad)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soporte)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraOpciones
            // 
            this.BarraOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BarraOpciones.BackColor = System.Drawing.Color.RoyalBlue;
            this.BarraOpciones.Controls.Add(this.panel6);
            this.BarraOpciones.Controls.Add(this.panel5);
            this.BarraOpciones.Controls.Add(this.panel4);
            this.BarraOpciones.Controls.Add(this.label1);
            this.BarraOpciones.Location = new System.Drawing.Point(2, 77);
            this.BarraOpciones.Name = "BarraOpciones";
            this.BarraOpciones.Size = new System.Drawing.Size(197, 275);
            this.BarraOpciones.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ADMIN);
            this.panel6.Controls.Add(this.Usuario);
            this.panel6.Location = new System.Drawing.Point(16, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(163, 50);
            this.panel6.TabIndex = 6;
            // 
            // ADMIN
            // 
            this.ADMIN.Location = new System.Drawing.Point(51, 13);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(109, 34);
            this.ADMIN.TabIndex = 6;
            this.ADMIN.Text = "ADMINISTRADOR";
            this.ADMIN.UseVisualStyleBackColor = true;
            this.ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Usuario.Image")));
            this.Usuario.Location = new System.Drawing.Point(3, 3);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(45, 45);
            this.Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Usuario.TabIndex = 1;
            this.Usuario.TabStop = false;
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Registro);
            this.panel5.Controls.Add(this.acvtividad);
            this.panel5.Location = new System.Drawing.Point(21, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 51);
            this.panel5.TabIndex = 6;
            // 
            // Registro
            // 
            this.Registro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Registro.Location = new System.Drawing.Point(54, 7);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(83, 29);
            this.Registro.TabIndex = 2;
            this.Registro.Text = "REGISTRO";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // acvtividad
            // 
            this.acvtividad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acvtividad.Image = ((System.Drawing.Image)(resources.GetObject("acvtividad.Image")));
            this.acvtividad.Location = new System.Drawing.Point(3, 3);
            this.acvtividad.Name = "acvtividad";
            this.acvtividad.Size = new System.Drawing.Size(45, 45);
            this.acvtividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acvtividad.TabIndex = 1;
            this.acvtividad.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Inicio);
            this.panel4.Controls.Add(this.IconoCasa);
            this.panel4.Location = new System.Drawing.Point(21, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 57);
            this.panel4.TabIndex = 6;
            // 
            // IconoCasa
            // 
            this.IconoCasa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IconoCasa.Image = ((System.Drawing.Image)(resources.GetObject("IconoCasa.Image")));
            this.IconoCasa.Location = new System.Drawing.Point(3, 3);
            this.IconoCasa.Name = "IconoCasa";
            this.IconoCasa.Size = new System.Drawing.Size(45, 45);
            this.IconoCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconoCasa.TabIndex = 1;
            this.IconoCasa.TabStop = false;
            this.IconoCasa.Click += new System.EventHandler(this.IconoCasa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // LogoTec
            // 
            this.LogoTec.Image = ((System.Drawing.Image)(resources.GetObject("LogoTec.Image")));
            this.LogoTec.Location = new System.Drawing.Point(36, 9);
            this.LogoTec.Name = "LogoTec";
            this.LogoTec.Size = new System.Drawing.Size(78, 68);
            this.LogoTec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoTec.TabIndex = 1;
            this.LogoTec.TabStop = false;
            this.LogoTec.UseWaitCursor = true;
            // 
            // ayuda
            // 
            this.ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ayuda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ayuda.Image = ((System.Drawing.Image)(resources.GetObject("ayuda.Image")));
            this.ayuda.Location = new System.Drawing.Point(626, 16);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(45, 45);
            this.ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ayuda.TabIndex = 1;
            this.ayuda.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.soporte);
            this.panel1.Controls.Add(this.ayuda);
            this.panel1.Controls.Add(this.LogoTec);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 80);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // soporte
            // 
            this.soporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soporte.Image = ((System.Drawing.Image)(resources.GetObject("soporte.Image")));
            this.soporte.Location = new System.Drawing.Point(575, 16);
            this.soporte.Name = "soporte";
            this.soporte.Size = new System.Drawing.Size(45, 45);
            this.soporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soporte.TabIndex = 2;
            this.soporte.TabStop = false;
            // 
            // MUESTREO
            // 
            this.MUESTREO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MUESTREO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MUESTREO.Location = new System.Drawing.Point(197, 80);
            this.MUESTREO.Name = "MUESTREO";
            this.MUESTREO.Size = new System.Drawing.Size(506, 272);
            this.MUESTREO.TabIndex = 4;
            this.MUESTREO.Paint += new System.Windows.Forms.PaintEventHandler(this.MUESTREO_Paint);
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(54, 17);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(75, 23);
            this.Inicio.TabIndex = 2;
            this.Inicio.Text = "INICIO";
            this.Inicio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 356);
            this.Controls.Add(this.MUESTREO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraOpciones.ResumeLayout(false);
            this.BarraOpciones.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Usuario)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acvtividad)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogoTec;
        private System.Windows.Forms.PictureBox IconoCasa;
        private System.Windows.Forms.PictureBox Usuario;
        private System.Windows.Forms.PictureBox acvtividad;
        private System.Windows.Forms.PictureBox ayuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox soporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MUESTREO;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ADMIN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button Inicio;
    }
}

