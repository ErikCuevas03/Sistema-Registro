using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonaLibrary; //referencia de la libreria 
//using System.Threading;
namespace ProyectHilos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
             
        private void IconoCasa_Click(object sender, EventArgs e)
        {

        }

        private void MUESTREO_Paint(object sender, PaintEventArgs e)
        { }

        // SE CREA UN METODO PARA MOSTRAR EN PANEL MUESTREO
        private void Abrir(object nuevoform)
        {
            if (this.MUESTREO.Controls.Count > 0)
                this.MUESTREO.Controls.RemoveAt(0);
            Form fn = nuevoform as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.MUESTREO.Controls.Add(fn);
            this.MUESTREO.Tag = fn;
            fn.Show();

            // si el formulario es Inicio
            if(fn is Inicio inicioform)
            {
                inicioform.Salir += InicioForm_Salida;
            }

            // si el formulario es Usuario
            if(fn is Usuario usuarioform) 
            {
                usuarioform.Salida += UsuarioForm_Salida;
            }

            // si el formulario es Adiministrador
            if (fn is Adiministrador adminform)
            {
                adminform.Cerrar += AdminForm_Salida;
            }
        }
    
        // Método para limpiar el panel MUESTREO
        private void LimpiarMuestreo()
        {
            foreach (Control control in MUESTREO.Controls)
            {
                control.Dispose();
            }
            MUESTREO.Controls.Clear();
        }

        // Evento para  manejar el evento Salir del formulario Inicio
        private void InicioForm_Salida(object sender, EventArgs e)
        {
            // Cuando se dispara el evento Salir , limpiamos el panel MUESTREO
            LimpiarMuestreo();
        }

        // Evento para  manejar el evento Salir del formulario Usuario
        private void UsuarioForm_Salida(object sender, EventArgs e)
        {
            // Cuando se dispara el evento Salida , limpiamos el panel MUESTREO
            LimpiarMuestreo();
            Abrir(new Adiministrador());
        }

        // Evento para  manejar el evento Salir del formulario Adimistrador
        private void AdminForm_Salida(object sender, EventArgs e)
        {
            // Cuando se dispara el evento Cerrar, limpiamos el panel MUESTREO
            LimpiarMuestreo();
        }

        private void Registro_Click(object sender, EventArgs e) // inserta el nuevo form en muestreo 
        {
            Abrir(new Inicio());

        }

        private void Usuario_Click(object sender, EventArgs e) // Aun no se que hace 
        {} 

        private void ADMIN_Click(object sender, EventArgs e) //inserta el form Usuario en Muestreo
        {
            Abrir(new Usuario());
        }
    }
}
