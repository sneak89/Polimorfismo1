using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo1
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
            // Las dos lineas verticales || indican el operador OR logico y && el operador Y logico
            if(textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
            {
                MessageBox.Show("Ingresa los datos faltantes"); 
            }
            else
            {
                double b = double.Parse(textBox3.Text);
                double a = double.Parse(textBox4.Text);

                Carroceria carroc = new Carroceria(textBox2.Text, b, a);
                textBox1.Text = carroc.MostrarArea();
            }

           
        }
    }
}
