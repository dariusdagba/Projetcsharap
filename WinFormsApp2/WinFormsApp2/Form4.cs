using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExecuter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox2.Text == " ")
            {
                MessageBox.Show(" Veuillez entrer des valeurs");
            }
            else
            {
                if (radioButtonAdd.Checked)
                {
                    double p = Convert.ToDouble(textBox1.Text);
                    double q = Convert.ToDouble(textBox2.Text);
                    double r = somme(p, q);
                    textBox3.Text = r.ToString();
                }
                else if (radioButtonSous.Checked)
                {
                    double p = Convert.ToDouble(textBox1.Text);
                    double q = Convert.ToDouble(textBox2.Text);
                    double r = soustraction(p, q);
                    textBox3.Text = r.ToString();
                }
                else if (radioButtonMul.Checked)
                {
                    double p = Convert.ToDouble(textBox1.Text);
                    double q = Convert.ToDouble(textBox2.Text);
                    double r = multiplication(p, q);
                    textBox3.Text = r.ToString();
                }
                else
                {
                    double p = Convert.ToDouble(textBox1.Text);
                    double q = Convert.ToDouble(textBox2.Text);
                    double r = division(p, q);
                    textBox3.Text = r.ToString();
                }
            }


        }
        double somme(double a, double b)
        {
            double c = a + b;
            return c;
        }
        double soustraction(double e, double f)
        {
            double g = e - f;
            return g;
        }
        double multiplication(double h, double i)
        {
            double j = h * i;
            return j;
        }
        double division(double k, double l)
        {
            double m = k / l;
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
