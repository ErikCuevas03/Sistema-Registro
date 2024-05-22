using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectHilos
{
    public partial class Adiministrador : Form
    {
        public Adiministrador()
        {
            InitializeComponent();
        }
        public event EventHandler Cerrar; // evento cerrar
        private void Salir_Click(object sender, EventArgs e) // boton patra salir del form 
        {
            Cerrar?.Invoke(this, EventArgs.Empty);
        }
    }
}
