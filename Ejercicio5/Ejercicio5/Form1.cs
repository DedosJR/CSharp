using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = " ";

            if (checkBox1.Checked == true)
            {
                mensaje = mensaje + " Word, ";
                           
             }
            if (checkBox2.Checked == true)
            {
                mensaje = mensaje + " Excel, ";

            }
            if (checkBox3.Checked == true)
            {
                mensaje = mensaje + " Access, ";

            }
            if (checkBox4.Checked == true)
            {
                mensaje = mensaje + " Power Point, ";

            }
            if (checkBox5.Checked == true)
            {
                mensaje = mensaje + " Ninguno ";

            }
            {
                MessageBox.Show("Los programas que maneja son: " + mensaje);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
