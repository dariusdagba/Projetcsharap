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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show(" Veuiller entrer des valeurs");
            }
            else
            {
                double valIn = Convert.ToDouble(textBox1.Text);
                double valFin = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                listBox1.Items.Clear();
                listBox1.Items.Add("La boucle For");


                for (double i = valIn; i <= valFin; i += c)
                {

                    listBox1.Items.Add(i);

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show(" Veuiller entrer des valeurs");
            }
            else
            {
                double valIn = Convert.ToDouble(textBox1.Text);
                double valFin = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                listBox1.Items.Clear();

                listBox1.Items.Add("La boucle While");
                double i = valIn;
                while (i <= valFin)
                {

                    listBox1.Items.Add(i);
                    i += c;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show(" Veuiller entrer des valeurs");
            }
            else
            {


                double valIn = Convert.ToDouble(textBox1.Text);
                double valFin = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double i = valIn;

                listBox1.Items.Clear();
                listBox1.Items.Add("La boucle Do While");
                do
                {
                    listBox1.Items.Add(i);
                    i += c;

                }
                while (i <= valFin);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6= new Form6();
            form6.Show();
            this.Hide();
        }
    }
}
