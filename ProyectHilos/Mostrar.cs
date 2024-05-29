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
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }


        private void Mostrar_Load(object sender, EventArgs e)
        {
            // declaracion para conectar a la base de datos 
            String conection = " server = localhost ; port =3306 ; uid = root; pwd= ''; database = alumno";
            MySqlConnection conect = new MySqlConnection(conection);

            try
            {
                conect.Open();

                // Consulta SQL para obtener los datos de la tabla de alumnos
                string query = "SELECT * FROM estudiante"; // Ajusta el nombre de la tabla según sea necesario

                MySqlCommand cmd = new MySqlCommand(query, conect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Asigna el DataTable como origen de datos del DataGridView
                Bd.DataSource = dt;

                conect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conectarse a la base de datos: " + ex.Message);
            }

        }
        private void Bd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
