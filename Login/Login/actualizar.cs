using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Login
{
    public partial class actualizar : Form
    {
        public actualizar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void actualizar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    

        }

        public DataTable llenar_grid()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;User Id=root;database=mibodega"); //solo cambiar el nombre de la base de datos
            conexion.Open();

            DataTable dt = new DataTable();
            String llenar = "SELECT * FROM productos";
            MySqlCommand cmd = new MySqlCommand(llenar, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones b = new opciones(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;User Id=root;database=mibodega"); //solo cambiar el nombre de la base de datos
         

         
            String Query = "INSERT INTO PRODUCTOS (Codigo_Producto, Nombre, Descripcion, Precio, Cantidad) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox5.Text+"','"+textBox4.Text+"')";
   
            conexion.Open();
          

            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, conexion);
                cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro ingresado correctamente !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                

            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                // Cierro la Conexión.
                conexion.Close();
            }
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
             string Codigo_Producto = textBox1.Text;
            MySqlDataReader reader = null;
               string sql= "SELECT * FROM productos";
            MySqlConnection conexion = new MySqlConnection("server=localhost;User Id=root;database=mibodega");
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
             reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox1.Text = reader.GetString(0);
                        textBox2.Text = reader.GetString(1);
                        textBox3.Text = reader.GetString(2);
                        textBox4.Text = reader.GetString(3);
                        textBox5.Text = reader.GetString(4);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron Registros ");

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Buscar " + ex.Message);


            }
         
            finally
            {
               
                // Cierro la Conexión.
                conexion.Close();
            }
           
        }
    }
}
