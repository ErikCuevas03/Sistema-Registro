namespace ProyectHilos
{
    partial class Mostrar
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
            this.Bd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Bd)).BeginInit();
            this.SuspendLayout();
            // 
            // Bd
            // 
            this.Bd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bd.Location = new System.Drawing.Point(40, 28);
            this.Bd.Name = "Bd";
            this.Bd.Size = new System.Drawing.Size(374, 176);
            this.Bd.TabIndex = 0;
            this.Bd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bd_CellContentClick);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 312);
            this.Controls.Add(this.Bd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Bd;
    }
}