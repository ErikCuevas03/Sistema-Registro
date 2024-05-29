namespace ProyectHilos
{
    partial class Agregar
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
            this.añadir = new System.Windows.Forms.GroupBox();
            this.agrega = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.Label();
            this.txtncontrol = new System.Windows.Forms.TextBox();
            this.carer = new System.Windows.Forms.Label();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.semes = new System.Windows.Forms.Label();
            this.txtsemestre = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.añadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // añadir
            // 
            this.añadir.Controls.Add(this.btnInsertar);
            this.añadir.Controls.Add(this.txtsemestre);
            this.añadir.Controls.Add(this.semes);
            this.añadir.Controls.Add(this.txtcarrera);
            this.añadir.Controls.Add(this.carer);
            this.añadir.Controls.Add(this.txtncontrol);
            this.añadir.Controls.Add(this.nc);
            this.añadir.Controls.Add(this.txtnombre);
            this.añadir.Controls.Add(this.agrega);
            this.añadir.Location = new System.Drawing.Point(57, 12);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(477, 224);
            this.añadir.TabIndex = 0;
            this.añadir.TabStop = false;
            this.añadir.Text = "Agrupar";
            this.añadir.Enter += new System.EventHandler(this.añadir_Enter);
            // 
            // agrega
            // 
            this.agrega.AutoSize = true;
            this.agrega.Location = new System.Drawing.Point(6, 26);
            this.agrega.Name = "agrega";
            this.agrega.Size = new System.Drawing.Size(47, 13);
            this.agrega.TabIndex = 0;
            this.agrega.Text = "Nombre ";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(9, 43);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(462, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // nc
            // 
            this.nc.AutoSize = true;
            this.nc.Location = new System.Drawing.Point(6, 81);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(95, 13);
            this.nc.TabIndex = 2;
            this.nc.Text = "Numero de Control";
            // 
            // txtncontrol
            // 
            this.txtncontrol.Location = new System.Drawing.Point(6, 97);
            this.txtncontrol.Name = "txtncontrol";
            this.txtncontrol.Size = new System.Drawing.Size(157, 20);
            this.txtncontrol.TabIndex = 3;
            // 
            // carer
            // 
            this.carer.AutoSize = true;
            this.carer.Location = new System.Drawing.Point(9, 124);
            this.carer.Name = "carer";
            this.carer.Size = new System.Drawing.Size(41, 13);
            this.carer.TabIndex = 4;
            this.carer.Text = "Carrera";
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(6, 141);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(465, 20);
            this.txtcarrera.TabIndex = 5;
            // 
            // semes
            // 
            this.semes.AutoSize = true;
            this.semes.Location = new System.Drawing.Point(6, 182);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(51, 13);
            this.semes.TabIndex = 6;
            this.semes.Text = "Semestre";
            // 
            // txtsemestre
            // 
            this.txtsemestre.Location = new System.Drawing.Point(7, 198);
            this.txtsemestre.Name = "txtsemestre";
            this.txtsemestre.Size = new System.Drawing.Size(156, 20);
            this.txtsemestre.TabIndex = 7;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(351, 196);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(120, 23);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 287);
            this.Controls.Add(this.añadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.añadir.ResumeLayout(false);
            this.añadir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox añadir;
        private System.Windows.Forms.TextBox txtsemestre;
        private System.Windows.Forms.Label semes;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label carer;
        private System.Windows.Forms.TextBox txtncontrol;
        private System.Windows.Forms.Label nc;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label agrega;
        private System.Windows.Forms.Button btnInsertar;
    }
}