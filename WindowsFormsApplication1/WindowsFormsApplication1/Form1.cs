using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        char operacja;
        double liczba1;
        double liczba2;
        double wynik;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e) //=
        {
            liczba2 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            switch (operacja)
            {
                case '+':
                    wynik = liczba1 + liczba2;
                    textBox1.Text = wynik.ToString();
                    break;
                case '-':
                    wynik = liczba1 - liczba2;
                    textBox1.Text = wynik.ToString();
                    break;
                case '*':
                    wynik = liczba1 * liczba2;
                    textBox1.Text = wynik.ToString();
                    break;
                case '/':
                    wynik = liczba1 / liczba2;
                    textBox1.Text = wynik.ToString();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            liczba1 = 0;
            liczba2 = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            liczba1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operacja = '+';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            liczba1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operacja = '-';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            liczba1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operacja = '*';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            liczba1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operacja = '/';
        }
    }
}
