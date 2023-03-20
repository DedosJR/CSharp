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

namespace Login
{
    public partial class clientescs : Form
    {
        public clientescs()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones b = new opciones(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public DataTable llenar_grid()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;User Id=root;database=mibodega"); //solo cambiar el nombre de la base de datos
            conexion.Open();

            DataTable dt = new DataTable();
            String llenar = "SELECT * FROM clientes ";
            MySqlCommand cmd = new MySqlCommand(llenar, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        private void clientescs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
