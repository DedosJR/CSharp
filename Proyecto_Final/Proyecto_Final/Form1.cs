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
namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost; PORT=3306; database=mibodega; User Id=root; Password="); 
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE BINARY Usuario= '" + textBox1.Text + "'AND BINARY Password= '" + textBox2.Text + "' ", conexion); // query para validar usuario y contraseña 
            MySqlDataReader leer = cmd.ExecuteReader(); //permite ejecutar la consulta 

            if (leer.Read()) //Permite validar la lectura de la consulta y que esta coincida con los registros correctos
            {
                this.Hide();
                operaciones b = new operaciones(); //Es el nombre del segundo form que dará la bienvenida 
                b.Show();
            }

            else
            {
                MessageBox.Show("Error - Ingrese sus datos correctamente");
                conexion.Close(); //Cerramos la conexion.
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // form de Registro usuario
        private void lbl_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            user b = new user(); 
            b.Show();
        }

        //Condicion para campos vacios en el registro
        private void chec_passw_CheckedChanged(object sender, EventArgs e)
        {
            if (chec_passw.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
