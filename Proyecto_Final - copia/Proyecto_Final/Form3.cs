
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
using Microsoft.Reporting.WinForms;

namespace Proyecto_Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();

          
        }
        
        //Datos para rellenar tabla de productos 



            private void button1_Click(object sender, EventArgs e)
            {
                MySqlConnection conexion = new MySqlConnection("Server=107.180.21.51; PORT=3306; database=mibodega; User Id=Mibod_User; Password=15ra3lif"); //solo cambiar el nombre de la base de datos
                conexion.Open();

            String datos = "SELECT * FROM productos";

            MySqlCommand cmd = new MySqlCommand(datos, conexion);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
              
               
                da.Fill(dt);
            
                     
                    ReportDataSource fd = new ReportDataSource("reporte_1", dt);
                reportViewer1.LocalReport.DataSources.Add(fd);
              reportViewer1.RefreshReport();

            conexion.Close();
               

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            operaciones b = new operaciones(); // form de operaciones 
            b.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
    }