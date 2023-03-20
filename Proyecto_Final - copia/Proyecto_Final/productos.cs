using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            operaciones b = new operaciones(); // form de operaciones 
            b.Show();
        }
        //Traer cinexion a la tabla de SqL
        private void productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = datos_grid();
        }


        //Datos para rellenar tabla de productos 
        public DataTable datos_grid()
        {
            MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif"); //solo cambiar el nombre de la base de datos
            conexion.Open();

        

            
         
                DataTable dt = new DataTable();
            String datos = "SELECT * FROM productos";
            MySqlCommand cmd = new MySqlCommand(datos, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        //Boton Insertaar 
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif");
            conexion.Open();
            string codigo = txt_codigo.Text;
            string Nombre = txt_nombre.Text;
            string Descripcion = txt_descripcion.Text;
            string precio = txt_precio.Text;
            string stock = txt_stock.Text;

            //Condicion para espacios vacios 
            if (codigo != "" && Nombre != "" && Descripcion != "" && precio != "" && stock != "")
            {

                String agregar = "INSERT INTO PRODUCTOS (codigo_producto,nombre,descripcion,precio,stock) VALUES " +
                "('" + txt_codigo.Text + "','" + txt_nombre.Text + "','" + txt_descripcion.Text + "','" + txt_precio.Text + "','" + txt_stock.Text + "')";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(agregar, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertado correctamente: ");
                    dataGridView1.DataSource = datos_grid();

                    //Vacias Campos 
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_descripcion.Text = "";
                    txt_precio.Text = "";
                    txt_stock.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);


                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        //Boton Actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif");
            conexion.Open();
            string codigo = txt_codigo.Text;
            string Nombre = txt_nombre.Text;
            string Descripcion = txt_descripcion.Text;
            string precio = txt_precio.Text;
            string stock = txt_stock.Text;

            if (codigo != "" && Nombre != "" && Descripcion != "" && precio != "" && stock !="")
            {

                String update = "UPDATE PRODUCTOS SET  nombre = '"+Nombre+"',descripcion = '"+Descripcion+"', precio = '"+precio+"', stock = '"+stock+ "'where codigo_producto = '"+codigo+"'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(update, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizacion Correcta");
                dataGridView1.DataSource = datos_grid();


                    //Vacias Campos 
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_descripcion.Text = "";
                txt_precio.Text = "";
                txt_stock.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);


            }
            finally
            {
                conexion.Close();
            }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        //Boton Eliminar

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif");
            conexion.Open();
            string codigo = txt_codigo.Text;
            
            String delete = "DELETE From PRODUCTOS where codigo_producto = '" + codigo + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(delete, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                dataGridView1.DataSource = datos_grid();
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_descripcion.Text = "";
                txt_precio.Text = "";
                txt_stock.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);


            }
            finally
            {
                conexion.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Boton Buscar
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif");
            conexion.Open();

            MySqlCommand cmd = conexion.CreateCommand();


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM productos where Nombre like ('" + txt_buscar.Text + "%')";
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conexion.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

    
