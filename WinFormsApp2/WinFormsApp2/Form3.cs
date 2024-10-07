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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Veuillez entrer une valeur en dollar");

                }
                else
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = 0.67488704 * a;
                    textBox2.Text = b.ToString();
                }
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Veuillez entrer une valeur en dollar");

                }
                else
                {
                    double c = Convert.ToDouble(textBox2.Text);
                    double d = c / 0.67488704;
                    textBox1.Text = d.ToString();
                }
            }
            
           

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void buttonExo4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
