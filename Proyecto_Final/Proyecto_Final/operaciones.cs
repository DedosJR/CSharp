using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class operaciones : Form
    {
        public operaciones()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btn_agrepro_Click(object sender, EventArgs e)
        {
            this.Hide();
            productos b = new productos(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_agreclie_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes b = new clientes(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_actpro_Click(object sender, EventArgs e)
        {
            this.Hide();
            productos b = new productos(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_actclie_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes b = new clientes(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_elimpro_Click(object sender, EventArgs e)
        {
            this.Hide();
            productos b = new productos(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_elimclie_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes b = new clientes(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_buspro_Click(object sender, EventArgs e)
        {
            this.Hide();
            user b = new user(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void btn_busclie_Click(object sender, EventArgs e)
        {
            
        }

        private void lab_cerrars_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 I= new Form1();
            I.Show();   


        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 boi = new Form3(); //Es el nombre del segundo form que dará la bienvenida 
            boi.Show();
        }
    }
}
