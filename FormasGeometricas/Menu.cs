using Atividade4.Formas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            Circulo form = new Circulo(r);
            textBox3.Text = Convert.ToString(form.CalcularArea());
            textBox2.Text = Convert.ToString(form.CalcularPerimetro());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox7.Text);
            double h = Convert.ToDouble(textBox6.Text);
            Triangulo form = new Triangulo(b, h);
            textBox4.Text = Convert.ToString(form.CalcularArea());
            textBox5.Text = Convert.ToString(form.CalcularPerimetro());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox8.Text);
            double h = Convert.ToDouble(textBox11.Text);
            Retangulo form = new Retangulo(b, h);
            textBox9.Text = Convert.ToString(form.CalcularArea());
            textBox10.Text = Convert.ToString(form.CalcularPerimetro());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(textBox15.Text);
            Quadrado form = new Quadrado(l);
            textBox13.Text = Convert.ToString(form.CalcularArea());
            textBox14.Text = Convert.ToString(form.CalcularPerimetro());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(textBox12.Text);
            double a = Convert.ToDouble(textBox18.Text);
            Pentagono form = new Pentagono(l, a);
            textBox16.Text = Convert.ToString(form.CalcularArea());
            textBox17.Text = Convert.ToString(form.CalcularPerimetro());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(textBox19.Text);
            double a = Convert.ToDouble(textBox22.Text);
            Hexagono form = new Hexagono(l, a);
            textBox20.Text = Convert.ToString(form.CalcularArea());
            textBox21.Text = Convert.ToString(form.CalcularPerimetro());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(textBox23.Text);
            double a = Convert.ToDouble(textBox26.Text);
            Octagono form = new Octagono(l, a);
            textBox24.Text = Convert.ToString(form.CalcularArea());
            textBox25.Text = Convert.ToString(form.CalcularPerimetro());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
