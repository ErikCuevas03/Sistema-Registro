namespace ProyectHilos
{
    partial class Adiministrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.muestra = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Revisar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.muestra);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.Revisar);
            this.panel1.Controls.Add(this.Eliminar);
            this.panel1.Controls.Add(this.Agregar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 253);
            this.panel1.TabIndex = 0;
            // 
            // muestra
            // 
            this.muestra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.muestra.AutoSize = true;
            this.muestra.Location = new System.Drawing.Point(140, 38);
            this.muestra.Name = "muestra";
            this.muestra.Size = new System.Drawing.Size(339, 153);
            this.muestra.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONECTAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(28, 131);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(106, 30);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "SALIR";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Revisar
            // 
            this.Revisar.Location = new System.Drawing.Point(28, 101);
            this.Revisar.Name = "Revisar";
            this.Revisar.Size = new System.Drawing.Size(106, 24);
            this.Revisar.TabIndex = 2;
            this.Revisar.Text = "REVISAR";
            this.Revisar.UseVisualStyleBackColor = true;
            this.Revisar.Click += new System.EventHandler(this.Revisar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(28, 73);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(106, 22);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(28, 38);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(106, 29);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "AGREGAR";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Adiministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 331);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adiministrador";
            this.Text = "Adiministrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Revisar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel muestra;
    }
}