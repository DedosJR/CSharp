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

namespace Ejercicio6
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;User Id=root;database=login"); //solo cambiar el nombre de la base de datos
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE BINARY Usuario= '" + textBox1.Text + "'AND BINARY Password= '" + textBox2.Text + "' ", conexion); // query para validar usuario y contraseña 
            MySqlDataReader leer = cmd.ExecuteReader(); //permite ejecutar la consulta 

            if (leer.Read()) //Permite validar la lectura de la consulta y que esta coincida con los registros correctos
            {
                this.Hide();
                bienvenido b = new bienvenido(); //Es el nombre del segundo form que dará la bienvenida 
                b.Show();
            }

            else
            {
                MessageBox.Show("Error - Ingrese sus datos correctamente");
                conexion.Close(); //Cerramos la conexion.
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
