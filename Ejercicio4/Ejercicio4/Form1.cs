using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = " Los lenguajes seleccionados son: ";
            { 
            if (checkBox1.Checked == true)
            {
                MessageBox.Show(mensaje + " C# ");
            }
            if (checkBox2.Checked == true)
            { 
            MessageBox.Show(mensaje + " PHP ");
        }
            if (checkBox3.Checked == true)
            {
                MessageBox.Show(mensaje + " JAVA ");
            }
            if (checkBox4.Checked == true)
            {
                MessageBox.Show(mensaje + " PYTHON ");
            }
        }

    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
