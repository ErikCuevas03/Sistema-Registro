using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ProyectHilos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void ProcesoRegistro()
        {
            // Simulamos un retraso para representar el proceso de registro
            // En una aplicación real, aquí se realizaría el proceso de registro en sí
            Thread.Sleep(3000);

            // Actualizamos la interfaz de usuario desde el hilo principal
            this.Invoke((MethodInvoker)delegate
            {
                // Simplemente mostramos un mensaje para indicar que el registro se ha completado
                MessageBox.Show("Registro completado.");
            });
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            // Simulamos el registro de entrada y salida en un hilo separado
            Thread registroThread = new Thread(new ThreadStart(ProcesoRegistro));
            registroThread.Start();
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            // Simulamos el registro de entrada y salida en un hilo separado
            Thread registroThread = new Thread(new ThreadStart(ProcesoRegistro));
            registroThread.Start();
        }

        public event EventHandler Salir;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir?.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
