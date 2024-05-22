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

    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        public event EventHandler Salida;

        private void Entrar_Click(object sender, EventArgs e)
        {
            Salida?.Invoke(this, EventArgs.Empty);
        }
    }
}
