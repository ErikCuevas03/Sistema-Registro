namespace ProyectHilos
{
    partial class Eliminar
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
            this.groupeliminar = new System.Windows.Forms.GroupBox();
            this.labelcontrol = new System.Windows.Forms.Label();
            this.txtncontrol = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.groupeliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupeliminar
            // 
            this.groupeliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupeliminar.Controls.Add(this.btnborrar);
            this.groupeliminar.Controls.Add(this.txtncontrol);
            this.groupeliminar.Controls.Add(this.labelcontrol);
            this.groupeliminar.Location = new System.Drawing.Point(59, 39);
            this.groupeliminar.Name = "groupeliminar";
            this.groupeliminar.Size = new System.Drawing.Size(330, 173);
            this.groupeliminar.TabIndex = 0;
            this.groupeliminar.TabStop = false;
            this.groupeliminar.Text = "Elimina";
            // 
            // labelcontrol
            // 
            this.labelcontrol.AutoSize = true;
            this.labelcontrol.Location = new System.Drawing.Point(7, 20);
            this.labelcontrol.Name = "labelcontrol";
            this.labelcontrol.Size = new System.Drawing.Size(95, 13);
            this.labelcontrol.TabIndex = 0;
            this.labelcontrol.Text = "Numero de Control";
            // 
            // txtncontrol
            // 
            this.txtncontrol.Location = new System.Drawing.Point(10, 37);
            this.txtncontrol.Name = "txtncontrol";
            this.txtncontrol.Size = new System.Drawing.Size(162, 20);
            this.txtncontrol.TabIndex = 1;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(10, 85);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 283);
            this.Controls.Add(this.groupeliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.groupeliminar.ResumeLayout(false);
            this.groupeliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupeliminar;
        private System.Windows.Forms.TextBox txtncontrol;
        private System.Windows.Forms.Label labelcontrol;
        private System.Windows.Forms.Button btnborrar;
    }
}