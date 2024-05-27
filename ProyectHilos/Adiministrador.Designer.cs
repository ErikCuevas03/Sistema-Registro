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
            this.Salir = new System.Windows.Forms.Button();
            this.Revisar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.Revisar);
            this.panel1.Controls.Add(this.Eliminar);
            this.panel1.Controls.Add(this.Agregar);
            this.panel1.Location = new System.Drawing.Point(49, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 311);
            this.panel1.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(37, 161);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(141, 37);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "SALIR";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Revisar
            // 
            this.Revisar.Location = new System.Drawing.Point(37, 124);
            this.Revisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Revisar.Name = "Revisar";
            this.Revisar.Size = new System.Drawing.Size(141, 30);
            this.Revisar.TabIndex = 2;
            this.Revisar.Text = "REVISAR";
            this.Revisar.UseVisualStyleBackColor = true;
            this.Revisar.Click += new System.EventHandler(this.Revisar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(37, 90);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(141, 27);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(37, 47);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(141, 36);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "AGREGAR";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Adiministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 407);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Adiministrador";
            this.Text = "Adiministrador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Revisar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Agregar;
    }
}