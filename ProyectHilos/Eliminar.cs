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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        private string conection = "server=localhost;port=3306;uid=root;pwd='';database=alumno";
        //String conection = " server = sql3.freesqldatabase.com ; port =3306 ; uid = sql3710149; pwd= '9hrWq9s4fV'; database = sql3710149";


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

        private bool MostrarDatos(string control)
        {
            using (MySqlConnection conect = new MySqlConnection(conection))
            {
                try
                {
                    conect.Open();
                    string query = "SELECT * FROM estudiante WHERE ncontrol = @control";
                    MySqlCommand cmd = new MySqlCommand(query, conect);
                    cmd.Parameters.AddWithValue("@control", control);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        string semestre = reader["semestre"].ToString();
                        string carrera = reader["carrera"].ToString();
                        string mensaje = $"Nombre: {nombre}\nControl: {control}\nSemestre: {semestre}\nCarrera: {carrera}\n\n¿Desea eliminar este registro?";
                        DialogResult result = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            return true;
                        }
                    } else
                    {
                        MessageBox.Show("No se encontraron registros con ese número de control");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al recuperar los datos: " + ex.Message);
                }
            }
            return false;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            string control = txtncontrol.Text;

            // Verificar y eliminar los datos si el usuario confirma
            if (MostrarDatos(control))
            {
                EliminarDatos(control);
            }
        }
    }
}
