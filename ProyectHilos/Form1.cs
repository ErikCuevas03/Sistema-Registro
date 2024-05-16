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
    public partial class Form1 : Form
    {
        private List<Persona> registros;
        public Form1()
        {
            InitializeComponent();
            registros = new List<Persona>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RegistrarEntradaSalida(string tipoRegistro)
        {
            string nombre = textNombre.Text;
            DateTime horaRegistro = DateTime.Now;

            Persona nuevaPersona = new Persona(nombre, horaRegistro, tipoRegistro);

            registros.Add(nuevaPersona);

            string mensaje = $"{tipoRegistro} registrada para {nombre} a las {horaRegistro.ToString("HH:mm:ss")}";
            MessageBox.Show(mensaje, $"Registro de {tipoRegistro}", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        public class Persona
        {
            public string Nombre { get; set; }
            public DateTime HoraRegistro { get; set; }
            public string TipoRegistro { get; set; }

            public Persona(string nombre, DateTime horaRegistro, string tipoRegistro)
            {
                Nombre = nombre;
                HoraRegistro = horaRegistro;
                TipoRegistro = tipoRegistro;
            }
        }

        private void IconoCasa_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
           RegistrarEntradaSalida("Entrada");
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            RegistrarEntradaSalida("Salida");
        }

        private void btnRegistrarEntradaSalidaHilo_Click(object sender, EventArgs e)
        {
            // Simulamos el registro de entrada y salida en un hilo separado
            Thread registroThread = new Thread(new ThreadStart(ProcesoRegistro));
            registroThread.Start();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
