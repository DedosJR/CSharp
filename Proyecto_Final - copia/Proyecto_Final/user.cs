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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

     

       private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1(); // form de operaciones 
            b.Show();
        }
  
      

    

        private void btn_agre_Click_1(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif");
            conexion.Open();
            string user = txt_user.Text;
            string pass = txt_pass.Text;

            if (user != "" && pass != "")
            {


                String insert = "INSERT INTO users (Usuario, Password) VALUES ('" + user + "',  '" + pass + "')";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(insert, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SE INSERTO CON EXITO");

                    txt_user.Text = "";
                    txt_pass.Text = "";


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
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void chek_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chek_pass.Checked)
            {
                txt_pass.UseSystemPasswordChar=true;
            }
            else
            {
                txt_pass.UseSystemPasswordChar=false;       
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
          

        }
    }
}
