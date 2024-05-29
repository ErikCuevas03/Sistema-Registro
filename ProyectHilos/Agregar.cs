using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectHilos
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

       private string conection = "server=localhost;port=3306;uid=root;pwd='';database=alumno";
        //String conection = " server = sql3.freesqldatabase.com ; port =3306 ; uid = sql3710149; pwd= '9hrWq9s4fV'; database = sql3710149";
        private void InsertarDatos(string nombre, string control, string semestre, string carrera)
        {
            using (MySqlConnection conect = new MySqlConnection(conection))
            {
                try
                {
                    conect.Open();
                    string query = "INSERT INTO estudiante (nombre, ncontrol, semestre, carrera) VALUES (@nombre, @control, @semestre, @carrera)";
                    MySqlCommand cmd = new MySqlCommand(query, conect);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@control", control);
                    cmd.Parameters.AddWithValue("@semestre", semestre);
                    cmd.Parameters.AddWithValue("@carrera", carrera);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message);
                }
            }
        }

        private void EliminarDatos(string control)
        {
            using (MySqlConnection conect = new MySqlConnection(conection))
            {
                try
                {
                    conect.Open();
                    string query = "DELETE FROM estudiante WHERE ncontrol = @control";
                    MySqlCommand cmd = new MySqlCommand(query, conect);
                    cmd.Parameters.AddWithValue("@control", control);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Datos eliminados correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros con ese número de control");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar los datos: " + ex.Message);
                }
            }
        }


        private void añadir_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string control = txtncontrol.Text;
            string semestre = txtsemestre.Text;
            string carrera = txtcarrera.Text;

            // Llamar al método para insertar los datos
            InsertarDatos(nombre, control, semestre, carrera);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string control = txtncontrol.Text;

            // Llamar al método para eliminar los datos
            EliminarDatos(control);
        }
    }
}
