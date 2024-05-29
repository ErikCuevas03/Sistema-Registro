using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //  declaracion para mysql
namespace ProyectHilos
{
    public partial class Adiministrador : Form
    {
        public Adiministrador()
        {
            InitializeComponent();
        }

        // declaracion para conectar a la base de datos 
        // String conection = " server = localhost ; port =3306 ; uid = root; pwd= ''; database = alumno";
        String conection = " server = sql3.freesqldatabase.com ; port =3306 ; uid = sql3710149; pwd= '9hrWq9s4fV'; database = sql3710149";

        private void Abrir(object nuevoform)
        {
            if (this.muestra.Controls.Count > 0)
                this.muestra.Controls.RemoveAt(0);
            Form fn = nuevoform as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.muestra.Controls.Add(fn);
            this.muestra.Tag = fn;
            fn.Show();
        }

        public event EventHandler Cerrar; // evento cerrar
        private void Salir_Click(object sender, EventArgs e) // boton patra salir del form 
        {
            Cerrar?.Invoke(this, EventArgs.Empty);
        }

        private void Revisar_Click(object sender, EventArgs e)
        {
            Abrir(new Mostrar());

        }

        private void button1_Click(object sender, EventArgs e)
        {

                MySqlConnection conect = new MySqlConnection(conection);
                try
                {
                    conect.Open();
                    MessageBox.Show(" conectado correctamente");
                    conect.Close();
                }
                catch
                {
                    MessageBox.Show(" error en concetarse a la base de datos");
                }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Abrir(new Agregar());
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
