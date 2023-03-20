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
    public partial class opciones : Form
    {
        public opciones()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            actualizar b = new actualizar(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            actualizar b = new actualizar(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientescs b = new clientescs(); //Es el nombre del segundo form que dará la bienvenida 
            b.Show();
        }
    }
    }

