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
            this.barra = new System.Windows.Forms.Panel();
            this.Usuario = new System.Windows.Forms.PictureBox();
            this.acvtividad = new System.Windows.Forms.PictureBox();
            this.LogoTec = new System.Windows.Forms.PictureBox();
            this.IconoCasa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ayuda = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soporte = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.btnRegistrarEntradaSalidaHilo = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.BarraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acvtividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soporte)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraOpciones
            // 
            this.BarraOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BarraOpciones.BackColor = System.Drawing.Color.RoyalBlue;
            this.BarraOpciones.Controls.Add(this.barra);
            this.BarraOpciones.Controls.Add(this.Usuario);
            this.BarraOpciones.Controls.Add(this.acvtividad);
            this.BarraOpciones.Controls.Add(this.LogoTec);
            this.BarraOpciones.Controls.Add(this.IconoCasa);
            this.BarraOpciones.Controls.Add(this.label1);
            this.BarraOpciones.Location = new System.Drawing.Point(2, 0);
            this.BarraOpciones.Name = "BarraOpciones";
            this.BarraOpciones.Size = new System.Drawing.Size(144, 328);
            this.BarraOpciones.TabIndex = 0;
            // 
            // barra
            // 
            this.barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barra.Location = new System.Drawing.Point(150, 3);
            this.barra.Name = "barra";
            this.barra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barra.Size = new System.Drawing.Size(303, 58);
            this.barra.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Usuario.Image")));
            this.Usuario.Location = new System.Drawing.Point(49, 266);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(45, 45);
            this.Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Usuario.TabIndex = 1;
            this.Usuario.TabStop = false;
            // 
            // acvtividad
            // 
            this.acvtividad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acvtividad.Image = ((System.Drawing.Image)(resources.GetObject("acvtividad.Image")));
            this.acvtividad.Location = new System.Drawing.Point(49, 182);
            this.acvtividad.Name = "acvtividad";
            this.acvtividad.Size = new System.Drawing.Size(45, 45);
            this.acvtividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acvtividad.TabIndex = 1;
            this.acvtividad.TabStop = false;
            // 
            // LogoTec
            // 
            this.LogoTec.Image = ((System.Drawing.Image)(resources.GetObject("LogoTec.Image")));
            this.LogoTec.Location = new System.Drawing.Point(31, 12);
            this.LogoTec.Name = "LogoTec";
            this.LogoTec.Size = new System.Drawing.Size(78, 68);
            this.LogoTec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoTec.TabIndex = 1;
            this.LogoTec.TabStop = false;
            this.LogoTec.UseWaitCursor = true;
            // 
            // IconoCasa
            // 
            this.IconoCasa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IconoCasa.Image = ((System.Drawing.Image)(resources.GetObject("IconoCasa.Image")));
            this.IconoCasa.Location = new System.Drawing.Point(49, 106);
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
            // ayuda
            // 
            this.ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ayuda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ayuda.Image = ((System.Drawing.Image)(resources.GetObject("ayuda.Image")));
            this.ayuda.Location = new System.Drawing.Point(233, 16);
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
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 80);
            this.panel1.TabIndex = 2;
            // 
            // soporte
            // 
            this.soporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soporte.Image = ((System.Drawing.Image)(resources.GetObject("soporte.Image")));
            this.soporte.Location = new System.Drawing.Point(182, 16);
            this.soporte.Name = "soporte";
            this.soporte.Size = new System.Drawing.Size(45, 45);
            this.soporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soporte.TabIndex = 2;
            this.soporte.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(47, 29);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarEntrada.TabIndex = 3;
            this.btnRegistrarEntrada.Text = "Registrar entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.textNombre);
            this.panel3.Controls.Add(this.btnRegistrarEntradaSalidaHilo);
            this.panel3.Controls.Add(this.btnRegistrarSalida);
            this.panel3.Controls.Add(this.btnRegistrarEntrada);
            this.panel3.Location = new System.Drawing.Point(146, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 251);
            this.panel3.TabIndex = 4;
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarSalida.Location = new System.Drawing.Point(47, 83);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarSalida.TabIndex = 4;
            this.btnRegistrarSalida.Text = "Registrar Salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // btnRegistrarEntradaSalidaHilo
            // 
            this.btnRegistrarEntradaSalidaHilo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarEntradaSalidaHilo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarEntradaSalidaHilo.Location = new System.Drawing.Point(47, 140);
            this.btnRegistrarEntradaSalidaHilo.Name = "btnRegistrarEntradaSalidaHilo";
            this.btnRegistrarEntradaSalidaHilo.Size = new System.Drawing.Size(126, 36);
            this.btnRegistrarEntradaSalidaHilo.TabIndex = 5;
            this.btnRegistrarEntradaSalidaHilo.Text = "Registro";
            this.btnRegistrarEntradaSalidaHilo.UseVisualStyleBackColor = true;
            this.btnRegistrarEntradaSalidaHilo.Click += new System.EventHandler(this.btnRegistrarEntradaSalidaHilo_Click);
            // 
            // textNombre
            // 
            this.textNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNombre.Location = new System.Drawing.Point(200, 36);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(89, 20);
            this.textNombre.TabIndex = 6;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 332);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraOpciones.ResumeLayout(false);
            this.BarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acvtividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soporte)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogoTec;
        private System.Windows.Forms.PictureBox IconoCasa;
        private System.Windows.Forms.PictureBox Usuario;
        private System.Windows.Forms.PictureBox acvtividad;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox ayuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox soporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarEntrada;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Button btnRegistrarEntradaSalidaHilo;
        private System.Windows.Forms.TextBox textNombre;
    }
}

