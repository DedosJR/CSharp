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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        //Boton Salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            operaciones b = new operaciones(); // form de operaciones 
            b.Show();
        }

        //Boton Agregar
        private void btn_agregar_Click(object sender, EventArgs e)
        {
    
           
            MySqlConnection conexion = new MySqlConnection("Server=localhost; PORT=3306; database=mibodega; User Id=root; Password=");
            conexion.Open();
            string NumClie= txt_numclie.Text;
            string Nombre = txt_nombre.Text;
            string Direccion = txt_dir.Text;
            string Telefono = txt_tel.Text;
            string LimiteCre = txt_limcre.Text;
            string RFC = txt_rfc.Text;
            string Correo = txt_correo.Text;

            //Condicion para campos vacios 
            if (NumClie!="" && Nombre != "" && Direccion != "" && Telefono!="" && LimiteCre!="" && RFC != "" && Correo != "")

            {

                String agregar = "INSERT INTO CLIENTES (NumClie, Nombre, Direccion, Telefono, RFC, LimiteCre, Correo) VALUES ('" + txt_numclie.Text + "','" + txt_nombre.Text + "','" + txt_dir.Text + "','" + txt_tel.Text + "','" + txt_rfc.Text + "','" + txt_limcre.Text + "','" + txt_correo.Text + "')";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(agregar, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SE INSERTO CON EXITO");
                    dataGridView1.DataSource = datos_grid();

                    //Vacias Campos 
                    txt_numclie.Text = "";
                    txt_nombre.Text = "";
                    txt_dir.Text = "";
                    txt_tel.Text = "";
                    txt_rfc.Text = "";
                    txt_correo.Text = "";
                    txt_limcre.Text = "";



                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERROR NO SE PUDO INSERTAR: " + ex.Message);


                }
                finally
                {
                    conexion.Close();
                }
            }
            //Cerramos condicion de vacios 
            else
            {
                MessageBox.Show(" Debe completar todos los campos ");
            }
        }

        //Boton Actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection("Server=localhost; PORT=3306; database=mibodega; User Id=root; Password=");
            conexion.Open();
            string NumClie= txt_numclie.Text;
            string Nombre = txt_nombre.Text;
            string Direccion = txt_dir.Text;
            string Telefono = txt_tel.Text;
            string LimiteCre = txt_limcre.Text;
            string RFC = txt_rfc.Text;
            string Correo = txt_correo.Text;

            //Condicion para campos vacios 
            if (NumClie != "" && Nombre != "" && Direccion != "" && Telefono != "" && LimiteCre != "" && RFC != "" && Correo != "")

            {

                String updates = "UPDATE CLIENTES SET   nombre = '" + Nombre + "', direccion = '" + Direccion + "', telefono = '" + Telefono + "', limitecre = '" + LimiteCre + "', rfc= '" + RFC + "', correo='" + Correo + "' where numclie= '" + NumClie + "'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(updates, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Actualizacion Correcta");
                    dataGridView1.DataSource = datos_grid();

                    //Vaciar campos 
                    txt_tel.Text = "";
                    txt_correo.Text = "";
                    txt_dir.Text = "";
                    txt_rfc.Text = "";
                    txt_nombre.Text = "";
                    txt_numclie.Text = "";
                    txt_limcre.Text = "";
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
            //Cerramos condicion de vacios 
            else
            {
                MessageBox.Show(" Debe completar todos los campos ");
            }

        }


        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost; PORT=3306; database=mibodega; User Id=root; Password=");
            conexion.Open();
            string clie = txt_numclie.Text;

            String delete = "DELETE From CLIENTES where numclie = '" + clie + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(delete, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                dataGridView1.DataSource = datos_grid();
               clie = "";
              
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


        //Datos para llenar tabla
        private void clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = datos_grid();
           
        }

        //Traer datos a la Tabla 
        public DataTable datos_grid()
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost; PORT=3306; database=mibodega; User Id=root; Password="); 
            conexion.Open();

            DataTable dt = new DataTable();
            String Table = "SELECT * FROM clientes";
            MySqlCommand cmd = new MySqlCommand(Table, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost; PORT=3306; database=mibodega; User Id=root; Password=");
            conexion.Open();

            MySqlCommand cmd = conexion.CreateCommand();


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM clientes where Nombre like ('" + txt_buscar.Text + "%')";
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conexion.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
       
    }
}
